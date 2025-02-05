namespace _31_Linq
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
            dgEnemyTable = new DataGridView();
            btnLevel = new Button();
            btnName = new Button();
            btnAttribute = new Button();
            cboxAttribute = new ComboBox();
            nLevelMin = new NumericUpDown();
            label1 = new Label();
            nLevelMax = new NumericUpDown();
            btnFilter = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgEnemyTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nLevelMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nLevelMax).BeginInit();
            SuspendLayout();
            // 
            // dgEnemyTable
            // 
            dgEnemyTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEnemyTable.Location = new Point(12, 12);
            dgEnemyTable.Name = "dgEnemyTable";
            dgEnemyTable.Size = new Size(295, 531);
            dgEnemyTable.TabIndex = 0;
            // 
            // btnLevel
            // 
            btnLevel.Location = new Point(325, 12);
            btnLevel.Name = "btnLevel";
            btnLevel.Size = new Size(160, 44);
            btnLevel.TabIndex = 1;
            btnLevel.Text = "Level 순으로";
            btnLevel.UseVisualStyleBackColor = true;
            btnLevel.Click += btnSort_Click;
            // 
            // btnName
            // 
            btnName.Location = new Point(325, 62);
            btnName.Name = "btnName";
            btnName.Size = new Size(160, 44);
            btnName.TabIndex = 2;
            btnName.Text = "Name 순으로";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnSort_Click;
            // 
            // btnAttribute
            // 
            btnAttribute.Location = new Point(325, 112);
            btnAttribute.Name = "btnAttribute";
            btnAttribute.Size = new Size(160, 44);
            btnAttribute.TabIndex = 3;
            btnAttribute.Text = "속성 순으로";
            btnAttribute.UseVisualStyleBackColor = true;
            btnAttribute.Click += btnSort_Click;
            // 
            // cboxAttribute
            // 
            cboxAttribute.FormattingEnabled = true;
            cboxAttribute.Location = new Point(325, 172);
            cboxAttribute.Name = "cboxAttribute";
            cboxAttribute.Size = new Size(160, 23);
            cboxAttribute.TabIndex = 4;
            // 
            // nLevelMin
            // 
            nLevelMin.Location = new Point(325, 212);
            nLevelMin.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nLevelMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nLevelMin.Name = "nLevelMin";
            nLevelMin.Size = new Size(65, 23);
            nLevelMin.TabIndex = 5;
            nLevelMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(396, 215);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 6;
            label1.Text = "~";
            // 
            // nLevelMax
            // 
            nLevelMax.Location = new Point(417, 212);
            nLevelMax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nLevelMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nLevelMax.Name = "nLevelMax";
            nLevelMax.Size = new Size(68, 23);
            nLevelMax.TabIndex = 7;
            nLevelMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(325, 253);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(160, 44);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(325, 303);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 44);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 555);
            Controls.Add(btnCancel);
            Controls.Add(btnFilter);
            Controls.Add(nLevelMax);
            Controls.Add(label1);
            Controls.Add(nLevelMin);
            Controls.Add(cboxAttribute);
            Controls.Add(btnAttribute);
            Controls.Add(btnName);
            Controls.Add(btnLevel);
            Controls.Add(dgEnemyTable);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgEnemyTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)nLevelMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nLevelMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgEnemyTable;
        private Button btnLevel;
        private Button btnName;
        private Button btnAttribute;
        private ComboBox cboxAttribute;
        private NumericUpDown nLevelMin;
        private Label label1;
        private NumericUpDown nLevelMax;
        private Button btnFilter;
        private Button btnCancel;
    }
}
