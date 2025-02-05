
namespace _26_Study_Thread
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
            groupBox1 = new GroupBox();
            numPlayerCount = new NumericUpDown();
            label1 = new Label();
            btnStart = new Button();
            lboxResult = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlayerCount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numPlayerCount);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 84);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // numPlayerCount
            // 
            numPlayerCount.Location = new Point(86, 33);
            numPlayerCount.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numPlayerCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPlayerCount.Name = "numPlayerCount";
            numPlayerCount.Size = new Size(49, 23);
            numPlayerCount.TabIndex = 1;
            numPlayerCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Player 수 :";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(230, 102);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(101, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "시작";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lboxResult
            // 
            lboxResult.FormattingEnabled = true;
            lboxResult.ItemHeight = 15;
            lboxResult.Location = new Point(12, 136);
            lboxResult.Name = "lboxResult";
            lboxResult.Size = new Size(319, 154);
            lboxResult.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 302);
            Controls.Add(lboxResult);
            Controls.Add(btnStart);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPlayerCount).EndInit();
            ResumeLayout(false);
            FormClosing += Form1_FormCloing;
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown numPlayerCount;
        private Label label1;
        private Button btnStart;
        private ListBox lboxResult;
    }
}
