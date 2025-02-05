namespace _29_User_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pMain = new Panel();
            ucInfo3 = new UCInfo();
            ucInfo2 = new UCInfo();
            ucInfo1 = new UCInfo();
            lboxList = new ListBox();
            pMain.SuspendLayout();
            SuspendLayout();
            // 
            // pMain
            // 
            pMain.BackColor = Color.FromArgb(192, 64, 0);
            pMain.Controls.Add(ucInfo3);
            pMain.Controls.Add(ucInfo2);
            pMain.Controls.Add(ucInfo1);
            pMain.Location = new Point(12, 12);
            pMain.Name = "pMain";
            pMain.Size = new Size(820, 333);
            pMain.TabIndex = 0;
            // 
            // ucInfo3
            // 
            ucInfo3.BackColor = SystemColors.ControlDark;
            ucInfo3.Location = new Point(537, 36);
            ucInfo3.Name = "ucInfo3";
            ucInfo3.Size = new Size(247, 256);
            ucInfo3.TabIndex = 2;
            ucInfo3.UserFace = (Image)resources.GetObject("ucInfo3.UserFace");
            ucInfo3.UserGold = "50억원";
            ucInfo3.UserName = "루피";
            ucInfo3.UserNo = "3";
            // 
            // ucInfo2
            // 
            ucInfo2.BackColor = SystemColors.ControlDark;
            ucInfo2.Location = new Point(284, 36);
            ucInfo2.Name = "ucInfo2";
            ucInfo2.Size = new Size(247, 256);
            ucInfo2.TabIndex = 1;
            ucInfo2.UserFace = (Image)resources.GetObject("ucInfo2.UserFace");
            ucInfo2.UserGold = "300만원";
            ucInfo2.UserName = "임꺽정";
            ucInfo2.UserNo = "2";
            // 
            // ucInfo1
            // 
            ucInfo1.BackColor = SystemColors.ControlDark;
            ucInfo1.Location = new Point(31, 36);
            ucInfo1.Name = "ucInfo1";
            ucInfo1.Size = new Size(247, 256);
            ucInfo1.TabIndex = 0;
            ucInfo1.UserFace = (Image)resources.GetObject("ucInfo1.UserFace");
            ucInfo1.UserGold = "2천만원";
            ucInfo1.UserName = "홍길동";
            ucInfo1.UserNo = "1";
            // 
            // lboxList
            // 
            lboxList.FormattingEnabled = true;
            lboxList.ItemHeight = 15;
            lboxList.Location = new Point(12, 351);
            lboxList.Name = "lboxList";
            lboxList.Size = new Size(820, 214);
            lboxList.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 585);
            Controls.Add(lboxList);
            Controls.Add(pMain);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pMain;
        private UCInfo ucInfo3;
        private UCInfo ucInfo2;
        private UCInfo ucInfo1;
        private ListBox lboxList;
    }
}
