using System;

namespace _39_Study_User32_CopyAndPaste
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lboxTestSave = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblactivation = new System.Windows.Forms.Label();
            this.cboxactivation = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Tbar = new System.Windows.Forms.TrackBar();
            this.btnlbtextadd = new System.Windows.Forms.Button();
            this.txtlbtextadd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbar)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxTestSave
            // 
            this.lboxTestSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxTestSave.FormattingEnabled = true;
            this.lboxTestSave.ItemHeight = 12;
            this.lboxTestSave.Location = new System.Drawing.Point(3, 43);
            this.lboxTestSave.Name = "lboxTestSave";
            this.lboxTestSave.Size = new System.Drawing.Size(300, 240);
            this.lboxTestSave.TabIndex = 0;
            this.lboxTestSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbox_keyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lboxTestSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 326);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblactivation);
            this.panel1.Controls.Add(this.cboxactivation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 40);
            this.panel1.TabIndex = 1;
            // 
            // lblactivation
            // 
            this.lblactivation.AutoSize = true;
            this.lblactivation.Location = new System.Drawing.Point(99, 13);
            this.lblactivation.Name = "lblactivation";
            this.lblactivation.Size = new System.Drawing.Size(149, 12);
            this.lblactivation.TabIndex = 1;
            this.lblactivation.Text = "활성화 상태 (Ctrl+ C 가능)";
            // 
            // cboxactivation
            // 
            this.cboxactivation.AutoSize = true;
            this.cboxactivation.Checked = true;
            this.cboxactivation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboxactivation.Location = new System.Drawing.Point(9, 12);
            this.cboxactivation.Name = "cboxactivation";
            this.cboxactivation.Size = new System.Drawing.Size(78, 16);
            this.cboxactivation.TabIndex = 0;
            this.cboxactivation.Text = "Activation";
            this.cboxactivation.UseVisualStyleBackColor = true;
            this.cboxactivation.CheckedChanged += new System.EventHandler(this.cbox_Change);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Tbar);
            this.panel2.Controls.Add(this.btnlbtextadd);
            this.panel2.Controls.Add(this.txtlbtextadd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 286);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 40);
            this.panel2.TabIndex = 2;
            // 
            // Tbar
            // 
            this.Tbar.Location = new System.Drawing.Point(205, 3);
            this.Tbar.Minimum = 2;
            this.Tbar.Name = "Tbar";
            this.Tbar.Size = new System.Drawing.Size(86, 45);
            this.Tbar.TabIndex = 2;
            this.Tbar.Value = 10;
            this.Tbar.Scroll += new System.EventHandler(this.tbox_scroll);
            // 
            // btnlbtextadd
            // 
            this.btnlbtextadd.Location = new System.Drawing.Point(101, 7);
            this.btnlbtextadd.Name = "btnlbtextadd";
            this.btnlbtextadd.Size = new System.Drawing.Size(75, 23);
            this.btnlbtextadd.TabIndex = 1;
            this.btnlbtextadd.Text = "등록";
            this.btnlbtextadd.UseVisualStyleBackColor = true;
            this.btnlbtextadd.Click += new System.EventHandler(this.btnlbtextadd_Click);
            // 
            // txtlbtextadd
            // 
            this.txtlbtextadd.Location = new System.Drawing.Point(11, 9);
            this.txtlbtextadd.Name = "txtlbtextadd";
            this.txtlbtextadd.Size = new System.Drawing.Size(84, 21);
            this.txtlbtextadd.TabIndex = 0;
            this.txtlbtextadd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tbar)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.ListBox lboxTestSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblactivation;
        private System.Windows.Forms.CheckBox cboxactivation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar Tbar;
        private System.Windows.Forms.Button btnlbtextadd;
        private System.Windows.Forms.TextBox txtlbtextadd;
    }
}

