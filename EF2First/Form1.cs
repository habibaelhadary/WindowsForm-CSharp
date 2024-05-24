using EF2First.Models;
using Microsoft.EntityFrameworkCore;

namespace EF2First
{
    public partial class Form1 : Form
    {
        ITIEF db;
        public Form1()
        {
            InitializeComponent();
            db = new ITIEF();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            DGV.DataSource = db.News.ToList();

        }

    }
}
