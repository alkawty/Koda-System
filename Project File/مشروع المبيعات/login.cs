using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace مشروع_المبيعات
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        DBase d = new DBase();
        private void login_Load(object sender, EventArgs e)
        {
            guna2TextBox1.Focus();
            DataTable dt = d.getdata("select * from susers");
            if (dt.Rows.Count == 0)
            {
                d.dml("insert into susers values ('admin','admin','admin')");
            }
        }
        Style S = new Style();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            string txt =guna2TextBox1.Text;
            string txt1 = guna2TextBox2.Text;

            if (txt.Contains("'"))
            {
                label3.Visible = true;
                
                return;
            }

            else if (txt.Contains("'") || txt.Contains("\""))
            {
                label3.Visible = true;
                
                return;
            }

            else {
                DataTable dt = d.getdata($"select * from susers where name= '{guna2TextBox1.Text}' and password= '{guna2TextBox2.Text}' ");
                
                if (dt.Rows.Count > 0)
                {
                    Controls Menu = new Controls();
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    
                    label3.Visible = true;
                }
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           label3.Visible = false;
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
           label3.Visible = false;
        }
    }
}
