using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WinFormsApp1
{
    public interface IMyControl
    {
        ctrData data { set; get; }
    }
    //自定义按钮
    public class myButton : Button, IMyControl
    {
        public myButton() : base()
        {

        }
        private creBtnData _data = new creBtnData();
        public ctrData data
        {
            set { _data = value as creBtnData; }
            get { return _data; }
        }
    }
    //自定义tablepanel
    public class myTabPan : TableLayoutPanel, IMyControl
    {
        private tableData _data = new tableData();
        public ctrData data
        {
            set { _data = value as tableData; }
            get { return _data; }
        }
        public myTabPan() : base()
        {

        }
    }
    public class myLabel : Label, IMyControl {
        public ctrData data { set; get; } = new ctrData();
    }
    public class myTextBox : TextBox, IMyControl
    {
        public ctrData data { set; get; } = new ctrData();
    }
    public class TitledPanel : TableLayoutPanel, IMyControl
    {
        public static int Num = 0;
        public ctrData data { set; get; } = new ctrData();
        public SegmentedInputBox sib;
        public string text;
        public Margins margin = Setting.RegularMargin;
        public int BorderWidth { get; set; } = 1;

        public TitledPanel(TitledPanel tp)
        {
            data = tp.data;
            
        }
        public TitledPanel()
        {
            text = "工作区";
            AllowDrop = true;
            ColumnCount = 1;
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Absolute, Setting.RegularHeith));
            Size = new System.Drawing.Size(Setting.RegularWidth, RowCount * Setting.RegularHeith);
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            sib = new SegmentedInputBox(text);
            this.Add(sib);
            
        }
        public TitledPanel(string title)
        {
            text = title;
            AllowDrop = true;            
            ColumnCount = 1;
            RowCount = 1;
            RowStyles.Add(new RowStyle(SizeType.Absolute, Setting.RegularHeith));
            Size = new System.Drawing.Size(Setting.RegularWidth, RowCount*Setting.RegularHeith);
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            sib = new SegmentedInputBox(text);
            this.Add(sib);
            

        }
        public void Add(Control ctr,int index=0)
        {
            
            List<Control> list = this.Get_Fathers();// 初始化父类
            list.Insert(0, this);
            list.Remove(list.Last());
            int heightAdd;                           //确定高度
            if (ctr is TitledPanel)
            {
                
                sib.Location = new Point(Setting.RegularMargin.Left,Setting.RegularMargin.Top);
                heightAdd= ctr.Height + Setting.RegularMargin.Top + Setting.RegularMargin.Bottom;
                
                                
            }
            else
            {
                sib.Location = new Point(0, 0);
                heightAdd= Setting.RegularHeith;
                              
            }
            Height += heightAdd;                //调整父控件
            Width += Setting.RegularMargin.Right+margin.Left;
            RowCount++;
            foreach (Control ctrl in this.Controls)
            {
                int currentRow = this.GetRow(ctrl);
                if (currentRow >= index)
                {
                    this.SetRow(ctrl, currentRow + 1);
                }
            }
            this.Controls.Add(ctr, 0, index);
            RowStyles.Insert(index,new RowStyle(SizeType.Absolute, heightAdd));

            foreach (Control tp in list)            //调整控件树
            {
                (tp.Parent as TitledPanel).RowStyles[tp.Get_Index()].Height += heightAdd;
                (tp.Parent as TitledPanel).Height += heightAdd;
                (tp.Parent as TitledPanel).Width += Setting.RegularMargin.Right+margin.Left+2;
            }
            
        }
        public void Remove(Control ctr)
        {
            int index= this.GetRow(ctr);
            List<Control> list = this.Get_Fathers();//初始化控件树
            list.Insert(0, this);
            list.Remove(list.Last());
            int heightMin;                                  //确定调整高度    
            if (ctr is TitledPanel)
            {
                heightMin= ctr.Height + Setting.RegularMargin.Top + Setting.RegularMargin.Bottom;                
            }
            else
            {
                heightMin= Setting.RegularHeith;                
            }


            Controls.Remove(ctr);          //调整父控件
            this.BringToFront();
            RowCount--;
            Height -= heightMin;
            Width -= margin.Right + margin.Left;
            RowStyles.RemoveAt(index);
            foreach (Control ctrl in this.Controls)
            {
                int currentRow = this.GetRow(ctrl);
                if (currentRow > index)
                {
                    this.SetRow(ctrl, currentRow - 1);
                }
            }


            foreach (Control tp in list)                //调整空间书
            {
                (tp.Parent as TitledPanel).RowStyles[tp.Get_Index()].Height -= heightMin;
                (tp.Parent as TitledPanel).Height -= heightMin;
                (tp.Parent as TitledPanel).Width -= Setting.RegularMargin.Right+margin.Left+2;
            }




          
        }
        public int Point_Row(Point point)
        {
            int[] rowHeights = this.GetRowHeights();
            int currentY = 0;
            for (int i = 0; i < rowHeights.Length; i++)
            {
                // 如果当前点的 Y 坐标在当前行范围内，则返回行索引 i
                if (point.Y >= currentY && point.Y < currentY + rowHeights[i])
                {
                    return i;
                }
                currentY += rowHeights[i];
            }
            return -1;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen pen = new Pen(Color.Gray, BorderWidth);


            e.Graphics.DrawRectangle(pen, 0, 0, this.ClientSize.Width - BorderWidth, this.ClientSize.Height - BorderWidth);
        }
    }
    public class SegmentedInputBox : UserControl,IMyControl
    {
        public static int Num = 0;
        public ctrData data { set; get; } = new ctrData();
        public myTextBox[] Boxes;
        public myLabel[] Separators;
        public int boxWidth = 100;
        public Font font = Setting.Font;
        public Margins margin = Setting.RegularMargin;


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.Gray, 1))
            {
                Rectangle rect = new Rectangle(0, 0, this.Width-1, this.Height-1);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        public SegmentedInputBox(string text)
        {
            Height = Setting.RegularHeith;

            string[]infos = text.Split("_");
            int n = infos.Length;//Label个数
            int m =text.Count(c => c == '_');//分隔符个数
            Boxes = new myTextBox[m];
            Separators=new myLabel[n];
            int[]locations= new int[m];//文本框的位置
            List<int> sizes = new List<int>();
            foreach (string info in infos)
            {
                Size size = TextRenderer.MeasureText(info, font);
                sizes.Add(size.Width);
            }
            for (int i = 0; i < m; i++)
            {
                locations[i] =((i!=0)?(locations[i-1]+boxWidth+sizes[i]) : sizes[0])+margin.Left;
            }


            for (int i = 0; i < Separators.Length; i++)
            {
                if(i<Boxes.Length)
                {
                    Boxes[i] = new myTextBox()
                    {
                        Font = font,
                        Size = new Size(boxWidth, Setting.RegularHeith - margin.Top - margin.Bottom),
                        Location = new Point(locations[i], margin.Top),
                        TextAlign = HorizontalAlignment.Center

                    };

                    this.Controls.Add(Boxes[i]);
                }

                Separators[i] = new myLabel()
                {
                    Font = font,
                    Text = infos[i],
                    AutoSize = true,
                    TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                    Location = i == 0 ? new Point(margin.Left, margin.Top) : new Point(Boxes[i - 1].Right + margin.Left, margin.Top),
                };
                    
                    this.Controls.Add(Separators[i]);
                
            }
            int maxRight = 0; // 初始化最大右边界

            // 如果 list1 不为空，遍历其中的控件
            if (Boxes.Length != 0)
            {
                foreach (Control ctrl in Boxes)
                {
                    if (ctrl != null)
                        maxRight = Math.Max(maxRight, ctrl.Right);
                }
            }

            // 同理，遍历 list2
            if (Separators.Length!=0)
            {
                foreach (Control ctrl in Separators)
                {
                    if (ctrl != null)
                        maxRight = Math.Max(maxRight, ctrl.Right);
                }
            }
            Width = maxRight + margin.Right;
        }
    }
}
