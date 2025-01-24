namespace _16_StreamReader_StreamWriter
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
            btnLoad = new Button();
            btnSave = new Button();
            tboxConfigData = new TextBox();
            groupBox1 = new GroupBox();
            numData = new NumericUpDown();
            cboxData = new CheckBox();
            tboxData = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnConfigRead = new Button();
            btnConfigSet = new Button();
            SFDialog = new SaveFileDialog();
            OFDialog = new OpenFileDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numData).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(24, 22);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(139, 36);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Text가져오기";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(169, 22);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 36);
            btnSave.TabIndex = 1;
            btnSave.Text = "Text저장하기";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tboxConfigData
            // 
            tboxConfigData.Enabled = false;
            tboxConfigData.Location = new Point(24, 64);
            tboxConfigData.Multiline = true;
            tboxConfigData.Name = "tboxConfigData";
            tboxConfigData.Size = new Size(287, 197);
            tboxConfigData.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numData);
            groupBox1.Controls.Add(cboxData);
            groupBox1.Controls.Add(tboxData);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(24, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(287, 133);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Config";
            // 
            // numData
            // 
            numData.Location = new Point(95, 92);
            numData.Name = "numData";
            numData.Size = new Size(78, 23);
            numData.TabIndex = 5;
            // 
            // cboxData
            // 
            cboxData.AutoSize = true;
            cboxData.Location = new Point(104, 67);
            cboxData.Name = "cboxData";
            cboxData.Size = new Size(48, 19);
            cboxData.TabIndex = 4;
            cboxData.Text = "CB1";
            cboxData.UseVisualStyleBackColor = true;
            // 
            // tboxData
            // 
            tboxData.Location = new Point(73, 30);
            tboxData.Name = "tboxData";
            tboxData.Size = new Size(100, 23);
            tboxData.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 97);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "3. Number : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 67);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "2. CheckBox : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "1. Text : ";
            // 
            // btnConfigRead
            // 
            btnConfigRead.Location = new Point(24, 418);
            btnConfigRead.Name = "btnConfigRead";
            btnConfigRead.Size = new Size(139, 36);
            btnConfigRead.TabIndex = 4;
            btnConfigRead.Text = "Config 가져오기";
            btnConfigRead.UseVisualStyleBackColor = true;
            btnConfigRead.Click += btnConfigRead_Click_1;
            // 
            // btnConfigSet
            // 
            btnConfigSet.Location = new Point(169, 418);
            btnConfigSet.Name = "btnConfigSet";
            btnConfigSet.Size = new Size(142, 36);
            btnConfigSet.TabIndex = 5;
            btnConfigSet.Text = "Config 설정하기";
            btnConfigSet.UseVisualStyleBackColor = true;
            btnConfigSet.Click += btnConfigSet_Click;
            // 
            // OFDialog
            // 
            OFDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 479);
            Controls.Add(btnConfigSet);
            Controls.Add(btnConfigRead);
            Controls.Add(groupBox1);
            Controls.Add(tboxConfigData);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Button btnSave;
        private TextBox tboxConfigData;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numData;
        private CheckBox cboxData;
        private TextBox tboxData;
        private Button btnConfigRead;
        private Button btnConfigSet;
        private SaveFileDialog SFDialog;
        private OpenFileDialog OFDialog;
    }
}
