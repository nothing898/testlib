
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        // 用于记录恢复前的窗体大小和位置
        private Rectangle normalBounds;
        private bool isMaximized = false;


        // 用于拖动窗口
        private bool dragging = false;
        private Point dragStartPoint;


        public TitledPanel enter;

        public List<TitledPanel> tps = new List<TitledPanel>();
        //设定可拖拽区
        public Rectangle Dragable;
        public void GetDragable(object sender, EventArgs e)
        {
            Dragable = DragPanel.Get_Pos();

        }

        private void 删除ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                ContextMenuStrip cms = item.Owner as ContextMenuStrip;
                Control clickedControl = cms.SourceControl;//获取右键的对象啊
                if ((clickedControl.Parent is TitledPanel))   //删除控件
                {
                    (clickedControl.Parent as TitledPanel).Remove(clickedControl);
                }
                else
                {
                    clickedControl.Parent.Controls.Remove(clickedControl);
                }
            }
        }

        private void 复制ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                ContextMenuStrip cms = item.Owner as ContextMenuStrip;
                Control clickedControl = cms.SourceControl;
                if (clickedControl is SegmentedInputBox)
                {
                    Create_Sib(clickedControl.Text);
                }
                else if (clickedControl is TitledPanel)
                {
                    Create_Panel((clickedControl as TitledPanel).text);
                }

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 导出文件ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                File.WriteAllText("./out.txt", "");
                int x = 0;
                if (this.enter != null) Get_Child(this.enter);




            }
        }
        private void Get_Child(TitledPanel con)
        {
            foreach (Control ctrl in con.Controls)
            {
                if (ctrl is SegmentedInputBox)
                {
                    SegmentedInputBox sib = ctrl as SegmentedInputBox;
                    string info = "";
                    foreach (var box in sib.Boxes)
                    {
                        info += " " + box.Text;
                    }
                    switch (ctrl.Tag)
                    {
                        case "向前直走_cm":
                            info = "goline " + info;
                            break;
                        case "原地旋转_°":
                            info = "turn " + info;
                            break;
                        case "以左侧_cm为圆心旋转_°":
                            info = "cirle " + info;
                            break;
                        case "中断":
                            info = "break";
                            break;
                        case "重复":
                            info = "for " + info;
                            break;
                        case "令_为_":
                            info = "let " + info;
                            break;
                    }


                    if (ctrl.Tag != null) File.AppendAllText("./out.txt", info + "\n");
                }
                else if (ctrl is TitledPanel)
                {
                    string info = "";
                    TitledPanel tp = ctrl as TitledPanel;
                    switch (tp.sib.Separators[0].Text)
                    {

                        case "如果":
                            info = "if " + tp.sib.Boxes[0].Text + " {\n";
                            File.AppendAllText("./out.txt", info);
                            Get_Child(ctrl as TitledPanel);
                            File.AppendAllText("./out.txt", "}\n");
                            break;
                        case "直到":
                            info = "while " + tp.sib.Boxes[0].Text + " {\n";
                            File.AppendAllText("./out.txt", info);
                            Get_Child(ctrl as TitledPanel);
                            File.AppendAllText("./out.txt", "}\n");
                            break;

                        case "否则,若":
                            File.AppendAllText("./out.txt", "elif(\n");
                            Get_Child(ctrl as TitledPanel);
                            File.AppendAllText("./out.txt", "}\n");
                            break;

                    }

                }



            }


        }


        private void Close_Win(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (!isMaximized)
            {
                normalBounds = this.Bounds; // 保存当前窗口位置和大小
                this.Bounds = Screen.FromControl(this).WorkingArea;
                isMaximized = true;
                btnMaximize.Text = "❐"; // 表示还原
            }
            else
            {
                this.Bounds = normalBounds;
                isMaximized = false;
                btnMaximize.Text = "□";
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // 实现拖动逻辑
        private void TitlePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                // 使用屏幕坐标记录拖动起点
                dragStartPoint = TitlePanel.PointToScreen(e.Location);
            }
        }

        private void TitlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currentScreenPos = TitlePanel.PointToScreen(e.Location);
                int offsetX = currentScreenPos.X - dragStartPoint.X;
                int offsetY = currentScreenPos.Y - dragStartPoint.Y;
                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
                dragStartPoint = currentScreenPos; // 更新起点
            }
        }
        private void CustomForm_Resize(object sender, EventArgs e)
        {
            int btnWidth = btnClose.Width;
            btnClose.Location = new Point(TitlePanel.Width - btnWidth, 0);
            btnMinimize.Location = new Point(TitlePanel.Width - 2 * btnWidth, 0);
            btnMaximize.Location = new Point(TitlePanel.Width - 3 * btnWidth, 0);
        }
        private void TitlePanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
