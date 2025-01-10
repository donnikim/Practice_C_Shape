namespace Study_Enum
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
            tboxName = new TextBox();
            lboxDay = new ListBox();
            lboxTime = new ListBox();
            btnResult1 = new Button();
            btnResult2 = new Button();
            tboxResult = new TextBox();
            SuspendLayout();
            // 
            // tboxName
            // 
            tboxName.Location = new Point(24, 22);
            tboxName.Name = "tboxName";
            tboxName.Size = new Size(100, 23);
            tboxName.TabIndex = 0;
            // 
            // lboxDay
            // 
            lboxDay.FormattingEnabled = true;
            lboxDay.ItemHeight = 15;
            lboxDay.Location = new Point(24, 66);
            lboxDay.Name = "lboxDay";
            lboxDay.Size = new Size(167, 184);
            lboxDay.TabIndex = 1;
            // 
            // lboxTime
            // 
            lboxTime.FormattingEnabled = true;
            lboxTime.ItemHeight = 15;
            lboxTime.Location = new Point(197, 66);
            lboxTime.Name = "lboxTime";
            lboxTime.Size = new Size(167, 184);
            lboxTime.TabIndex = 2;
            // 
            // btnResult1
            // 
            btnResult1.Location = new Point(24, 256);
            btnResult1.Name = "btnResult1";
            btnResult1.Size = new Size(75, 23);
            btnResult1.TabIndex = 3;
            btnResult1.Text = "결과보기";
            btnResult1.UseVisualStyleBackColor = true;
            btnResult1.Click += btnResult1_Click_1;
            // 
            // btnResult2
            // 
            btnResult2.Location = new Point(116, 256);
            btnResult2.Name = "btnResult2";
            btnResult2.Size = new Size(150, 23);
            btnResult2.TabIndex = 4;
            btnResult2.Text = "StringFormat";
            btnResult2.UseVisualStyleBackColor = true;
            btnResult2.Click += btnResult2_Click;
            // 
            // tboxResult
            // 
            tboxResult.Enabled = false;
            tboxResult.Location = new Point(24, 300);
            tboxResult.Multiline = true;
            tboxResult.Name = "tboxResult";
            tboxResult.Size = new Size(340, 71);
            tboxResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 383);
            Controls.Add(tboxResult);
            Controls.Add(btnResult2);
            Controls.Add(btnResult1);
            Controls.Add(lboxTime);
            Controls.Add(lboxDay);
            Controls.Add(tboxName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxName;
        private ListBox lboxDay;
        private ListBox lboxTime;
        private Button btnResult1;
        private Button btnResult2;
        private TextBox tboxResult;
    }
}
