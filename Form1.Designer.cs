namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            设置ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            导出文件ToolStripMenuItem = new ToolStripMenuItem();
            运行ToolStripMenuItem = new ToolStripMenuItem();
            instrStack = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button10 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button11 = new Button();
            button12 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            删除ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 设置ToolStripMenuItem, 帮助ToolStripMenuItem, 文件ToolStripMenuItem, 运行ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1349, 32);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // 设置ToolStripMenuItem
            // 
            设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            设置ToolStripMenuItem.Size = new Size(62, 28);
            设置ToolStripMenuItem.Text = "设置";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(62, 28);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 导出文件ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(62, 28);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 导出文件ToolStripMenuItem
            // 
            导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            导出文件ToolStripMenuItem.Size = new Size(182, 34);
            导出文件ToolStripMenuItem.Text = "导出文件";
            导出文件ToolStripMenuItem.MouseDown += 导出文件ToolStripMenuItem_MouseDown;
            // 
            // 运行ToolStripMenuItem
            // 
            运行ToolStripMenuItem.Name = "运行ToolStripMenuItem";
            运行ToolStripMenuItem.Size = new Size(62, 28);
            运行ToolStripMenuItem.Text = "运行";
            // 
            // instrStack
            // 
            instrStack.AllowDrop = true;
            instrStack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            instrStack.AutoScroll = true;
            instrStack.BackColor = SystemColors.Control;
            instrStack.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            instrStack.ColumnCount = 1;
            instrStack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            instrStack.ForeColor = SystemColors.ControlText;
            instrStack.Location = new Point(594, 0);
            instrStack.Margin = new Padding(10, 0, 0, 0);
            instrStack.MinimumSize = new Size(500, 500);
            instrStack.Name = "instrStack";
            instrStack.RowCount = 20;
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            instrStack.Size = new Size(755, 708);
            instrStack.TabIndex = 1;
            instrStack.DragDrop += instrStack_DragDrop;
            instrStack.DragEnter += instrStack_DragEnter;
            instrStack.Paint += instrStack_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button10, 1, 4);
            tableLayoutPanel1.Controls.Add(button8, 1, 3);
            tableLayoutPanel1.Controls.Add(button9, 0, 4);
            tableLayoutPanel1.Controls.Add(button7, 0, 3);
            tableLayoutPanel1.Controls.Add(button6, 1, 2);
            tableLayoutPanel1.Controls.Add(button5, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button3, 0, 1);
            tableLayoutPanel1.Controls.Add(button11, 0, 5);
            tableLayoutPanel1.Controls.Add(button12, 1, 5);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(595, 228);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(297, 152);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Size = new Size(298, 38);
            button10.TabIndex = 11;
            button10.Text = "break";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Text_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(297, 114);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(298, 38);
            button8.TabIndex = 9;
            button8.Text = "如果";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Block_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(0, 152);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(297, 38);
            button9.TabIndex = 10;
            button9.Text = "直到";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Block_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(0, 114);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(297, 38);
            button7.TabIndex = 8;
            button7.Text = "重复";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Block_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(297, 76);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(298, 38);
            button6.TabIndex = 7;
            button6.Text = "变量文本框";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Text_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(0, 76);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(297, 38);
            button5.TabIndex = 6;
            button5.Text = "代码块";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Block_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(297, 38);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(298, 38);
            button4.TabIndex = 5;
            button4.Text = "重复___次";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Text_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(297, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(298, 38);
            button2.TabIndex = 4;
            button2.Text = "原地旋转___°";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Text_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(297, 38);
            button1.TabIndex = 3;
            button1.Text = "向前直走___cm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Text_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(0, 38);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(297, 38);
            button3.TabIndex = 2;
            button3.Text = "以左侧___cm为圆心旋转___°";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Text_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(0, 190);
            button11.Margin = new Padding(0);
            button11.Name = "button11";
            button11.Size = new Size(297, 38);
            button11.TabIndex = 12;
            button11.Text = "elif";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Block_Click;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(297, 190);
            button12.Margin = new Padding(0);
            button12.Name = "button12";
            button12.Size = new Size(298, 38);
            button12.TabIndex = 13;
            button12.Text = "else";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Text_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 225);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 483);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 708);
            panel2.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(instrStack);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(1349, 708);
            panel4.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 删除ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(241, 67);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(240, 30);
            删除ToolStripMenuItem.Text = "删除";
            删除ToolStripMenuItem.MouseDown += 删除ToolStripMenuItem_MouseDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 740);
            Controls.Add(panel4);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
        public TableLayoutPanel instrStack;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private ToolStripMenuItem 设置ToolStripMenuItem;
        private ToolStripMenuItem 导出文件ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private ToolStripMenuItem 运行ToolStripMenuItem;
        private Button button11;
        private Button button12;
    }
}
