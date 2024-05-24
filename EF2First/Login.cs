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
    public partial class Login : Form
    {
        ITIEF db;
        public Login()
        {
            InitializeComponent();
            db = new ITIEF();
        }
        private void Login_Load(object sender, EventArgs e)
        {
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!=null && txt_pass.Text != null)
            {
                var loguser=db.author.Where(n=>n.name==textBox1.Text).FirstOrDefault();
                if(loguser!=null)
                {
                   if(loguser.password == txt_pass.Text)
                    {
                       
                        MyProfile myProfiles = new MyProfile();
                        myProfiles.vo(loguser.name, loguser.age, loguser.username, loguser.Joindate,loguser.password,loguser.Auth_id);
                        MessageBox.Show("Welcome In your Profile");
                        myProfiles.Show();
                        this.Hide();

                    }
                }
                else
                {
                    MessageBox.Show("Please SignUp start and Login Again");
                    SignUp signUp = new SignUp();
                    signUp.Show();

                }
                
            }

        }

        private void btn_sign_Click(object sender, EventArgs e)
        {

        }

        
    }
}
