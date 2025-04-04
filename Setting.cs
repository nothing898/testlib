using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace WinFormsApp1
{
    static class Setting
    {
        static public Font Font= new Font("Arial", 14, FontStyle.Regular);
        static public int RegularHeith = 50;
        static public Margins RegularMargin = new Margins(3,3,3,3);
        static public int RegularWidth = 600;
    }
}
