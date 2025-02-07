namespace _34_Study_Layout_Event
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
            splitContainer1 = new SplitContainer();
            ucColorMenu1 = new ucColorMenu();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ucPanelCenter1 = new ucPanel();
            ucPanelCenter2 = new ucPanel();
            ucPanelRight = new ucPanel();
            ucPanelTop = new ucPanel();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ucColorMenu1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 130;
            splitContainer1.TabIndex = 0;
            // 
            // ucColorMenu1
            // 
            ucColorMenu1.Dock = DockStyle.Fill;
            ucColorMenu1.Location = new Point(0, 0);
            ucColorMenu1.Name = "ucColorMenu1";
            ucColorMenu1.Size = new Size(130, 450);
            ucColorMenu1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(ucPanelTop, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(666, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ucPanelCenter1, 0, 0);
            tableLayoutPanel2.Controls.Add(ucPanelCenter2, 0, 1);
            tableLayoutPanel2.Controls.Add(ucPanelRight, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 112);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(666, 225);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ucPanelCenter1
            // 
            ucPanelCenter1.Dock = DockStyle.Fill;
            ucPanelCenter1.Location = new Point(3, 3);
            ucPanelCenter1.Name = "ucPanelCenter1";
            ucPanelCenter1.Size = new Size(327, 106);
            ucPanelCenter1.TabIndex = 0;
            // 
            // ucPanelCenter2
            // 
            ucPanelCenter2.Dock = DockStyle.Fill;
            ucPanelCenter2.Location = new Point(3, 115);
            ucPanelCenter2.Name = "ucPanelCenter2";
            ucPanelCenter2.Size = new Size(327, 107);
            ucPanelCenter2.TabIndex = 1;
            // 
            // ucPanelRight
            // 
            ucPanelRight.Dock = DockStyle.Fill;
            ucPanelRight.Location = new Point(336, 3);
            ucPanelRight.Name = "ucPanelRight";
            tableLayoutPanel2.SetRowSpan(ucPanelRight, 2);
            ucPanelRight.Size = new Size(327, 219);
            ucPanelRight.TabIndex = 2;
            // 
            // ucPanelTop
            // 
            ucPanelTop.Dock = DockStyle.Fill;
            ucPanelTop.Location = new Point(3, 3);
            ucPanelTop.Name = "ucPanelTop";
            ucPanelTop.Size = new Size(660, 106);
            ucPanelTop.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 337);
            listBox1.Margin = new Padding(0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(666, 113);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ucPanel ucPanelCenter1;
        private ucPanel ucPanelCenter2;
        private ucPanel ucPanelRight;
        private ucPanel ucPanelTop;
        private ListBox listBox1;
        private ucColorMenu ucColorMenu1;
    }
}
