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
    public partial class TGR_form : Form
    {
        public TGR_form()
        {
            InitializeComponent();
        }

        DBase d = new DBase();
        public void disply()
        {
            guna2DataGridView1.DataSource = d.getdata($"select id as 'الرقم', name as 'الاسم' , number1 as 'الرقم الاول' , number2 as 'الرقم الثاني', adress as 'العنوان' from tgr ");
            guna2Button1.Text = "العدد الكلي للموردين  " + guna2DataGridView1.Rows.Count;
        }

        private void TGR_form_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.Font = new Font("Al-Jazeera-Arabic-Bold", 10, FontStyle.Bold);

            disply();
            guna2Button1.Text = "العدد الكلي للموردين  "+ guna2DataGridView1.Rows.Count;

           
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = d.getdata($"select id as 'الرقم', name as 'الاسم' , number1 as 'الرقم الاول' , number2 as 'الرقم الثاني', adress as 'العنوان' from tgr where name like '%{guna2TextBox1.Text}%' ");
            if (guna2DataGridView1.Rows.Count == 0)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
            
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            add_TGR add = new add_TGR();
            add.ShowDialog();
            disply();



        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void TGR_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controls c = new Controls();
            c.Show();
            this.Hide();
        }
    }
}
