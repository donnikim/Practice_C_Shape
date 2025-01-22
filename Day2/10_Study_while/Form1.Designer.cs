namespace _10_Study_while
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
            lblwhileResult = new Label();
            btnwhileResult = new Button();
            lboxwhileResult = new ListBox();
            panel1 = new Panel();
            btndowhileResult = new Button();
            label1 = new Label();
            tboxNumber = new TextBox();
            lbldowhileResult = new Label();
            SuspendLayout();
            // 
            // lblwhileResult
            // 
            lblwhileResult.BackColor = SystemColors.AppWorkspace;
            lblwhileResult.ForeColor = SystemColors.ButtonHighlight;
            lblwhileResult.Location = new Point(23, 38);
            lblwhileResult.Name = "lblwhileResult";
            lblwhileResult.Size = new Size(210, 23);
            lblwhileResult.TabIndex = 0;
            lblwhileResult.Text = "0, 0, 0, 0, 0, 0";
            lblwhileResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnwhileResult
            // 
            btnwhileResult.Location = new Point(272, 32);
            btnwhileResult.Name = "btnwhileResult";
            btnwhileResult.Size = new Size(82, 34);
            btnwhileResult.TabIndex = 1;
            btnwhileResult.Text = "로또 번호";
            btnwhileResult.UseVisualStyleBackColor = true;
            btnwhileResult.Click += btnwhileResult_Click;
            // 
            // lboxwhileResult
            // 
            lboxwhileResult.FormattingEnabled = true;
            lboxwhileResult.ItemHeight = 15;
            lboxwhileResult.Location = new Point(23, 74);
            lboxwhileResult.Name = "lboxwhileResult";
            lboxwhileResult.Size = new Size(210, 184);
            lboxwhileResult.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(23, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 3);
            panel1.TabIndex = 3;
            // 
            // btndowhileResult
            // 
            btndowhileResult.Location = new Point(112, 313);
            btndowhileResult.Name = "btndowhileResult";
            btndowhileResult.Size = new Size(82, 34);
            btndowhileResult.TabIndex = 4;
            btndowhileResult.Text = "선택 번호";
            btndowhileResult.UseVisualStyleBackColor = true;
            btndowhileResult.Click += btndowhileResult_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 295);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 5;
            label1.Text = "0~100안의 숫자를 선택하세요";
            // 
            // tboxNumber
            // 
            tboxNumber.Location = new Point(23, 325);
            tboxNumber.Name = "tboxNumber";
            tboxNumber.Size = new Size(60, 23);
            tboxNumber.TabIndex = 6;
            // 
            // lbldowhileResult
            // 
            lbldowhileResult.AutoSize = true;
            lbldowhileResult.Location = new Point(23, 361);
            lbldowhileResult.Name = "lbldowhileResult";
            lbldowhileResult.Size = new Size(12, 15);
            lbldowhileResult.TabIndex = 7;
            lbldowhileResult.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 402);
            Controls.Add(lbldowhileResult);
            Controls.Add(tboxNumber);
            Controls.Add(label1);
            Controls.Add(btndowhileResult);
            Controls.Add(panel1);
            Controls.Add(lboxwhileResult);
            Controls.Add(btnwhileResult);
            Controls.Add(lblwhileResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblwhileResult;
        private Button btnwhileResult;
        private ListBox lboxwhileResult;
        private Panel panel1;
        private Button btndowhileResult;
        private Label label1;
        private TextBox tboxNumber;
        private Label lbldowhileResult;
    }
}
