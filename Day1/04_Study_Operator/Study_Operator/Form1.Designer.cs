namespace Study_Operator
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
            tboxResult = new TextBox();
            tboxResultAfter = new TextBox();
            tboxResultBit = new TextBox();
            tboxNumber = new TextBox();
            tboxAndOr = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // tboxResult
            // 
            tboxResult.Location = new Point(21, 25);
            tboxResult.Name = "tboxResult";
            tboxResult.Size = new Size(103, 23);
            tboxResult.TabIndex = 0;
            tboxResult.Text = "0";
            tboxResult.TextAlign = HorizontalAlignment.Right;
            tboxResult.TextChanged += tboxResult_TextChanged;
            // 
            // tboxResultAfter
            // 
            tboxResultAfter.Location = new Point(154, 25);
            tboxResultAfter.Name = "tboxResultAfter";
            tboxResultAfter.Size = new Size(103, 23);
            tboxResultAfter.TabIndex = 1;
            tboxResultAfter.Text = "0";
            tboxResultAfter.TextAlign = HorizontalAlignment.Right;
            // 
            // tboxResultBit
            // 
            tboxResultBit.Enabled = false;
            tboxResultBit.Location = new Point(21, 54);
            tboxResultBit.Name = "tboxResultBit";
            tboxResultBit.Size = new Size(103, 23);
            tboxResultBit.TabIndex = 2;
            tboxResultBit.Text = "0";
            tboxResultBit.TextAlign = HorizontalAlignment.Right;
            // 
            // tboxNumber
            // 
            tboxNumber.Location = new Point(21, 97);
            tboxNumber.Name = "tboxNumber";
            tboxNumber.Size = new Size(103, 23);
            tboxNumber.TabIndex = 3;
            tboxNumber.Text = "0";
            tboxNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // tboxAndOr
            // 
            tboxAndOr.Enabled = false;
            tboxAndOr.Location = new Point(154, 97);
            tboxAndOr.Name = "tboxAndOr";
            tboxAndOr.Size = new Size(103, 23);
            tboxAndOr.TabIndex = 4;
            tboxAndOr.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(21, 126);
            button1.Name = "button1";
            button1.Size = new Size(46, 43);
            button1.TabIndex = 5;
            button1.Text = "<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(88, 126);
            button2.Name = "button2";
            button2.Size = new Size(46, 43);
            button2.TabIndex = 6;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 126);
            button3.Name = "button3";
            button3.Size = new Size(46, 43);
            button3.TabIndex = 7;
            button3.Text = "+=";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(211, 126);
            button4.Name = "button4";
            button4.Size = new Size(46, 43);
            button4.TabIndex = 8;
            button4.Text = "-=";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(21, 177);
            button5.Name = "button5";
            button5.Size = new Size(46, 43);
            button5.TabIndex = 9;
            button5.Text = "++a";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(88, 177);
            button6.Name = "button6";
            button6.Size = new Size(46, 43);
            button6.TabIndex = 10;
            button6.Text = "a++";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(154, 177);
            button7.Name = "button7";
            button7.Size = new Size(46, 43);
            button7.TabIndex = 11;
            button7.Text = "&&";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(211, 177);
            button8.Name = "button8";
            button8.Size = new Size(46, 43);
            button8.TabIndex = 12;
            button8.Text = "||";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 232);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tboxAndOr);
            Controls.Add(tboxNumber);
            Controls.Add(tboxResultBit);
            Controls.Add(tboxResultAfter);
            Controls.Add(tboxResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxResult;
        private TextBox tboxResultAfter;
        private TextBox tboxResultBit;
        private TextBox tboxNumber;
        private TextBox tboxAndOr;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
