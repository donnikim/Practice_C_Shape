namespace _28_Study_Exception
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
            lblColorName = new Label();
            tbarAlpha = new TrackBar();
            pColor = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lboxColor = new ListBox();
            btnColorDelete = new Button();
            btnColorSave = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            cDialogColor = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbarAlpha).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblColorName);
            groupBox1.Controls.Add(tbarAlpha);
            groupBox1.Controls.Add(pColor);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 120);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color Select";
            // 
            // lblColorName
            // 
            lblColorName.AutoSize = true;
            lblColorName.Location = new Point(55, 88);
            lblColorName.Name = "lblColorName";
            lblColorName.Size = new Size(12, 15);
            lblColorName.TabIndex = 5;
            lblColorName.Text = "-";
            // 
            // tbarAlpha
            // 
            tbarAlpha.Location = new Point(55, 58);
            tbarAlpha.Maximum = 255;
            tbarAlpha.Name = "tbarAlpha";
            tbarAlpha.Size = new Size(252, 45);
            tbarAlpha.TabIndex = 4;
            tbarAlpha.Value = 255;
            tbarAlpha.Scroll += tbarAlpha_Scroll;
            // 
            // pColor
            // 
            pColor.BorderStyle = BorderStyle.FixedSingle;
            pColor.Location = new Point(55, 33);
            pColor.Name = "pColor";
            pColor.Size = new Size(20, 20);
            pColor.TabIndex = 3;
            pColor.MouseClick += pColor_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 87);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Text : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 58);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Alpha : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 33);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Color : ";
            // 
            // lboxColor
            // 
            lboxColor.FormattingEnabled = true;
            lboxColor.ItemHeight = 15;
            lboxColor.Location = new Point(12, 180);
            lboxColor.Name = "lboxColor";
            lboxColor.Size = new Size(400, 169);
            lboxColor.TabIndex = 1;
            lboxColor.SelectedIndexChanged += lboxColor_SelectedIndexChanged;
            // 
            // btnColorDelete
            // 
            btnColorDelete.Location = new Point(337, 138);
            btnColorDelete.Name = "btnColorDelete";
            btnColorDelete.Size = new Size(75, 36);
            btnColorDelete.TabIndex = 2;
            btnColorDelete.Text = "삭제";
            btnColorDelete.UseVisualStyleBackColor = true;
            btnColorDelete.Click += btnColorDelete_Click;
            // 
            // btnColorSave
            // 
            btnColorSave.Location = new Point(244, 138);
            btnColorSave.Name = "btnColorSave";
            btnColorSave.Size = new Size(75, 36);
            btnColorSave.TabIndex = 3;
            btnColorSave.Text = "저장";
            btnColorSave.UseVisualStyleBackColor = true;
            btnColorSave.Click += btnColorSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(436, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 337);
            panel1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(163, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(190, 196);
            panel5.TabIndex = 3;
            panel5.MouseClick += Panel_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(14, 151);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 75);
            panel4.TabIndex = 2;
            panel4.MouseClick += Panel_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Location = new Point(64, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(68, 224);
            panel3.TabIndex = 1;
            panel3.MouseClick += Panel_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(14, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 100);
            panel2.TabIndex = 0;
            panel2.MouseClick += Panel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 364);
            Controls.Add(panel1);
            Controls.Add(btnColorSave);
            Controls.Add(btnColorDelete);
            Controls.Add(lboxColor);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbarAlpha).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TrackBar tbarAlpha;
        private Panel pColor;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblColorName;
        private ListBox lboxColor;
        private Button btnColorDelete;
        private Button btnColorSave;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private ColorDialog cDialogColor;
    }
}
