namespace Study_Array
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
            label1 = new Label();
            dgDay = new DataGridView();
            colDay1 = new DataGridViewTextBoxColumn();
            colDay2 = new DataGridViewTextBoxColumn();
            colDay3 = new DataGridViewTextBoxColumn();
            colDay4 = new DataGridViewTextBoxColumn();
            colDay5 = new DataGridViewTextBoxColumn();
            colDay6 = new DataGridViewTextBoxColumn();
            colDay7 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            lblArray = new Label();
            ((System.ComponentModel.ISupportInitialize)dgDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "매장 방문 수";
            // 
            // dgDay
            // 
            dgDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDay.Columns.AddRange(new DataGridViewColumn[] { colDay1, colDay2, colDay3, colDay4, colDay5, colDay6, colDay7 });
            dgDay.Location = new Point(12, 42);
            dgDay.Name = "dgDay";
            dgDay.Size = new Size(736, 150);
            dgDay.TabIndex = 1;
            // 
            // colDay1
            // 
            colDay1.HeaderText = "월";
            colDay1.Name = "colDay1";
            // 
            // colDay2
            // 
            colDay2.HeaderText = "화";
            colDay2.Name = "colDay2";
            // 
            // colDay3
            // 
            colDay3.HeaderText = "수";
            colDay3.Name = "colDay3";
            // 
            // colDay4
            // 
            colDay4.HeaderText = "목";
            colDay4.Name = "colDay4";
            // 
            // colDay5
            // 
            colDay5.HeaderText = "금";
            colDay5.Name = "colDay5";
            // 
            // colDay6
            // 
            colDay6.HeaderText = "토";
            colDay6.Name = "colDay6";
            // 
            // colDay7
            // 
            colDay7.HeaderText = "일";
            colDay7.Name = "colDay7";
            // 
            // button1
            // 
            button1.Location = new Point(12, 212);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "일주일간";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(105, 212);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "이주일간";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lblArray
            // 
            lblArray.AutoSize = true;
            lblArray.Location = new Point(231, 216);
            lblArray.Name = "lblArray";
            lblArray.Size = new Size(93, 15);
            lblArray.TabIndex = 4;
            lblArray.Text = "전체 자료 수 : 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 278);
            Controls.Add(lblArray);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgDay);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgDay;
        private DataGridViewTextBoxColumn colDay1;
        private DataGridViewTextBoxColumn colDay2;
        private DataGridViewTextBoxColumn colDay3;
        private DataGridViewTextBoxColumn colDay4;
        private DataGridViewTextBoxColumn colDay5;
        private DataGridViewTextBoxColumn colDay6;
        private DataGridViewTextBoxColumn colDay7;
        private Button button1;
        private Button button2;
        private Label lblArray;
    }
}
