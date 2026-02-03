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
    public partial class dept : Form
    {
        public dept()
        {
            InitializeComponent();
        }
        DBase d = new DBase();
        private void dept_Load(object sender, EventArgs e)
        {
            disply();
        }
        public void disply()
        {
            guna2DataGridView1.DataSource = d.getdata($"select id as 'رقم القسم', name as 'اسم القسم' from dpt where isactive=1");
            label1.Text = "العدد الكلي   " + guna2DataGridView1.Rows.Count;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                MessageBox.Show("لايجب ترك اسم القسم فارغ", "system", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                d.dml($"insert into dpt (name) values ('{guna2TextBox2.Text}')");
                disply();
                guna2TextBox2.Clear();
                guna2TextBox2.Focus();

            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == palceholder)
            {
                return;
            }

            guna2DataGridView1.DataSource = d.getdata($"select id as \"رقم القسم\", name as \"اسم القسم\" from dpt where name like '%{guna2TextBox1.Text}%' and isactive=1");
            
        }

        string palceholder = "بحث بالاسم . . .";
        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = palceholder;
            }
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == palceholder)
            {

                guna2TextBox1.Text = "";
            }
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {

            d.dml($"update dpt set isactive=0 where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            disply();
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void guna2DataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void guna2DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                MessageBox.Show("لايمكن التعديل ع هذا العمود");
                disply();


            }
            else if (e.ColumnIndex == 1)
            {
                d.dml($"update dpt set name = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
        }

        private void dept_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controls c = new Controls();
            c.Show();
            this.Hide();
        }
    }
}
