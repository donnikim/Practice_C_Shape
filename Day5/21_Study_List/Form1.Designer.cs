namespace _21_Study_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pbox1 = new PictureBox();
            pbox2 = new PictureBox();
            pbox3 = new PictureBox();
            pbox4 = new PictureBox();
            lblPick1 = new Label();
            lblPick2 = new Label();
            lblPick3 = new Label();
            lblPick4 = new Label();
            label6 = new Label();
            lblTotalCount = new Label();
            label7 = new Label();
            dgViewList = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgViewList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 0;
            label1.Text = "※ 선호하는 항목을 선택해 주세요";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lblPick4, 3, 1);
            tableLayoutPanel1.Controls.Add(lblPick3, 2, 1);
            tableLayoutPanel1.Controls.Add(lblPick2, 1, 1);
            tableLayoutPanel1.Controls.Add(pbox4, 3, 0);
            tableLayoutPanel1.Controls.Add(pbox3, 2, 0);
            tableLayoutPanel1.Controls.Add(pbox2, 1, 0);
            tableLayoutPanel1.Controls.Add(pbox1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblPick1, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 51);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(451, 164);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pbox1
            // 
            pbox1.Dock = DockStyle.Fill;
            pbox1.Image = (Image)resources.GetObject("pbox1.Image");
            pbox1.Location = new Point(3, 3);
            pbox1.Name = "pbox1";
            pbox1.Size = new Size(106, 125);
            pbox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox1.TabIndex = 0;
            pbox1.TabStop = false;
            pbox1.Click += pbox_Click;
            // 
            // pbox2
            // 
            pbox2.Dock = DockStyle.Fill;
            pbox2.Image = (Image)resources.GetObject("pbox2.Image");
            pbox2.Location = new Point(115, 3);
            pbox2.Name = "pbox2";
            pbox2.Size = new Size(106, 125);
            pbox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox2.TabIndex = 1;
            pbox2.TabStop = false;
            pbox2.Click += pbox_Click;
            // 
            // pbox3
            // 
            pbox3.Dock = DockStyle.Fill;
            pbox3.Image = (Image)resources.GetObject("pbox3.Image");
            pbox3.Location = new Point(227, 3);
            pbox3.Name = "pbox3";
            pbox3.Size = new Size(106, 125);
            pbox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox3.TabIndex = 2;
            pbox3.TabStop = false;
            pbox3.Click += pbox_Click;
            // 
            // pbox4
            // 
            pbox4.Dock = DockStyle.Fill;
            pbox4.Image = (Image)resources.GetObject("pbox4.Image");
            pbox4.Location = new Point(339, 3);
            pbox4.Name = "pbox4";
            pbox4.Size = new Size(109, 125);
            pbox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbox4.TabIndex = 3;
            pbox4.TabStop = false;
            pbox4.Click += pbox_Click;
            // 
            // lblPick1
            // 
            lblPick1.AutoSize = true;
            lblPick1.BackColor = SystemColors.ButtonHighlight;
            lblPick1.Dock = DockStyle.Fill;
            lblPick1.Location = new Point(3, 131);
            lblPick1.Name = "lblPick1";
            lblPick1.Size = new Size(106, 33);
            lblPick1.TabIndex = 4;
            lblPick1.Text = "0";
            lblPick1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPick2
            // 
            lblPick2.AutoSize = true;
            lblPick2.BackColor = SystemColors.ButtonHighlight;
            lblPick2.Dock = DockStyle.Fill;
            lblPick2.Location = new Point(115, 131);
            lblPick2.Name = "lblPick2";
            lblPick2.Size = new Size(106, 33);
            lblPick2.TabIndex = 5;
            lblPick2.Text = "0";
            lblPick2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPick3
            // 
            lblPick3.AutoSize = true;
            lblPick3.BackColor = SystemColors.ButtonHighlight;
            lblPick3.Dock = DockStyle.Fill;
            lblPick3.Location = new Point(227, 131);
            lblPick3.Name = "lblPick3";
            lblPick3.Size = new Size(106, 33);
            lblPick3.TabIndex = 6;
            lblPick3.Text = "0";
            lblPick3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPick4
            // 
            lblPick4.AutoSize = true;
            lblPick4.BackColor = SystemColors.ButtonHighlight;
            lblPick4.Dock = DockStyle.Fill;
            lblPick4.Location = new Point(339, 131);
            lblPick4.Name = "lblPick4";
            lblPick4.Size = new Size(109, 33);
            lblPick4.TabIndex = 7;
            lblPick4.Text = "0";
            lblPick4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 234);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 2;
            label6.Text = "Total Count : ";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.ImageAlign = ContentAlignment.TopLeft;
            lblTotalCount.Location = new Point(102, 234);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(14, 15);
            lblTotalCount.TabIndex = 3;
            lblTotalCount.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 266);
            label7.Name = "label7";
            label7.Size = new Size(199, 15);
            label7.TabIndex = 4;
            label7.Text = "※ List의 Data를 화면에 보여줍니다.";
            // 
            // dgViewList
            // 
            dgViewList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewList.Location = new Point(102, 297);
            dgViewList.Name = "dgViewList";
            dgViewList.Size = new Size(278, 266);
            dgViewList.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 584);
            Controls.Add(dgViewList);
            Controls.Add(label7);
            Controls.Add(lblTotalCount);
            Controls.Add(label6);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgViewList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pbox4;
        private PictureBox pbox3;
        private PictureBox pbox2;
        private PictureBox pbox1;
        private Label lblPick4;
        private Label lblPick3;
        private Label lblPick2;
        private Label lblPick1;
        private Label label6;
        private Label lblTotalCount;
        private Label label7;
        private DataGridView dgViewList;
    }
}
