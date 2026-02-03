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
    public partial class prodact : Form
    {
        public prodact()
        {
            InitializeComponent();
        }
        DBase d = new DBase();
        private void prodact_Load(object sender, EventArgs e)
        {

        }
        private void disp()
        {
            guna2DataGridView1.DataSource = d.getdata("select p.id as 'الرقم', p.name as \"اسم المنتج\", p.price as 'السعر', p.quantity as 'الكمية', p.price*p.quantity as \"السعر الكلي\" ,d.name as \"اسم القسم\" from prd p, dpt d where  p.dept_id = d.id and d.isactive = 1");
        }

        private void guna2DataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void guna2DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                MessageBox.Show("لايمكن التعديل ع هذا العمود");
                disp();


            }
            else if (e.ColumnIndex == 1)
            {
                d.dml($"update prd set name = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
            else if (e.ColumnIndex == 2)
            {
                d.dml($"update prd set price = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
            else if (e.ColumnIndex == 3)
            {
                d.dml($"update prd set quantity = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
            else if (e.ColumnIndex == 4)
            {
                d.dml($"update prd set quantity = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
        }

        private void prodact_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controls c = new Controls();
            c.Show();
            this.Hide();
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // if (MessageBox.Show("هل حقا تريد حذف هذا المنتج؟");
            d.dml($"delete from prd where id = {guna2DataGridView1.CurrentRow.Cells[0].Value} ");
            disp();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
