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
    public partial class Controls : Form
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            manegment_users m = new manegment_users();
            m.Show();
            this.Hide();
        }

        private void الاقسامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dept dpt = new dept();
            dpt.Show();
            this.Hide();
        }

        private void المنتجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void تسجيلخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void التوريدالمخزنيToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TGR_form tgr = new TGR_form();
            tgr.Show();
            this.Hide();
        }



        private void Controls_Load(object sender, EventArgs e)
        {
            menuStrip2.Renderer = new CustomMenuRenderer();
            menuStrip2.ImageScalingSize = new Size(20, 20);
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            prodact prd = new prodact();
            prd.Show();
            this.Hide();
        }

        private void الموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TGR_form T = new TGR_form();
            T.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            dept dp = new dept();
            dp.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void maxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void المستخدمينToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            manegment_users mn = new manegment_users();
            mn.Show();
            this.Hide();
        }
    }
}
