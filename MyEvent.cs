using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1
    {
        private void Block_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Create_Panel( btn.Text);
        }

        private void Text_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string tag = btn.Name;
            if (btn.Text == "变量文本框") {
                Create_Mtb("",tag);
            }
            else { Create_Mtb( btn.Text,tag); }

        }
        private void Create_Mtb( string text,string tag)
        {

            text = text.Replace('_', '0');
            text = text.Replace("a","\\a");
            MaskedTextBox mtb = new myMaskedTextBox();
            Point location = this.PointToClient(panel1.PointToScreen(new Point(100, 100)));
            mtb.Location = location;
            mtb.Tag = tag;
            mtb.Mask = text;
            mtb.Width = 300;
            mtb.ContextMenuStrip = contextMenuStrip1;
            Mysub_Drag(mtb);
            mtb.Font = new Font("Arial", 12, FontStyle.Regular);
            this.Controls.Add(mtb);
            mtb.BringToFront();
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;



        }
        private void Create_Panel( string text)
        {

            TitledPanel tp = new TitledPanel();
            Point location = this.PointToClient(panel1.PointToScreen(new Point(100, 100)));
            tp.Location = location;
            tp.ContextMenuStrip = contextMenuStrip1;
            tp.Title = text;
            tp.AllowDrop = true;
            tp.Size = new System.Drawing.Size(200, 100);
            tp.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tp.Padding = new Padding(0, (int)tp.TitleHeight, 0, 0);
            tp.ColumnCount = 1;
            tp.RowCount = 1;
            tp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tp.DragEnter += instrStack_DragEnter;
            tp.DragDrop += instrStack_DragDrop;
            Mysub_Drag(tp);
            int x = tp.RowStyles.Count;
            for (int i = 0; i < tp.RowCount; i++)
            {
                tp.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
            }


            tp.Font = new Font("Arial", 12, FontStyle.Regular);
            this.Controls.Add(tp);
            tp.BringToFront();

        }
        public void getDragable(object sender, EventArgs e)
        {
            Dragable = MySet.Myctr_Pos(panel1, this);
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
        private void instrStack_DragDrop(object sender, DragEventArgs e)
        {
            Control ctr;
            TableLayoutPanel panel = sender as TableLayoutPanel;
            if ((ctr = e.Data.GetData(typeof(myMaskedTextBox)) as Control) != null)
            {
                myMaskedTextBox mtb = ctr as myMaskedTextBox;
                if (mtb.MaskCompleted == false)
                {
                    MessageBox.Show("请填写完整");
                    return;
                }


                
                
                mtb.Width = 670;
                mtb.Text = mtb.Text;
                mtb.Height = 50;
                mtb.Font = new Font("Arial", 16, FontStyle.Regular);
                mtb.BorderStyle = BorderStyle.FixedSingle;
                mtb.ContextMenuStrip = contextMenuStrip1;
                // 将 Label 添加到 Panel 上
                panel.Controls.Add(mtb);
                panel.RowCount += 1;
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                panel.Height += 50;
                
                Control parent=panel.Parent as TableLayoutPanel;
                TableLayoutPanel kid = panel;
                while((parent is TitledPanel)||(parent is TableLayoutPanel))
                {
                    TableLayoutPanel par=parent as TableLayoutPanel;
                    par.RowCount += 1;
                    par.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    par.Height += 50;
                    par.SetRowSpan(kid, kid.RowCount+1);
                    kid = par;
                    if (!(parent.Parent is TitledPanel) && !(parent.Parent is TableLayoutPanel)) break;
                    parent=parent.Parent;                    
                }
            }
            else if ((ctr = e.Data.GetData(typeof(TitledPanel)) as Control) != null)
            {
                TitledPanel tp = ctr as TitledPanel;
                tp.Width = 600;
                tp.ContextMenuStrip = contextMenuStrip1;
                tp.Anchor= AnchorStyles.Left;
                panel.Controls.Add(tp);
                panel.RowCount += 2;            
                for (int i = 0; i < 4; i++)
                {
                    panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                }
                panel.Height += 100;
                if(panel is TitledPanel)panel.Width += 5;
                panel.SetRowSpan(tp, 2);
                Control parent = panel.Parent as TableLayoutPanel;
                TableLayoutPanel kid = panel;
                while ((parent is TitledPanel) || (parent is TableLayoutPanel))
                {
                    TableLayoutPanel par = parent as TableLayoutPanel;
                    par.RowCount += 2;
                    for (int i = 0; i < 4; i++)
                    {
                        par.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                    }
                    par.Height += 100;
                    par.SetRowSpan(kid, kid.RowCount + 1);

                    if ((par is TitledPanel)){
                        par.Width += 5;
                    }
                    kid = par;
                    if (!(parent.Parent is TitledPanel) && !(parent.Parent is TableLayoutPanel)) break;
                    parent = parent.Parent;
                }


            }
        }


        private void instrStack_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;


        }


    }
}
