
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public TitledPanel enter;

        public List<TitledPanel> tps=new List<TitledPanel>();
        //设定可拖拽区
        public Rectangle Dragable;
        public void GetDragable(object sender, EventArgs e)
        {
            Dragable = DragPanel.Get_Pos();

        }



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void instrStack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void 删除ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                ContextMenuStrip cms = item.Owner as ContextMenuStrip;
                Control clickedControl = cms.SourceControl;
                if ((clickedControl.Parent is TitledPanel))
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
                int x=0;
                if(this.enter!=null)Get_Child(this.enter);




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


                    if(ctrl.Tag!=null)File.AppendAllText("./out.txt", info  + "\n");
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
                            File.AppendAllText("./out.txt","}\n");
                            break;

                    }

                }



            }


        }

        private void titledPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
