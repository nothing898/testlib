using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public partial class Form1
    {
        Rectangle Dragable;
        public void FormInit(object sender, EventArgs e)
        {
            Dragable = MySet.Myctr_Pos(panel1,this);
        }
        
        private void Mysub_Drag(System.Windows.Forms.Control myctr)
        {
            myctr.MouseDown += new MouseEventHandler(Myctr_MouseDown);
            myctr.MouseMove += new MouseEventHandler(Myctr_MouseMove);
            myctr.MouseUp += new MouseEventHandler(Myctr_MouseUp);
        }
        private void Myctr_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender != null)
            {
                IMyControl ic = sender as IMyControl;
                if (e.Button == MouseButtons.Left)
                {
                    ic.data.isDragging = true;
                    ic.data.location = e.Location;
                }
            }
        }
        private void Myctr_MouseMove(object sender, MouseEventArgs e)
        {

            if (sender != null)
            {
                IMyControl ic = sender as IMyControl;
                System.Windows.Forms.Control ctr = sender as System.Windows.Forms.Control;
                if (ic.data.isDragging)
                {
                    
                    // 计算希望移动到的新位置（基于当前控件位置和鼠标移动的差值）
                    int desiredX = ctr.Location.X + (e.X - ic.data.location.X);
                    int desiredY = ctr.Location.Y + (e.Y - ic.data.location.Y);

                    // 限制 newX 和 newY 使得控件不会超出 Dragable 的范围
                    // 假设 Dragable 是一个 Rectangle 类型，代表允许控件移动的区域
                    int clampedX = Math.Max(Dragable.Left, Math.Min(desiredX, Dragable.Right - ctr.Width));
                    int clampedY = Math.Max(Dragable.Top, Math.Min(desiredY, Dragable.Bottom - ctr.Height));

                   
                    ctr.Location = new Point(clampedX, clampedY);

                    Point p = new Point(e.X, e.Y);
                    p = MySet.My_Pos(p, ctr, this);
                    if (p.X>=Dragable.Right)
                    {
                        ctr.DoDragDrop(ctr, DragDropEffects.Move);
                        ic.data.isDragging=false;
                    }
                }
            }
        }
        private void Myctr_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender != null)
            {
                IMyControl ic = sender as IMyControl;
                if (e.Button == MouseButtons.Left)
                {
                    ic.data.isDragging = false;
                }
            }
        }
    }
}
