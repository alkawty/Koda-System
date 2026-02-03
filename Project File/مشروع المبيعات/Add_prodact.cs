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
    public partial class Add_prodact : Form
    {
        public Add_prodact()
        {
            InitializeComponent();
        }
        DBase d = new DBase();
        private void Add_prodact_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.DataSource = d.getdata($"select id, name from dpt where isactive = 1");
            guna2ComboBox1.DisplayMember = "name";
            guna2ComboBox1.ValueMember = "id";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "")
            {
                MessageBox.Show("قم بتعبئة البيانات كاملة");
                return;
            }
            d.dml($"insert into prd values('{guna2TextBox2.Text}', {guna2TextBox1.Text} , {guna2TextBox3.Text} , {guna2ComboBox1.SelectedValue} )");
            
        }
    }
}
