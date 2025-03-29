using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    //自定义按钮
    public class myButton : Button
    {
        public myButton() : base()
        {

        }
        public creBtnData data { set; get; }
    }
    //自定义tablepanel
    public class myTabPan : TableLayoutPanel
    {
        public tableData data { set; get; } = new tableData();
        public myTabPan() : base()
        {
            
        }
    }
    public class myMaskedTextBox : MaskedTextBox
    {
        public ctrData data { set; get; }
        public myMaskedTextBox():base(){
            data=new ctrData();
        }
    }
}
