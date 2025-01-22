namespace _9_Study_For_Each
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
            btnFor = new Button();
            btnForeach = new Button();
            SuspendLayout();
            // 
            // tboxResult
            // 
            tboxResult.Location = new Point(12, 12);
            tboxResult.Multiline = true;
            tboxResult.Name = "tboxResult";
            tboxResult.ScrollBars = ScrollBars.Vertical;
            tboxResult.Size = new Size(300, 261);
            tboxResult.TabIndex = 0;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(318, 12);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(150, 88);
            btnFor.TabIndex = 1;
            btnFor.Text = "For문";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnForeach
            // 
            btnForeach.Location = new Point(318, 119);
            btnForeach.Name = "btnForeach";
            btnForeach.Size = new Size(150, 88);
            btnForeach.TabIndex = 2;
            btnForeach.Text = "For Each문";
            btnForeach.UseVisualStyleBackColor = true;
            btnForeach.Click += btnForeach_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 321);
            Controls.Add(btnForeach);
            Controls.Add(btnFor);
            Controls.Add(tboxResult);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxResult;
        private Button btnFor;
        private Button btnForeach;
    }
}
