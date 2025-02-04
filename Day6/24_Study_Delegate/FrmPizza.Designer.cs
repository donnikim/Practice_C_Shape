namespace _24_Study_Delegate
{
    partial class FrmPizza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnClose = new Button();
            lboxMake = new ListBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(12, 280);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(401, 31);
            btnClose.TabIndex = 0;
            btnClose.Text = "창 닫기";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // lboxMake
            // 
            lboxMake.FormattingEnabled = true;
            lboxMake.ItemHeight = 15;
            lboxMake.Location = new Point(12, 12);
            lboxMake.Name = "lboxMake";
            lboxMake.Size = new Size(401, 259);
            lboxMake.TabIndex = 1;
            // 
            // FrmPizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 320);
            Controls.Add(lboxMake);
            Controls.Add(btnClose);
            Name = "FrmPizza";
            Text = "FrmPizza";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private ListBox lboxMake;
    }
}