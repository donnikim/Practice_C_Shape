namespace Study_DataType
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
            tboxNumber = new TextBox();
            btnExe = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblShort = new Label();
            lblInt = new Label();
            lblDouble = new Label();
            lblException = new Label();
            btnShort = new Button();
            btnInt = new Button();
            btnDouble = new Button();
            SuspendLayout();
            // 
            // tboxNumber
            // 
            tboxNumber.Location = new Point(13, 36);
            tboxNumber.Margin = new Padding(4, 3, 4, 3);
            tboxNumber.Name = "tboxNumber";
            tboxNumber.Size = new Size(645, 23);
            tboxNumber.TabIndex = 0;
            // 
            // btnExe
            // 
            btnExe.Location = new Point(666, 37);
            btnExe.Margin = new Padding(4, 3, 4, 3);
            btnExe.Name = "btnExe";
            btnExe.Size = new Size(99, 22);
            btnExe.TabIndex = 1;
            btnExe.Text = "알아서 변환";
            btnExe.UseVisualStyleBackColor = true;
            btnExe.Click += btnExe_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 111);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Short";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 159);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Int";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 206);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 4;
            label3.Text = "Double";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 5;
            label4.Text = "Exception";
            // 
            // lblShort
            // 
            lblShort.AutoSize = true;
            lblShort.Location = new Point(168, 111);
            lblShort.Name = "lblShort";
            lblShort.Size = new Size(14, 15);
            lblShort.TabIndex = 6;
            lblShort.Text = "0";
            // 
            // lblInt
            // 
            lblInt.AutoSize = true;
            lblInt.Location = new Point(168, 159);
            lblInt.Name = "lblInt";
            lblInt.Size = new Size(14, 15);
            lblInt.TabIndex = 7;
            lblInt.Text = "0";
            // 
            // lblDouble
            // 
            lblDouble.AutoSize = true;
            lblDouble.Location = new Point(168, 206);
            lblDouble.Name = "lblDouble";
            lblDouble.Size = new Size(14, 15);
            lblDouble.TabIndex = 8;
            lblDouble.Text = "0";
            // 
            // lblException
            // 
            lblException.AutoSize = true;
            lblException.Location = new Point(168, 256);
            lblException.Name = "lblException";
            lblException.Size = new Size(14, 15);
            lblException.TabIndex = 9;
            lblException.Text = "-";
            // 
            // btnShort
            // 
            btnShort.Location = new Point(278, 111);
            btnShort.Margin = new Padding(4, 3, 4, 3);
            btnShort.Name = "btnShort";
            btnShort.Size = new Size(131, 22);
            btnShort.TabIndex = 10;
            btnShort.Text = "Short 변환";
            btnShort.UseVisualStyleBackColor = true;
            btnShort.Click += btnShort_Click;
            // 
            // btnInt
            // 
            btnInt.Location = new Point(278, 155);
            btnInt.Margin = new Padding(4, 3, 4, 3);
            btnInt.Name = "btnInt";
            btnInt.Size = new Size(131, 22);
            btnInt.TabIndex = 11;
            btnInt.Text = "Int 변환";
            btnInt.UseVisualStyleBackColor = true;
            btnInt.Click += btnInt_Click;
            // 
            // btnDouble
            // 
            btnDouble.Location = new Point(278, 202);
            btnDouble.Margin = new Padding(4, 3, 4, 3);
            btnDouble.Name = "btnDouble";
            btnDouble.Size = new Size(131, 22);
            btnDouble.TabIndex = 12;
            btnDouble.Text = "Double 변환";
            btnDouble.UseVisualStyleBackColor = true;
            btnDouble.Click += btnDouble_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 347);
            Controls.Add(btnDouble);
            Controls.Add(btnInt);
            Controls.Add(btnShort);
            Controls.Add(lblException);
            Controls.Add(lblDouble);
            Controls.Add(lblInt);
            Controls.Add(lblShort);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExe);
            Controls.Add(tboxNumber);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxNumber;
        private Button btnExe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblShort;
        private Label lblInt;
        private Label lblDouble;
        private Label lblException;
        private Button btnShort;
        private Button btnInt;
        private Button btnDouble;
    }
}
