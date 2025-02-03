
namespace _18_Study_Timer
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAdd50 = new Button();
            btnAdd3 = new Button();
            btnAdd1 = new Button();
            lblTotal = new Label();
            lblTickPoint = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAdd50);
            groupBox1.Controls.Add(btnAdd3);
            groupBox1.Controls.Add(btnAdd1);
            groupBox1.Controls.Add(lblTotal);
            groupBox1.Controls.Add(lblTickPoint);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 264);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "점수";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 234);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 8;
            label4.Text = "(5000)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 206);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "(500)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 178);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "(100)";
            // 
            // btnAdd50
            // 
            btnAdd50.Location = new Point(16, 229);
            btnAdd50.Name = "btnAdd50";
            btnAdd50.Size = new Size(143, 20);
            btnAdd50.TabIndex = 5;
            btnAdd50.Text = "+50";
            btnAdd50.UseVisualStyleBackColor = true;
            btnAdd50.Click += btnAdd_Click;
            // 
            // btnAdd3
            // 
            btnAdd3.Location = new Point(16, 203);
            btnAdd3.Name = "btnAdd3";
            btnAdd3.Size = new Size(143, 20);
            btnAdd3.TabIndex = 4;
            btnAdd3.Text = "+3";
            btnAdd3.UseVisualStyleBackColor = true;
            btnAdd3.Click += btnAdd_Click;
            // 
            // btnAdd1
            // 
            btnAdd1.Location = new Point(16, 174);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(143, 23);
            btnAdd1.TabIndex = 3;
            btnAdd1.Text = "+1";
            btnAdd1.UseVisualStyleBackColor = true;
            btnAdd1.Click += btnAdd_Click;
            // 
            // lblTotal
            // 
            lblTotal.BackColor = SystemColors.ActiveBorder;
            lblTotal.ForeColor = SystemColors.ControlDarkDark;
            lblTotal.Location = new Point(16, 59);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(304, 97);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "0";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTickPoint
            // 
            lblTickPoint.BackColor = SystemColors.ControlLightLight;
            lblTickPoint.Location = new Point(93, 28);
            lblTickPoint.Name = "lblTickPoint";
            lblTickPoint.Size = new Size(222, 15);
            lblTickPoint.TabIndex = 1;
            lblTickPoint.Text = "0";
            lblTickPoint.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Tick Point : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 292);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            FormClosed += Form1_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private GroupBox groupBox1;
        private Label lblTotal;
        private Label lblTickPoint;
        private Label label1;
        private Button btnAdd3;
        private Button btnAdd1;
        private Button btnAdd50;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
