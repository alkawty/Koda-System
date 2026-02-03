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
    public partial class add_TGR : Form
    {
        public add_TGR()
        {
            InitializeComponent();
        }


        string name = "أدخل الاسم";
        string num1 = "الرقم الاول";
        string num2 = "الرقم الثاني (إختياري)";
        string address = "العنوان";

        DBase d = new DBase();
        TGR_form tf = new TGR_form();

        //تحقق من الادخال
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (guna2TextBox1.Text == name || guna2TextBox2.Text == num1 || guna2TextBox4.Text == address)
            {
                guna2Button2.Visible = true;
                timer1.Stop();
                timer1.Start();
                guna2Button2.Text = "قم بتعبئة البيانات المطلوبة منك";
                return;
            }
            else
            {
                if (guna2TextBox3.Text == num2)
                {
                    guna2TextBox3.Text = "--";
                }
                d.dml($"insert into TGR (id, name, number1, number2, adress) values (NEXT VALUE FOR TGR_sq,'{guna2TextBox1.Text}', {guna2TextBox2.Text}, '{guna2TextBox3.Text}', '{guna2TextBox4.Text}' )");
                guna2Button2.Text = "تمت الإضافة بنجاح";

                guna2Button2.Visible = true;
                timer1.Stop();
                timer1.Start();
                restyle();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            guna2Button2.Visible = false;
            timer1.Stop();
        }



        Style S = new Style();
        private void restyle()
        {
            S.Colorfont(guna2TextBox1);
            S.Colorfont(guna2TextBox2);
            S.Colorfont(guna2TextBox3);
            S.Colorfont(guna2TextBox4);

            guna2TextBox1.Focus();
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = num1;
            guna2TextBox3.Text = num2;
            guna2TextBox4.Text = address;
        }

        //زر الاغلاق
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }









        // دالة حدث الانتر 

  
        private void add_TGR_Load(object sender, EventArgs e)
        {
           
        }



            private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            
            if (guna2TextBox1.Text == name)
            {
                guna2TextBox1.Text = "";
                S.Colorfont(guna2TextBox1, "B");
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.Text = name;
                S.Colorfont(guna2TextBox1);
            }
        }
        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            
            if (guna2TextBox2.Text == num1)
            {
                guna2TextBox2.Text = "";
                S.Colorfont(guna2TextBox2, "B");
            }
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.Text = num1;
                S.Colorfont(guna2TextBox2);
            }
        }
        private void guna2TextBox3_Enter(object sender, EventArgs e)
        {
            
            if (guna2TextBox3.Text == num2)
            {
                guna2TextBox3.Text = "";
                S.Colorfont(guna2TextBox3, "B");
            }
        }

        private void guna2TextBox3_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text == "")
            {
                guna2TextBox3.Text = num2;
                S.Colorfont(guna2TextBox3);
            }
        }
        private void guna2TextBox4_Enter(object sender, EventArgs e)
        {
            
            if (guna2TextBox4.Text == address)
            {
                guna2TextBox4.Text = "";
                S.Colorfont(guna2TextBox4, "B");
            }
        }

        private void guna2TextBox4_Leave(object sender, EventArgs e)
        {
            if (guna2TextBox4.Text == "")
            {
                S.Colorfont(guna2TextBox4);
                guna2TextBox4.Text = address;
            }
        }

       
    }
}