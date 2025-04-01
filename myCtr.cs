using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ctrData data { 
            set { _data = value as creBtnData; }
            get { return _data; }
        }
    }
    //自定义tablepanel
    public class myTabPan : TableLayoutPanel, IMyControl
    {
        private tableData _data=new tableData();
        public ctrData data 
        {
            set { _data = value as tableData; }
            get { return _data; }
        }
        public myTabPan() : base()
        {
            
        }
    }
    public class myMaskedTextBox : MaskedTextBox, IMyControl
    {
        public ctrData data { set; get; } = new ctrData();
        public myMaskedTextBox():base(){
            data=new ctrData();
        }
    }
    public class TitledPanel : TableLayoutPanel,IMyControl
    {
        public ctrData data { set; get; }=new ctrData();
        public string Title { get; set; } = "默认标题";
        public Color TitleColor { get; set; } = Color.Black;
        public Font TitleFont { get; set; } = new Font("Arial", 12, FontStyle.Regular);

        public int BorderWidth { get; set; }=1;

        public int TitleHeight { get; set; } = 50;


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen pen=new  Pen(Color.Gray, BorderWidth);

            // 绘制标题文本
            if (!string.IsNullOrEmpty(Title))
            {
                SizeF textSize = e.Graphics.MeasureString(Title, TitleFont);
                // 可根据需要调整位置
                PointF textLocation = new PointF(0, 5);
                e.Graphics.DrawString(Title, TitleFont, new SolidBrush(TitleColor), textLocation);

                
                e.Graphics.DrawLine(pen, new PointF(0, TitleHeight), new PointF(this.Width, TitleHeight));

                


            }
                e.Graphics.DrawRectangle(pen, 0, 0, this.ClientSize.Width - BorderWidth, this.ClientSize.Height - BorderWidth);
                
        }
    }

}
