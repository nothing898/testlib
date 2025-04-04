using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using WinFormsApp1;
namespace WinFormsApp1
{
 
    static class MySet
    {
        static public mainForm form;

        static public Point My_Pos(Point p,Control ctrl,Form window)
        {
            
            Point screenPoint = ctrl.PointToScreen(p);
            
            Point formPoint = window.PointToClient(screenPoint);
            
            return formPoint;
        }
        static public Rectangle Myctr_Pos(Control ctrl, Form window)
        {
            // 将控件左上角的点转换为屏幕坐标
            Point screenPoint = ctrl.PointToScreen(Point.Empty);
            // 再将屏幕坐标转换为窗体客户区坐标
            Point formPoint = window.PointToClient(screenPoint);
            // 返回以转换后的坐标为左上角，控件的尺寸为大小的矩形
            return new Rectangle(formPoint, ctrl.Size);
        }



        static public List<Control> Get_Childs(Control ctr)
        {
            List<Control>list=new List<Control>();
            foreach (Control c in ctr.Controls)
            {
                    list.Add(c);
            }
            return list;
        }

    }
    
}
