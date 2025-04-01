
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                

                // 创建一个 Label 显示拖放的数据
                Label lbl = new Label();
                lbl.Width = 300;
                lbl.Text = mtb.Text;
                lbl.Height = 50;
                lbl.Font = new Font("Arial", 16, FontStyle.Regular);
                lbl.BorderStyle = BorderStyle.FixedSingle;
                // 将 Label 添加到 Panel 上
                panel.Controls.Add(lbl);
            }
            else if ((ctr = e.Data.GetData(typeof(TitledPanel)) as Control) != null)
            {
                TitledPanel tp = ctr as TitledPanel;
                tp.Width = 400;
                panel.Controls.Add(tp);
                panel.SetRowSpan(tp,4);


            }
        }


        private void instrStack_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = DragDropEffects.Move;


        }





        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Create_Panel(sender, e,btn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Create_Mtb(sender, e,btn.Text);

        }
        private void Create_Mtb(object sender, EventArgs e,string text)
        {
            text = text.Replace('_', '0');
            MaskedTextBox mtb = new myMaskedTextBox();
            Point location = panel4.PointToClient(panel1.PointToScreen(new Point(100, 100)));
            mtb.Location = location;
            mtb.Mask = text;
            mtb.Width = 200;
            Mysub_Drag(mtb);
            mtb.Font = new Font("Arial", 12, FontStyle.Regular);
            panel4.Controls.Add(mtb);
            mtb.BringToFront();



        }
        private void Create_Panel(object sender, EventArgs e, string text)
        {
            
            TitledPanel tp = new TitledPanel();
            Point location = panel4.PointToClient(panel1.PointToScreen(new Point(100, 100)));
            tp.Location = location;

            tp.Title = text;
            tp.AllowDrop = true;
            tp.Size = new System.Drawing.Size(200, 200);
            tp.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tp.Padding = new Padding(0, (int)tp.TitleHeight, 0, 0);
            tp.ColumnCount = 1;
            tp.RowCount = 3;
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
            panel4.Controls.Add(tp);
            tp.BringToFront();

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void instrStack_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
