namespace _11_Study_Struct_Class
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
            label1 = new Label();
            label2 = new Label();
            pboxSun = new PictureBox();
            pboxMoon = new PictureBox();
            pboxStar = new PictureBox();
            pboxNone = new PictureBox();
            rdoPlayer1 = new RadioButton();
            rdoPlayer2 = new RadioButton();
            lboxResult1 = new ListBox();
            lboxResult2 = new ListBox();
            label3 = new Label();
            lboxNow = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pboxSun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxMoon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxStar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxNone).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(279, 15);
            label1.TabIndex = 0;
            label1.Text = "- Player는 한번 씩 돌아가면서 그림을 선택 합니다.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 42);
            label2.Name = "label2";
            label2.Size = new Size(412, 15);
            label2.TabIndex = 1;
            label2.Text = "- 각 5회씩 진행 후 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리 합니다. ";
            // 
            // pboxSun
            // 
            pboxSun.Image = Properties.Resources._1;
            pboxSun.Location = new Point(22, 83);
            pboxSun.Name = "pboxSun";
            pboxSun.Size = new Size(103, 121);
            pboxSun.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxSun.TabIndex = 2;
            pboxSun.TabStop = false;
            pboxSun.Click += pboxSun_Click;
            // 
            // pboxMoon
            // 
            pboxMoon.Image = Properties.Resources._2;
            pboxMoon.Location = new Point(145, 83);
            pboxMoon.Name = "pboxMoon";
            pboxMoon.Size = new Size(103, 121);
            pboxMoon.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxMoon.TabIndex = 3;
            pboxMoon.TabStop = false;
            pboxMoon.Click += pboxMoon_Click;
            // 
            // pboxStar
            // 
            pboxStar.Image = Properties.Resources._3;
            pboxStar.Location = new Point(267, 83);
            pboxStar.Name = "pboxStar";
            pboxStar.Size = new Size(103, 121);
            pboxStar.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxStar.TabIndex = 4;
            pboxStar.TabStop = false;
            pboxStar.Click += pboxStar_Click;
            // 
            // pboxNone
            // 
            pboxNone.BackColor = SystemColors.ControlDark;
            pboxNone.Location = new Point(387, 83);
            pboxNone.Name = "pboxNone";
            pboxNone.Size = new Size(103, 121);
            pboxNone.TabIndex = 5;
            pboxNone.TabStop = false;
            pboxNone.Click += pboxNone_Click;
            // 
            // rdoPlayer1
            // 
            rdoPlayer1.AutoSize = true;
            rdoPlayer1.Location = new Point(22, 231);
            rdoPlayer1.Name = "rdoPlayer1";
            rdoPlayer1.Size = new Size(64, 19);
            rdoPlayer1.TabIndex = 6;
            rdoPlayer1.TabStop = true;
            rdoPlayer1.Text = "Player1";
            rdoPlayer1.UseVisualStyleBackColor = true;
            // 
            // rdoPlayer2
            // 
            rdoPlayer2.AutoSize = true;
            rdoPlayer2.Location = new Point(268, 232);
            rdoPlayer2.Name = "rdoPlayer2";
            rdoPlayer2.Size = new Size(64, 19);
            rdoPlayer2.TabIndex = 7;
            rdoPlayer2.TabStop = true;
            rdoPlayer2.Text = "Player2";
            rdoPlayer2.UseVisualStyleBackColor = true;
            // 
            // lboxResult1
            // 
            lboxResult1.FormattingEnabled = true;
            lboxResult1.ItemHeight = 15;
            lboxResult1.Location = new Point(22, 275);
            lboxResult1.Name = "lboxResult1";
            lboxResult1.Size = new Size(226, 109);
            lboxResult1.TabIndex = 8;
            // 
            // lboxResult2
            // 
            lboxResult2.FormattingEnabled = true;
            lboxResult2.ItemHeight = 15;
            lboxResult2.Location = new Point(268, 275);
            lboxResult2.Name = "lboxResult2";
            lboxResult2.Size = new Size(226, 109);
            lboxResult2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 398);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 10;
            label3.Text = "- 상황판";
            // 
            // lboxNow
            // 
            lboxNow.BackColor = SystemColors.MenuText;
            lboxNow.ForeColor = SystemColors.Window;
            lboxNow.FormattingEnabled = true;
            lboxNow.ItemHeight = 15;
            lboxNow.Location = new Point(22, 421);
            lboxNow.Name = "lboxNow";
            lboxNow.Size = new Size(472, 94);
            lboxNow.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 526);
            Controls.Add(lboxNow);
            Controls.Add(label3);
            Controls.Add(lboxResult2);
            Controls.Add(lboxResult1);
            Controls.Add(rdoPlayer2);
            Controls.Add(rdoPlayer1);
            Controls.Add(pboxNone);
            Controls.Add(pboxStar);
            Controls.Add(pboxMoon);
            Controls.Add(pboxSun);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pboxSun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxMoon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxStar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxNone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pboxSun;
        private PictureBox pboxMoon;
        private PictureBox pboxStar;
        private PictureBox pboxNone;
        private RadioButton rdoPlayer1;
        private RadioButton rdoPlayer2;
        private ListBox lboxResult1;
        private ListBox lboxResult2;
        private Label label3;
        private ListBox lboxNow;
    }
}
