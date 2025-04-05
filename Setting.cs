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
        static public Font Font = new Font("Nirmala UI", 14, FontStyle.Regular);
        static public int RegularHeith = 50;
        static public Margins RegularMargin = new Margins(3, 3, 3, 3);
        static public int RegularWidth = 600;
        static public Color RegularColor = Color.FromArgb(247, 248, 250);
        static public Color BoxColor = Color.FromArgb(212, 226, 255);
        public class TypeData
        {
            public string Name;
            public bool IsTable;
            public int AtrNum;
            
        }
        static public Dictionary<string, TypeData> InstrToTextMap = new Dictionary<string, TypeData>
        {
            {"if",new TypeData(){Name="如果",IsTable=true,AtrNum=0} },
            {"goline" ,new TypeData(){Name="向前直走",IsTable=false,AtrNum=1} },
            {"turn",new TypeData(){Name="原地旋转",IsTable=false,AtrNum=1} }
        };
    }
}
