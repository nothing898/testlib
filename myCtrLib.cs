using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public static class myCtrLib
    {
        public static mainForm mainForm;
       public static Rectangle Get_Pos(this Control obj,Control ctr=null)
        {
            // 将控件左上角的点转换为屏幕坐标
            Point screenPoint = obj.PointToScreen(Point.Empty);
            // 再将屏幕坐标转换为窗体客户区坐标
            Point formPoint = ctr==null?mainForm.PointToClient(screenPoint):ctr.PointToClient(screenPoint);
            // 返回以转换后的坐标为左上角，控件的尺寸为大小的矩形
            return new Rectangle(formPoint, obj.Size);
        }
        public static List<Control> Get_Fathers(this Control ctr)
        {
            List<Control> list = new List<Control>();
            while (ctr.Parent is TitledPanel)
            {
                list.Add(ctr.Parent);
                ctr = ctr.Parent;
            }
            return list;
        }
        public static int Get_Index(this Control ctr) {

            return (ctr.Parent as TitledPanel).GetRow(ctr);
        }
    }
}
