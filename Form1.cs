
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //设定可拖拽区
        Rectangle Dragable;
        public void FormInit(object sender, EventArgs e)
        {
            Dragable = MySet.Myctr_Pos(panel1, this);
            this.Resize += new System.EventHandler(getDragable);
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
                clickedControl.Parent.Controls.Remove(clickedControl);
            }
        }

        private void 复制ToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ToolStripMenuItem item = sender as ToolStripMenuItem;
                ContextMenuStrip cms = item.Owner as ContextMenuStrip;
                Control clickedControl = cms.SourceControl;
                if (clickedControl is myMaskedTextBox)
                {
                    Create_Mtb(clickedControl.Text, (string)clickedControl.Tag);
                }
                else if (clickedControl is TitledPanel)
                {
                    Create_Panel((clickedControl as TitledPanel).Title);
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
                Get_Child(instrStack);



            }
        }
        private void Get_Child(TableLayoutPanel con)
        {
            foreach (Control ctrl in con.Controls)
            {
                if (ctrl is myMaskedTextBox)
                {
                    myMaskedTextBox mtb = ctrl as myMaskedTextBox;

                    string info = mtb.Text;
                    switch (ctrl.Tag)
                    {
                        case "button1":
                            info = "goline " + info;
                            break;
                        case "button2":
                            info = "turn " + info;
                            break;
                        case "button3":
                            info = "cirle " + info.Insert(3, " ");
                            break;
                        case "button10":
                            info = "break";
                            break;
                        case "button6":
                            break;
                        case "button4":
                            info = "for " + info;
                            break;

                    }


                    File.AppendAllText("./out.txt", info + "\n");
                }
                else if (ctrl is TitledPanel)
                {
                    string info = "";
                    TitledPanel tp = ctrl as TitledPanel;
                    switch (tp.Title)
                    {
                        case "代码块":
                            File.AppendAllText("./out.txt", "{\n");
                            Get_Child(ctrl as TableLayoutPanel);
                            File.AppendAllText("./out.txt", "}\n");
                            break;
                        case "如果":
                            File.AppendAllText("./out.txt", "if(\n");
                            Get_Child(ctrl as TableLayoutPanel);
                            File.AppendAllText("./out.txt", ")\n");
                            break;
                        case "直到":
                            File.AppendAllText("./out.txt", "while(\n");
                            Get_Child(ctrl as TableLayoutPanel);
                            File.AppendAllText("./out.txt", ")\n");
                            break;
                        case "elif":
                            File.AppendAllText("./out.txt", "elif(\n");
                            Get_Child(ctrl as TableLayoutPanel);
                            File.AppendAllText("./out.txt", ")\n");
                            break;

                    }

                }



            }


        }


    }
}
