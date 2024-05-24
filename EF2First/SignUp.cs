using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF2First.Models;
namespace EF2First
{
    
    public partial class SignUp : Form
    {
        ITIEF dbs;

        public SignUp()
        {
            InitializeComponent();
            dbs = new ITIEF();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_age_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            Author auth=new Author()
            {
                name=txt_name.Text,
                age=int.Parse(txt_age.Text),
                password=txt_pass.Text,
                username=txt_user.Text,
                Joindate=DateTime.Today,
            };
            dbs.author.Add(auth);
            dbs.SaveChanges();
            
            if(MessageBox.Show("Now Login again", "confirmation", MessageBoxButtons.YesNo)== DialogResult.Yes){
                this.Hide();
            }

        }
    }
}
