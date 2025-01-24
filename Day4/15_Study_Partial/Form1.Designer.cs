namespace _15_Study_Partial
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
            lboxItem = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cboxItem = new ComboBox();
            cboxRate = new ComboBox();
            numcout = new NumericUpDown();
            btnAdd = new Button();
            tboxResult = new TextBox();
            tboxErrMsg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numcout).BeginInit();
            SuspendLayout();
            // 
            // lboxItem
            // 
            lboxItem.FormattingEnabled = true;
            lboxItem.ItemHeight = 15;
            lboxItem.Location = new Point(24, 26);
            lboxItem.Name = "lboxItem";
            lboxItem.Size = new Size(245, 229);
            lboxItem.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 26);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "물건";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 82);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "할인율(%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(297, 139);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "개수";
            // 
            // cboxItem
            // 
            cboxItem.FormattingEnabled = true;
            cboxItem.Location = new Point(297, 44);
            cboxItem.Name = "cboxItem";
            cboxItem.Size = new Size(138, 23);
            cboxItem.TabIndex = 4;
            // 
            // cboxRate
            // 
            cboxRate.FormattingEnabled = true;
            cboxRate.Location = new Point(297, 100);
            cboxRate.Name = "cboxRate";
            cboxRate.Size = new Size(138, 23);
            cboxRate.TabIndex = 5;
            // 
            // numcout
            // 
            numcout.Location = new Point(297, 157);
            numcout.Name = "numcout";
            numcout.Size = new Size(138, 23);
            numcout.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(291, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "장바구니";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tboxResult
            // 
            tboxResult.Location = new Point(24, 265);
            tboxResult.Name = "tboxResult";
            tboxResult.Size = new Size(245, 23);
            tboxResult.TabIndex = 8;
            // 
            // tboxErrMsg
            // 
            tboxErrMsg.ForeColor = Color.Red;
            tboxErrMsg.Location = new Point(24, 303);
            tboxErrMsg.Name = "tboxErrMsg";
            tboxErrMsg.Size = new Size(421, 23);
            tboxErrMsg.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 350);
            Controls.Add(tboxErrMsg);
            Controls.Add(tboxResult);
            Controls.Add(btnAdd);
            Controls.Add(numcout);
            Controls.Add(cboxRate);
            Controls.Add(cboxItem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lboxItem);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numcout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lboxItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboxItem;
        private ComboBox cboxRate;
        private NumericUpDown numcout;
        private Button btnAdd;
        private TextBox tboxResult;
        private TextBox tboxErrMsg;
    }
}
