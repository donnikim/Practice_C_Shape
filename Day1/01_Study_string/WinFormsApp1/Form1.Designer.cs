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
            lblText = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            lblContain = new Label();
            lblEquals = new Label();
            lblLength = new Label();
            lblReplace = new Label();
            lblSplit1 = new Label();
            lblSubstring = new Label();
            lblToLower = new Label();
            lblToUpper = new Label();
            lblTrim = new Label();
            lblSplit2 = new Label();
            lblSplit3 = new Label();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(59, 52);
            lblText.Name = "lblText";
            lblText.Size = new Size(104, 15);
            lblText.TabIndex = 0;
            lblText.Text = "Sample, Test, Text";
            // 
            // button1
            // 
            button1.Location = new Point(225, 48);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "실행";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 90);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 2;
            label2.Text = "Contain";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 129);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 3;
            label3.Text = "Equals";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 164);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Length";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 199);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 5;
            label5.Text = "Replace";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 233);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 6;
            label6.Text = "Split";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(251, 90);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 7;
            label7.Text = "Substring";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(251, 129);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 8;
            label8.Text = "ToLower";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(251, 164);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 9;
            label9.Text = "ToUpper";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(251, 199);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 10;
            label10.Text = "Trim";
            // 
            // lblContain
            // 
            lblContain.AutoSize = true;
            lblContain.Location = new Point(130, 90);
            lblContain.Name = "lblContain";
            lblContain.Size = new Size(12, 15);
            lblContain.TabIndex = 11;
            lblContain.Text = "-";
            // 
            // lblEquals
            // 
            lblEquals.AutoSize = true;
            lblEquals.Location = new Point(130, 129);
            lblEquals.Name = "lblEquals";
            lblEquals.Size = new Size(12, 15);
            lblEquals.TabIndex = 12;
            lblEquals.Text = "-";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(130, 164);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(12, 15);
            lblLength.TabIndex = 13;
            lblLength.Text = "-";
            // 
            // lblReplace
            // 
            lblReplace.AutoSize = true;
            lblReplace.Location = new Point(130, 199);
            lblReplace.Name = "lblReplace";
            lblReplace.Size = new Size(12, 15);
            lblReplace.TabIndex = 14;
            lblReplace.Text = "-";
            // 
            // lblSplit1
            // 
            lblSplit1.AutoSize = true;
            lblSplit1.Location = new Point(130, 233);
            lblSplit1.Name = "lblSplit1";
            lblSplit1.Size = new Size(12, 15);
            lblSplit1.TabIndex = 15;
            lblSplit1.Text = "-";
            // 
            // lblSubstring
            // 
            lblSubstring.AutoSize = true;
            lblSubstring.Location = new Point(336, 90);
            lblSubstring.Name = "lblSubstring";
            lblSubstring.Size = new Size(12, 15);
            lblSubstring.TabIndex = 16;
            lblSubstring.Text = "-";
            // 
            // lblToLower
            // 
            lblToLower.AutoSize = true;
            lblToLower.Location = new Point(336, 129);
            lblToLower.Name = "lblToLower";
            lblToLower.Size = new Size(12, 15);
            lblToLower.TabIndex = 17;
            lblToLower.Text = "-";
            // 
            // lblToUpper
            // 
            lblToUpper.AutoSize = true;
            lblToUpper.Location = new Point(336, 164);
            lblToUpper.Name = "lblToUpper";
            lblToUpper.Size = new Size(12, 15);
            lblToUpper.TabIndex = 18;
            lblToUpper.Text = "-";
            // 
            // lblTrim
            // 
            lblTrim.AutoSize = true;
            lblTrim.Location = new Point(336, 199);
            lblTrim.Name = "lblTrim";
            lblTrim.Size = new Size(12, 15);
            lblTrim.TabIndex = 19;
            lblTrim.Text = "-";
            // 
            // lblSplit2
            // 
            lblSplit2.AutoSize = true;
            lblSplit2.Location = new Point(130, 267);
            lblSplit2.Name = "lblSplit2";
            lblSplit2.Size = new Size(12, 15);
            lblSplit2.TabIndex = 20;
            lblSplit2.Text = "-";
            // 
            // lblSplit3
            // 
            lblSplit3.AutoSize = true;
            lblSplit3.Location = new Point(130, 300);
            lblSplit3.Name = "lblSplit3";
            lblSplit3.Size = new Size(12, 15);
            lblSplit3.TabIndex = 21;
            lblSplit3.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 350);
            Controls.Add(lblSplit3);
            Controls.Add(lblSplit2);
            Controls.Add(lblTrim);
            Controls.Add(lblToUpper);
            Controls.Add(lblToLower);
            Controls.Add(lblSubstring);
            Controls.Add(lblSplit1);
            Controls.Add(lblReplace);
            Controls.Add(lblLength);
            Controls.Add(lblEquals);
            Controls.Add(lblContain);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(lblText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lblContain;
        private Label lblEquals;
        private Label lblLength;
        private Label lblReplace;
        private Label lblSplit1;
        private Label lblSubstring;
        private Label lblToLower;
        private Label lblToUpper;
        private Label lblTrim;
        private Label lblSplit2;
        private Label lblSplit3;
    }
}
