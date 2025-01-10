namespace Study_Method
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
            tboxNumber2 = new TextBox();
            tboxNumber1 = new TextBox();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMulti = new Button();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // tboxResult
            // 
            tboxResult.Enabled = false;
            tboxResult.Location = new Point(21, 12);
            tboxResult.Name = "tboxResult";
            tboxResult.Size = new Size(248, 23);
            tboxResult.TabIndex = 0;
            tboxResult.Text = "0";
            // 
            // tboxNumber2
            // 
            tboxNumber2.Location = new Point(152, 53);
            tboxNumber2.Name = "tboxNumber2";
            tboxNumber2.Size = new Size(117, 23);
            tboxNumber2.TabIndex = 1;
            tboxNumber2.Text = "0";
            // 
            // tboxNumber1
            // 
            tboxNumber1.Location = new Point(21, 53);
            tboxNumber1.Name = "tboxNumber1";
            tboxNumber1.Size = new Size(125, 23);
            tboxNumber1.TabIndex = 2;
            tboxNumber1.Text = "0";
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(21, 102);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(48, 44);
            btnPlus.TabIndex = 3;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(86, 102);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(48, 44);
            btnMinus.TabIndex = 4;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(152, 102);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(48, 44);
            btnMulti.TabIndex = 5;
            btnMulti.Text = "*";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(221, 102);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(48, 44);
            btnDivision.TabIndex = 6;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 183);
            Controls.Add(btnDivision);
            Controls.Add(btnMulti);
            Controls.Add(btnMinus);
            Controls.Add(btnPlus);
            Controls.Add(tboxNumber1);
            Controls.Add(tboxNumber2);
            Controls.Add(tboxResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxResult;
        private TextBox tboxNumber2;
        private TextBox tboxNumber1;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMulti;
        private Button btnDivision;
    }
}
