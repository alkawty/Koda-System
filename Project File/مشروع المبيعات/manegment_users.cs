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
    public partial class manegment_users : Form
    {
        public manegment_users()
        {
            InitializeComponent();
        }

        DBase d = new DBase();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "" || guna2TextBox2.Text == "" || guna2TextBox3.Text == "")
            {
                MessageBox.Show("قم بتعبئة كافة الحقول");
                return;
            }
            else
            {
                d.dml($"insert into susers values ('{guna2TextBox1.Text}', '{guna2TextBox2.Text}', '{guna2TextBox3.Text}') ");
                MessageBox.Show("تم الحفظ بنجاح");
                disp();
            }
        }
        private void disp()
        {
            guna2DataGridView1.DataSource = d.getdata($"select id as 'الرقم', name as 'الاسم' , email as 'البريد الالكتروني', password as 'كلمة المرور' from susers ");

        }

        private void manegment_users_Load(object sender, EventArgs e)
        {
            disp();
        }
        string palceholder = "بحث بالاسم . . .";
        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == palceholder)
            {
                return;
            }
            guna2DataGridView1.DataSource = d.getdata($"select id as 'الرقم', name as 'الاسم' , email as 'البريد الالكتروني', password as 'كلمة المرور' from susers where name like '%{guna2TextBox4.Text}%' ");
        }

        private void guna2TextBox4_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == "")
            {
                guna2TextBox4.Text = palceholder;
            }
        }

        private void guna2TextBox4_Enter(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == palceholder)
            {

                guna2TextBox4.Text = "";
            }
        }

        private void حذفالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا المستخدم؟","system",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
                d.dml($"delete from susers where id ={guna2DataGridView1.CurrentRow.Cells[0].Value}");
                guna2DataGridView1.Rows.Remove(guna2DataGridView1.CurrentRow);
                
            }
        }

        private void تعديلالمستخدمToolStripMenuItem_Click(object sender, EventArgs e)
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
                disp();


            }
            else if (e.ColumnIndex == 1)
            {
                d.dml($"update susers set name = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
            else if (e.ColumnIndex == 2)
            {
                d.dml($"update susers set email = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
            else if (e.ColumnIndex == 3)
            {
                d.dml($"update susers set password = '{guna2DataGridView1.CurrentCell.Value}' where id = {guna2DataGridView1.CurrentRow.Cells[0].Value}");
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void manegment_users_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controls c = new Controls();
            c.Show();
            this.Hide();
        }
    }
}
