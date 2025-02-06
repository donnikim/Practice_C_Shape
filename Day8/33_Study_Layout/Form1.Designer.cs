namespace _33_Study_Layout
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ucPanel1 = new ucPanel();
            ucPanel2 = new ucPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ucPanel3 = new ucPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ucPanel4 = new ucPanel();
            ucPanel5 = new ucPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(ucPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(558, 436);
            splitContainer1.SplitterDistance = 186;
            splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(ucPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.875F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.125F));
            tableLayoutPanel1.Size = new Size(368, 436);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ucPanel1
            // 
            ucPanel1.BackColor = Color.FromArgb(255, 192, 192);
            ucPanel1.Dock = DockStyle.Fill;
            ucPanel1.Location = new Point(0, 0);
            ucPanel1.Name = "ucPanel1";
            ucPanel1.Size = new Size(186, 436);
            ucPanel1.TabIndex = 0;
            // 
            // ucPanel2
            // 
            ucPanel2.BackColor = Color.FromArgb(255, 224, 192);
            ucPanel2.Dock = DockStyle.Fill;
            ucPanel2.Location = new Point(3, 3);
            ucPanel2.Name = "ucPanel2";
            ucPanel2.Size = new Size(362, 89);
            ucPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(ucPanel3, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 98);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(362, 335);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // ucPanel3
            // 
            ucPanel3.BackColor = Color.FromArgb(192, 192, 255);
            ucPanel3.Dock = DockStyle.Fill;
            ucPanel3.Location = new Point(184, 3);
            ucPanel3.Name = "ucPanel3";
            ucPanel3.Size = new Size(175, 329);
            ucPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(ucPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(ucPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(175, 329);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // ucPanel4
            // 
            ucPanel4.BackColor = Color.FromArgb(255, 255, 192);
            ucPanel4.Dock = DockStyle.Fill;
            ucPanel4.Location = new Point(3, 3);
            ucPanel4.Name = "ucPanel4";
            ucPanel4.Size = new Size(169, 158);
            ucPanel4.TabIndex = 0;
            // 
            // ucPanel5
            // 
            ucPanel5.BackColor = Color.FromArgb(192, 255, 192);
            ucPanel5.Dock = DockStyle.Fill;
            ucPanel5.Location = new Point(3, 167);
            ucPanel5.Name = "ucPanel5";
            ucPanel5.Size = new Size(169, 159);
            ucPanel5.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 436);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private ucPanel ucPanel1;
        private ucPanel ucPanel2;
        private TableLayoutPanel tableLayoutPanel2;
        private ucPanel ucPanel3;
        private TableLayoutPanel tableLayoutPanel3;
        private ucPanel ucPanel4;
        private ucPanel ucPanel5;
    }
}
