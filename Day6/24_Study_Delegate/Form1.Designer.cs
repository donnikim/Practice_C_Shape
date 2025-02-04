namespace _24_Study_Delegate
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
            rdoDow2 = new RadioButton();
            rdoDow1 = new RadioButton();
            groupBox2 = new GroupBox();
            rdoEdge2 = new RadioButton();
            rdoEdge1 = new RadioButton();
            groupBox3 = new GroupBox();
            label1 = new Label();
            numEA = new NumericUpDown();
            cboxTopping3 = new CheckBox();
            cboxTopping2 = new CheckBox();
            cboxTopping1 = new CheckBox();
            btnOrder = new Button();
            lboxOrder = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoDow2);
            groupBox1.Controls.Add(rdoDow1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(424, 63);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "도우";
            // 
            // rdoDow2
            // 
            rdoDow2.AutoSize = true;
            rdoDow2.Location = new Point(199, 27);
            rdoDow2.Name = "rdoDow2";
            rdoDow2.Size = new Size(99, 19);
            rdoDow2.TabIndex = 1;
            rdoDow2.TabStop = true;
            rdoDow2.Text = "씬 (11,000원)";
            rdoDow2.UseVisualStyleBackColor = true;
            // 
            // rdoDow1
            // 
            rdoDow1.AutoSize = true;
            rdoDow1.Location = new Point(14, 27);
            rdoDow1.Name = "rdoDow1";
            rdoDow1.Size = new Size(135, 19);
            rdoDow1.TabIndex = 0;
            rdoDow1.TabStop = true;
            rdoDow1.Text = "오리지널 (10,000원)";
            rdoDow1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdoEdge2);
            groupBox2.Controls.Add(rdoEdge1);
            groupBox2.Location = new Point(12, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(424, 52);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "엣지";
            // 
            // rdoEdge2
            // 
            rdoEdge2.AutoSize = true;
            rdoEdge2.Location = new Point(199, 22);
            rdoEdge2.Name = "rdoEdge2";
            rdoEdge2.Size = new Size(148, 19);
            rdoEdge2.TabIndex = 2;
            rdoEdge2.TabStop = true;
            rdoEdge2.Text = "치즈크러스트(2,000원)";
            rdoEdge2.UseVisualStyleBackColor = true;
            // 
            // rdoEdge1
            // 
            rdoEdge1.AutoSize = true;
            rdoEdge1.Location = new Point(14, 22);
            rdoEdge1.Name = "rdoEdge1";
            rdoEdge1.Size = new Size(128, 19);
            rdoEdge1.TabIndex = 1;
            rdoEdge1.TabStop = true;
            rdoEdge1.Text = "리치골드 (1,000원)";
            rdoEdge1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(numEA);
            groupBox3.Controls.Add(cboxTopping3);
            groupBox3.Controls.Add(cboxTopping2);
            groupBox3.Controls.Add(cboxTopping1);
            groupBox3.Location = new Point(12, 139);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(424, 108);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "토핑";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(372, 80);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "(EA)";
            // 
            // numEA
            // 
            numEA.Location = new Point(313, 76);
            numEA.Name = "numEA";
            numEA.Size = new Size(53, 23);
            numEA.TabIndex = 3;
            // 
            // cboxTopping3
            // 
            cboxTopping3.AutoSize = true;
            cboxTopping3.Location = new Point(14, 76);
            cboxTopping3.Name = "cboxTopping3";
            cboxTopping3.Size = new Size(118, 19);
            cboxTopping3.TabIndex = 2;
            cboxTopping3.Text = "치즈 (1ea 300원)";
            cboxTopping3.UseVisualStyleBackColor = true;
            // 
            // cboxTopping2
            // 
            cboxTopping2.AutoSize = true;
            cboxTopping2.Location = new Point(14, 51);
            cboxTopping2.Name = "cboxTopping2";
            cboxTopping2.Size = new Size(114, 19);
            cboxTopping2.TabIndex = 1;
            cboxTopping2.Text = "감자(1ea 200원)";
            cboxTopping2.UseVisualStyleBackColor = true;
            // 
            // cboxTopping1
            // 
            cboxTopping1.AutoSize = true;
            cboxTopping1.Location = new Point(14, 26);
            cboxTopping1.Name = "cboxTopping1";
            cboxTopping1.Size = new Size(126, 19);
            cboxTopping1.TabIndex = 0;
            cboxTopping1.Text = "소세지(1ea 500원)";
            cboxTopping1.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(325, 253);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(111, 23);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // lboxOrder
            // 
            lboxOrder.FormattingEnabled = true;
            lboxOrder.ItemHeight = 15;
            lboxOrder.Location = new Point(9, 282);
            lboxOrder.Name = "lboxOrder";
            lboxOrder.Size = new Size(427, 199);
            lboxOrder.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 500);
            Controls.Add(lboxOrder);
            Controls.Add(btnOrder);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdoDow1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton rdoDow2;
        private RadioButton rdoEdge2;
        private RadioButton rdoEdge1;
        private Label label1;
        private NumericUpDown numEA;
        private CheckBox cboxTopping3;
        private CheckBox cboxTopping2;
        private CheckBox cboxTopping1;
        private Button btnOrder;
        private ListBox lboxOrder;
    }
}
