namespace _23_Study_DataTable
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
            btnReg = new Button();
            tboxRegRef = new TextBox();
            rdoRegSexFemale = new RadioButton();
            rdoRegSexMale = new RadioButton();
            tboxRegName = new TextBox();
            cboxRegClass = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgViewInfo = new DataGridView();
            btnViewDataDel = new Button();
            cboxViewClass = new ComboBox();
            btnModify = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgViewInfo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReg);
            groupBox1.Controls.Add(tboxRegRef);
            groupBox1.Controls.Add(rdoRegSexFemale);
            groupBox1.Controls.Add(rdoRegSexMale);
            groupBox1.Controls.Add(tboxRegName);
            groupBox1.Controls.Add(cboxRegClass);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "등록하기";
            // 
            // btnReg
            // 
            btnReg.Location = new Point(301, 164);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(75, 23);
            btnReg.TabIndex = 9;
            btnReg.Text = "등록";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // tboxRegRef
            // 
            tboxRegRef.Location = new Point(76, 135);
            tboxRegRef.Name = "tboxRegRef";
            tboxRegRef.Size = new Size(121, 23);
            tboxRegRef.TabIndex = 8;
            // 
            // rdoRegSexFemale
            // 
            rdoRegSexFemale.AutoSize = true;
            rdoRegSexFemale.Location = new Point(148, 102);
            rdoRegSexFemale.Name = "rdoRegSexFemale";
            rdoRegSexFemale.Size = new Size(49, 19);
            rdoRegSexFemale.TabIndex = 7;
            rdoRegSexFemale.TabStop = true;
            rdoRegSexFemale.Text = "여자";
            rdoRegSexFemale.UseVisualStyleBackColor = true;
            // 
            // rdoRegSexMale
            // 
            rdoRegSexMale.AutoSize = true;
            rdoRegSexMale.Location = new Point(76, 104);
            rdoRegSexMale.Name = "rdoRegSexMale";
            rdoRegSexMale.Size = new Size(49, 19);
            rdoRegSexMale.TabIndex = 6;
            rdoRegSexMale.TabStop = true;
            rdoRegSexMale.Text = "남자";
            rdoRegSexMale.UseVisualStyleBackColor = true;
            // 
            // tboxRegName
            // 
            tboxRegName.Location = new Point(76, 67);
            tboxRegName.Name = "tboxRegName";
            tboxRegName.Size = new Size(121, 23);
            tboxRegName.TabIndex = 5;
            // 
            // cboxRegClass
            // 
            cboxRegClass.FormattingEnabled = true;
            cboxRegClass.Items.AddRange(new object[] { "1반", "2반", "3반" });
            cboxRegClass.Location = new Point(76, 36);
            cboxRegClass.Name = "cboxRegClass";
            cboxRegClass.Size = new Size(121, 23);
            cboxRegClass.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 138);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 3;
            label4.Text = "특기 : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 106);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "성별 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "이름 : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "반 : ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnModify);
            groupBox2.Controls.Add(dgViewInfo);
            groupBox2.Controls.Add(btnViewDataDel);
            groupBox2.Controls.Add(cboxViewClass);
            groupBox2.Location = new Point(22, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(749, 305);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "내용 확인";
            // 
            // dgViewInfo
            // 
            dgViewInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgViewInfo.Location = new Point(6, 49);
            dgViewInfo.Name = "dgViewInfo";
            dgViewInfo.Size = new Size(737, 237);
            dgViewInfo.TabIndex = 2;
            // 
            // btnViewDataDel
            // 
            btnViewDataDel.Location = new Point(668, 20);
            btnViewDataDel.Name = "btnViewDataDel";
            btnViewDataDel.Size = new Size(75, 23);
            btnViewDataDel.TabIndex = 1;
            btnViewDataDel.Text = "삭제";
            btnViewDataDel.UseVisualStyleBackColor = true;
            btnViewDataDel.Click += btnViewDataDel_Click;
            // 
            // cboxViewClass
            // 
            cboxViewClass.FormattingEnabled = true;
            cboxViewClass.Items.AddRange(new object[] { "1반", "2반", "3반" });
            cboxViewClass.Location = new Point(6, 22);
            cboxViewClass.Name = "cboxViewClass";
            cboxViewClass.Size = new Size(121, 23);
            cboxViewClass.TabIndex = 0;
            cboxViewClass.SelectedIndexChanged += cboxViewClass_SelectedIndexChanged;
            // 
            // btnModify
            // 
            btnModify.Location = new Point(587, 20);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(75, 23);
            btnModify.TabIndex = 3;
            btnModify.Text = "수정";
            btnModify.UseVisualStyleBackColor = true;
            btnModify.Click += btnModify_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 556);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgViewInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cboxRegClass;
        private TextBox tboxRegRef;
        private RadioButton rdoRegSexFemale;
        private RadioButton rdoRegSexMale;
        private TextBox tboxRegName;
        private Button btnReg;
        private ComboBox cboxViewClass;
        private DataGridView dgViewInfo;
        private Button btnViewDataDel;
        private Button btnModify;
    }
}
