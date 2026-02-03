using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace مشروع_المبيعات
{
    class Style
    {

        public void Colorfont(Control Tool, string color="null") {
           
            if (color == "null")
            {
                Tool.ForeColor = Color.FromArgb(125, 137, 149);
            }
            else if (color == "B")
            {
                Tool.ForeColor = Color.Black;
            }
        }
        
       
       

    }
}
