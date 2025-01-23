namespace _12_Study_Inheritance
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
            pMain = new Panel();
            lblName = new Label();
            btnOneCycle = new Button();
            btnCycle = new Button();
            btnCar = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.BackColor = SystemColors.AppWorkspace;
            pMain.Location = new Point(33, 38);
            pMain.Name = "pMain";
            pMain.Size = new Size(600, 300);
            pMain.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.BackColor = SystemColors.ControlDarkDark;
            lblName.ForeColor = SystemColors.ControlLightLight;
            lblName.Location = new Point(33, 356);
            lblName.Name = "lblName";
            lblName.Size = new Size(103, 28);
            lblName.TabIndex = 1;
            lblName.Text = "-";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOneCycle
            // 
            btnOneCycle.Location = new Point(175, 356);
            btnOneCycle.Name = "btnOneCycle";
            btnOneCycle.Size = new Size(130, 28);
            btnOneCycle.TabIndex = 2;
            btnOneCycle.Text = "1단계 : 외발 자전거";
            btnOneCycle.UseVisualStyleBackColor = true;
            btnOneCycle.Click += btnOneCycle_Click;
            // 
            // btnCycle
            // 
            btnCycle.Location = new Point(325, 356);
            btnCycle.Name = "btnCycle";
            btnCycle.Size = new Size(130, 28);
            btnCycle.TabIndex = 3;
            btnCycle.Text = "2단계 : 자전거";
            btnCycle.UseVisualStyleBackColor = true;
            btnCycle.Click += btnCycle_Click;
            // 
            // btnCar
            // 
            btnCar.Location = new Point(471, 356);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(130, 28);
            btnCar.TabIndex = 4;
            btnCar.Text = "3단계 : 자동차";
            btnCar.UseVisualStyleBackColor = true;
            btnCar.Click += btnCar_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(251, 390);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(130, 48);
            btnLeft.TabIndex = 5;
            btnLeft.Text = "<--";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += btnLeft_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(387, 390);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(130, 48);
            btnRight.TabIndex = 6;
            btnRight.Text = "-->";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += btnRight_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnCar);
            Controls.Add(btnCycle);
            Controls.Add(btnOneCycle);
            Controls.Add(lblName);
            Controls.Add(pMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pMain;
        private Label lblName;
        private Button btnOneCycle;
        private Button btnCycle;
        private Button btnCar;
        private Button btnLeft;
        private Button btnRight;
    }
}
