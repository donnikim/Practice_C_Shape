namespace _29_User_Control
{
    partial class UCInfo
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            lblNo = new Label();
            pboxFace = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblName = new Label();
            lblGold = new Label();
            btnReg = new Button();
            btnIdle = new Button();
            btnCatch = new Button();
            ((System.ComponentModel.ISupportInitialize)pboxFace).BeginInit();
            SuspendLayout();
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(15, 21);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(14, 15);
            lblNo.TabIndex = 0;
            lblNo.Text = "1";
            // 
            // pboxFace
            // 
            pboxFace.BackgroundImageLayout = ImageLayout.Stretch;
            pboxFace.Location = new Point(72, 22);
            pboxFace.Name = "pboxFace";
            pboxFace.Size = new Size(100, 118);
            pboxFace.TabIndex = 1;
            pboxFace.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 152);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "이름 : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 179);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "금액 : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(118, 152);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 4;
            lblName.Text = "아무개";
            // 
            // lblGold
            // 
            lblGold.AutoSize = true;
            lblGold.Location = new Point(118, 179);
            lblGold.Name = "lblGold";
            lblGold.Size = new Size(50, 15);
            lblGold.TabIndex = 5;
            lblGold.Text = "2천만원";
            // 
            // btnReg
            // 
            btnReg.Location = new Point(5, 210);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(75, 23);
            btnReg.TabIndex = 6;
            btnReg.Text = "수배";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += button_Click;
            // 
            // btnIdle
            // 
            btnIdle.Location = new Point(86, 210);
            btnIdle.Name = "btnIdle";
            btnIdle.Size = new Size(75, 23);
            btnIdle.TabIndex = 7;
            btnIdle.Text = "정지";
            btnIdle.UseVisualStyleBackColor = true;
            btnIdle.Click += button_Click;
            // 
            // btnCatch
            // 
            btnCatch.Location = new Point(167, 210);
            btnCatch.Name = "btnCatch";
            btnCatch.Size = new Size(75, 23);
            btnCatch.TabIndex = 8;
            btnCatch.Text = "잡힘";
            btnCatch.UseVisualStyleBackColor = true;
            btnCatch.Click += button_Click;
            // 
            // UCInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(btnCatch);
            Controls.Add(btnIdle);
            Controls.Add(btnReg);
            Controls.Add(lblGold);
            Controls.Add(lblName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pboxFace);
            Controls.Add(lblNo);
            Name = "UCInfo";
            Size = new Size(247, 256);
            ((System.ComponentModel.ISupportInitialize)pboxFace).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNo;
        private PictureBox pboxFace;
        private Label label1;
        private Label label2;
        private Label lblName;
        private Label lblGold;
        private Button btnReg;
        private Button btnIdle;
        private Button btnCatch;
    }
}
