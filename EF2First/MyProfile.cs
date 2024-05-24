using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.Components.DictionaryAdapter.Xml;
using EF2First.Models;
namespace EF2First
{
    public partial class MyProfile : Form
    {
        ITIEF db;

        public MyProfile()
        {
            InitializeComponent();
            db = new ITIEF();
        }
        string pass;
        int a_id;
        public void vo(string name, int age, string username, DateTime Jd, string password, int id)
        {
            label4.Text = name;
            la_age.Text = age.ToString();
            usern.Text = username.ToString();
            jionDate.Text = Jd.ToString("yyyy-MM-dd");
            pass = password.ToString();
            a_id = id;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure Log out", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var authorToDelete = db.author.FirstOrDefault(a => a.name == label4.Text && a.password == pass && a.Auth_id == a_id);
                if (authorToDelete != null)
                {
                    db.author.Remove(authorToDelete);
                    db.SaveChanges();
                    MessageBox.Show("Author LogOut successfully.");
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }


            }
        }

        private void MYnew_Click(object sender, EventArgs e)
        {



        }
        void fillgrid(string mes)
        {
            txt_title.Text = txt_des.Text = cobCat.Text = prof.Text = "";
            DGV2.DataSource = db.News.Where(a => a.author.name == label4.Text && a.author.password == pass && a.author.Auth_id == a_id).Select(n => new { New_ID = n.New_id, Title = n.title, brof = n.bref, Descripition = n.descr, Date = n.date, Time = n.time, CatalogeName = n.cat.name }).ToList();

            MessageBox.Show(mes);

        }
        void show(bool c)
        {
            btn_Add.Visible = c;
            btn_edt.Visible = !c;
            btn_delet.Visible = !c;
        }

        private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == AllN)
                DGV2.DataSource = db.News.Select(n => new { New_ID = n.New_id, Title = n.title, brof = n.bref, Descripition = n.descr, Date = n.date, Time = n.time, CatalogeName = n.cat.name, AuthorName = n.author.name }).ToList();
            if (tabControl1.SelectedTab == MYnew)
            {
                DGV1.DataSource = db.News.Where(a => a.author.name == label4.Text && a.author.password == pass && a.author.Auth_id == a_id).Select(n => new { New_ID = n.New_id, Title = n.title, brof = n.bref, Descripition = n.descr, Date = n.date, Time = n.time, CatalogeName = n.cat.name }).ToList();
                cobCat.DataSource = db.catalog.ToList();
                cobCat.DisplayMember = "name";
                cobCat.ValueMember = "Ct_id";
                show(true);
            }
        }
        // Get the current time as a TimeSpan object

        private void btn_Add_Click(object sender, EventArgs e)
        {
            New news = new New()
            {
                title = txt_title.Text,
                bref = prof.Text,
                descr = txt_des.Text,
                Cat_id = (int)cobCat.SelectedValue,
                Au_id = a_id,
                date = DateTime.Today,
                time = DateTime.Now.TimeOfDay,

            };
            db.News.Add(news);
            db.SaveChanges();
            fillgrid("ADDED DONE");
        }
        int id;

        private void DGV1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)DGV1.SelectedRows[0].Cells[0].Value;
            New news = db.News.Where(n => n.New_id == id).FirstOrDefault();
            if (news != null)
            {
                txt_title.Text = news.title;
                txt_des.Text = news.descr;
                prof.Text = news.bref;
                cobCat.SelectedValue = news.Cat_id;
            }
            show(false);
        }

        private void btn_edt_Click(object sender, EventArgs e)
        {
            New news = db.News.Where(n => n.New_id == id).FirstOrDefault();
            news.title = txt_title.Text;
            news.bref = prof.Text;
            news.descr = txt_des.Text;
            news.Cat_id = (int)cobCat.SelectedValue;
            db.SaveChanges();
            show(true);
            fillgrid("Update done");
        }

        private void btn_delet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this new", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                New news = db.News.Where(n => n.New_id == id).FirstOrDefault();
                db.News.Remove(news);
                db.SaveChanges();
                show(true);
                fillgrid("Delete done");
            }
        }
    }
}
