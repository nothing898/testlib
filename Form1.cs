
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void �ļ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void instrStack_DragDrop(object sender, DragEventArgs e)
        {
            // ���Ϸ������л�ȡ�ַ���
            string droppedData = e.Data.GetData(DataFormats.StringFormat).ToString();

            // �������Ļ����ת��Ϊ Panel �ڵ�����
            Point dropPoint = instrStack.PointToClient(new Point(e.X, e.Y));

            // ����һ�� Label ��ʾ�Ϸŵ�����
            Label lbl = new Label();
            lbl.Text = droppedData; 
            lbl.Font = new Font("Arial", 16, FontStyle.Regular);
            lbl.BorderStyle = BorderStyle.FixedSingle;
            lbl.AutoSize = true;
            var data = instrStack.Tag as tableData;
            // �� Label ��ӵ� Panel ��
            instrStack.Controls.Add(lbl);
        }


        private void instrStack_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat))
            {
                e.Effect = DragDropEffects.Move;
            }

        }



        private void contextMenuStrip8_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            Refresh();
            MaskedTextBox mtb = new myMaskedTextBox();
            Point location = panel4.PointToClient(panel1.PointToScreen(new Point(100,100)));
            mtb.Location = location;
            mtb.Text = "test";
            mtb.AllowDrop = true;
            mtb.MouseDown += new MouseEventHandler(text_MouseDown);
            mtb.MouseMove += new MouseEventHandler(text_MouseMove);
            mtb.MouseUp += new MouseEventHandler(text_MouseUp);
            panel4.Controls.Add(mtb);
            mtb.BringToFront();

            mtb.Font = new Font("Arial", 12, FontStyle.Regular);
            
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void text_MouseDown(object sender,MouseEventArgs e)
        {
            myMaskedTextBox mtb=sender as myMaskedTextBox;
            if (e.Button == MouseButtons.Left)
            {
                mtb.DoDragDrop(mtb.Text.ToString(), DragDropEffects.Move);
            }
        }
        private void text_MouseMove(object sender, MouseEventArgs e)
        {
            myMaskedTextBox mtb = sender as myMaskedTextBox;
            if (mtb.data.isDragging)
            {
                // �����µ�λ�ã�ȷ�����������ؼ������λ��
                Point newLocation = mtb.Location;
                newLocation.X += e.X - mtb.data.location.X;
                newLocation.Y += e.Y - mtb.data.location.Y;
                mtb.Location = newLocation;
            }
        }
        private void text_MouseUp(object sender, MouseEventArgs e)
        {
            myMaskedTextBox mtb = sender as myMaskedTextBox;
            if (e.Button == MouseButtons.Left)
            {
                mtb.data.isDragging = false;
            }
        }
    }
}
