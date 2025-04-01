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
            menuStrip1 = new MenuStrip();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            导出文件ToolStripMenuItem = new ToolStripMenuItem();
            设置ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 设置ToolStripMenuItem, 帮助ToolStripMenuItem, 文件ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1349, 32);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 导出文件ToolStripMenuItem });
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new Size(62, 28);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 帮助ToolStripMenuItem
            // 
            帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            帮助ToolStripMenuItem.Size = new Size(62, 28);
            帮助ToolStripMenuItem.Text = "帮助";
            // 
            // instrStack
            // 
            instrStack.AllowDrop = true;
            instrStack.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            instrStack.AutoScroll = true;
            instrStack.BackColor = SystemColors.Control;
            instrStack.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            instrStack.ColumnCount = 1;
            instrStack.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            instrStack.ForeColor = SystemColors.ControlText;
            instrStack.Location = new Point(543, 0);
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
            instrStack.Size = new Size(806, 800);
            instrStack.TabIndex = 1;
            instrStack.DragDrop += instrStack_DragDrop;
            instrStack.DragEnter += instrStack_DragEnter;
            instrStack.Paint += instrStack_Paint;
            // 
            // tableLayoutPanel1
            // 
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(546, 250);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(273, 200);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Size = new Size(273, 50);
            button10.TabIndex = 11;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(273, 150);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(273, 50);
            button8.TabIndex = 9;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(0, 200);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(273, 50);
            button9.TabIndex = 10;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(0, 150);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(273, 50);
            button7.TabIndex = 8;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(273, 100);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(273, 50);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(0, 100);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(273, 50);
            button5.TabIndex = 6;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(273, 50);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(273, 50);
            button4.TabIndex = 5;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(273, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(273, 50);
            button2.TabIndex = 4;
            button2.Text = "原地旋转__°";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(273, 50);
            button1.TabIndex = 3;
            button1.Text = "向前直走__cm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(0, 50);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(273, 50);
            button3.TabIndex = 2;
            button3.Text = "以左侧_cm为圆心旋转_°";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 250);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 458);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Controls.Add(panel1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(546, 708);
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
            // 导出文件ToolStripMenuItem
            // 
            导出文件ToolStripMenuItem.Name = "导出文件ToolStripMenuItem";
            导出文件ToolStripMenuItem.Size = new Size(270, 34);
            导出文件ToolStripMenuItem.Text = "导出文件";
            // 
            // 设置ToolStripMenuItem
            // 
            设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            设置ToolStripMenuItem.Size = new Size(62, 28);
            设置ToolStripMenuItem.Text = "设置";
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
    }
}
