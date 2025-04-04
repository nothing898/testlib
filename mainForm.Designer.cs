namespace WinFormsApp1
{
    partial class mainForm
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
            ToolStrip = new MenuStrip();
            设置ToolStripMenuItem = new ToolStripMenuItem();
            帮助ToolStripMenuItem = new ToolStripMenuItem();
            文件ToolStripMenuItem = new ToolStripMenuItem();
            导出文件ToolStripMenuItem = new ToolStripMenuItem();
            运行ToolStripMenuItem = new ToolStripMenuItem();
            CreateArea = new TableLayoutPanel();
            button10 = new Button();
            button8 = new Button();
            button9 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button11 = new Button();
            DragPanel = new Panel();
            WorkArea = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            删除ToolStripMenuItem = new ToolStripMenuItem();
            ToolStrip.SuspendLayout();
            CreateArea.SuspendLayout();
            WorkArea.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new Size(24, 24);
            ToolStrip.Items.AddRange(new ToolStripItem[] { 设置ToolStripMenuItem, 帮助ToolStripMenuItem, 文件ToolStripMenuItem, 运行ToolStripMenuItem });
            ToolStrip.Location = new Point(0, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(1349, 32);
            ToolStrip.TabIndex = 9;
            ToolStrip.Text = "menuStrip1";
            ToolStrip.ItemClicked += menuStrip1_ItemClicked;
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
            // CreateArea
            // 
            CreateArea.ColumnCount = 1;
            CreateArea.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CreateArea.Controls.Add(button10, 1, 4);
            CreateArea.Controls.Add(button8, 1, 3);
            CreateArea.Controls.Add(button9, 0, 4);
            CreateArea.Controls.Add(button7, 0, 3);
            CreateArea.Controls.Add(button6, 1, 2);
            CreateArea.Controls.Add(button4, 1, 1);
            CreateArea.Controls.Add(button2, 1, 0);
            CreateArea.Controls.Add(button1, 0, 0);
            CreateArea.Controls.Add(button3, 0, 1);
            CreateArea.Controls.Add(button11, 0, 5);
            CreateArea.Dock = DockStyle.Left;
            CreateArea.Location = new Point(0, 0);
            CreateArea.Name = "CreateArea";
            CreateArea.RowCount = 6;
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333333F));
            CreateArea.Size = new Size(467, 708);
            CreateArea.TabIndex = 0;
            CreateArea.Paint += tableLayoutPanel1_Paint;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(0, 560);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.Size = new Size(467, 70);
            button10.TabIndex = 11;
            button10.Text = "中断";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Text_Click;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(0, 420);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(467, 70);
            button8.TabIndex = 9;
            button8.Text = "如果";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Block_Click;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(0, 490);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.Size = new Size(467, 70);
            button9.TabIndex = 10;
            button9.Text = "直到";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Block_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(0, 350);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(467, 70);
            button7.TabIndex = 8;
            button7.Text = "重复";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Block_Click;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(0, 280);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(467, 70);
            button6.TabIndex = 7;
            button6.Text = "令_为_";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Text_Click;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(0, 210);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(467, 70);
            button4.TabIndex = 5;
            button4.Text = "程序入口";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Block_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(0, 70);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(467, 70);
            button2.TabIndex = 4;
            button2.Text = "原地旋转_°";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Text_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(467, 70);
            button1.TabIndex = 3;
            button1.Text = "向前直走_cm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Text_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(0, 140);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(467, 70);
            button3.TabIndex = 2;
            button3.Text = "以左侧_cm为圆心旋转_°";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Text_Click;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(0, 630);
            button11.Margin = new Padding(0);
            button11.Name = "button11";
            button11.Size = new Size(467, 78);
            button11.TabIndex = 12;
            button11.Text = "否则,若";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Block_Click;
            // 
            // DragPanel
            // 
            DragPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DragPanel.BorderStyle = BorderStyle.FixedSingle;
            DragPanel.Location = new Point(470, 0);
            DragPanel.Name = "DragPanel";
            DragPanel.Size = new Size(879, 708);
            DragPanel.TabIndex = 1;
            DragPanel.Paint += panel1_Paint;
            // 
            // WorkArea
            // 
            WorkArea.Controls.Add(CreateArea);
            WorkArea.Controls.Add(DragPanel);
            WorkArea.Dock = DockStyle.Fill;
            WorkArea.Location = new Point(0, 32);
            WorkArea.Name = "WorkArea";
            WorkArea.Size = new Size(1349, 708);
            WorkArea.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 删除ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 34);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(116, 30);
            删除ToolStripMenuItem.Text = "删除";
            删除ToolStripMenuItem.MouseDown += 删除ToolStripMenuItem_MouseDown;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 740);
            Controls.Add(WorkArea);
            Controls.Add(ToolStrip);
            Name = "mainForm";
            Text = "mainForm";
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            CreateArea.ResumeLayout(false);
            WorkArea.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip ToolStrip;
        private ToolStripMenuItem 文件ToolStripMenuItem;
        private ToolStripMenuItem 帮助ToolStripMenuItem;
       public  TableLayoutPanel CreateArea;
       public  Button button10;
       public  Button button9;
       public  Button button8;
       public  Button button7;
       public  Button button6;
       public  Button button4;
       public  Button button2;
       public  Button button1;
       public  Button button3;
       public  Panel DragPanel;
       public  Panel WorkArea;
       public  ToolStripMenuItem 设置ToolStripMenuItem;
       public  ToolStripMenuItem 导出文件ToolStripMenuItem;
       public  ContextMenuStrip contextMenuStrip1;
       public  ToolStripMenuItem 删除ToolStripMenuItem;
       public  ToolStripMenuItem 运行ToolStripMenuItem;
       public  Button button11;
    }
}
