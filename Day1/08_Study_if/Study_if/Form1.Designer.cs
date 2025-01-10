namespace Study_if
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
            nNumber1 = new NumericUpDown();
            nNumber2 = new NumericUpDown();
            btnIfResult = new Button();
            lblIfResult = new Label();
            cboxDay = new ComboBox();
            label3 = new Label();
            lblswitchResult = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nNumber1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nNumber2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Number1)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 19);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Number2)";
            // 
            // nNumber1
            // 
            nNumber1.Location = new Point(12, 48);
            nNumber1.Name = "nNumber1";
            nNumber1.Size = new Size(62, 23);
            nNumber1.TabIndex = 2;
            // 
            // nNumber2
            // 
            nNumber2.Location = new Point(118, 48);
            nNumber2.Name = "nNumber2";
            nNumber2.Size = new Size(62, 23);
            nNumber2.TabIndex = 3;
            // 
            // btnIfResult
            // 
            btnIfResult.Location = new Point(208, 48);
            btnIfResult.Name = "btnIfResult";
            btnIfResult.Size = new Size(125, 23);
            btnIfResult.TabIndex = 4;
            btnIfResult.Text = "Number 비교";
            btnIfResult.UseVisualStyleBackColor = true;
            btnIfResult.Click += btnIfResult_Click;
            // 
            // lblIfResult
            // 
            lblIfResult.AutoSize = true;
            lblIfResult.Location = new Point(12, 90);
            lblIfResult.Name = "lblIfResult";
            lblIfResult.Size = new Size(12, 15);
            lblIfResult.TabIndex = 5;
            lblIfResult.Text = "-";
            // 
            // cboxDay
            // 
            cboxDay.FormattingEnabled = true;
            cboxDay.Items.AddRange(new object[] { "월", "화", "수", "목", "금", "토", "일" });
            cboxDay.Location = new Point(12, 157);
            cboxDay.Name = "cboxDay";
            cboxDay.Size = new Size(81, 23);
            cboxDay.TabIndex = 6;
            cboxDay.Text = "월";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 7;
            label3.Text = "요일선택)";
            // 
            // lblswitchResult
            // 
            lblswitchResult.AutoSize = true;
            lblswitchResult.Location = new Point(12, 205);
            lblswitchResult.Name = "lblswitchResult";
            lblswitchResult.Size = new Size(12, 15);
            lblswitchResult.TabIndex = 8;
            lblswitchResult.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(208, 156);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 9;
            button1.Text = "선택요일확인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 268);
            Controls.Add(button1);
            Controls.Add(lblswitchResult);
            Controls.Add(label3);
            Controls.Add(cboxDay);
            Controls.Add(lblIfResult);
            Controls.Add(btnIfResult);
            Controls.Add(nNumber2);
            Controls.Add(nNumber1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nNumber1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nNumber2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nNumber1;
        private NumericUpDown nNumber2;
        private Button btnIfResult;
        private Label lblIfResult;
        private ComboBox cboxDay;
        private Label label3;
        private Label lblswitchResult;
        private Button button1;
    }
}
