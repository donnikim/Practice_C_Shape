namespace _26_Study_Thread
{
    partial class Play
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
            lblPlayerName = new Label();
            progressBar1 = new ProgressBar();
            lblProcess = new Label();
            btnStop = new Button();
            SuspendLayout();
            // 
            // lblPlayerName
            // 
            lblPlayerName.AutoSize = true;
            lblPlayerName.Location = new Point(21, 13);
            lblPlayerName.Name = "lblPlayerName";
            lblPlayerName.Size = new Size(71, 15);
            lblPlayerName.TabIndex = 0;
            lblPlayerName.Text = "PlayerName";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 35);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(376, 20);
            progressBar1.TabIndex = 1;
            // 
            // lblProcess
            // 
            lblProcess.AutoSize = true;
            lblProcess.Location = new Point(282, 12);
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new Size(115, 15);
            lblProcess.TabIndex = 2;
            lblProcess.Text = "진행 상황 표시 : 0%";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(185, 9);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(55, 21);
            btnStop.TabIndex = 3;
            btnStop.Text = "포기";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 60);
            Controls.Add(btnStop);
            Controls.Add(lblProcess);
            Controls.Add(progressBar1);
            Controls.Add(lblPlayerName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Play";
            StartPosition = FormStartPosition.Manual;
            Text = "Play";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayerName;
        private ProgressBar progressBar1;
        private Label lblProcess;
        private Button btnStop;
    }
}