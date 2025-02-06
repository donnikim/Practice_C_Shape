
namespace _34_Study_Layout_Event
{
    partial class ucColorMenu
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
            flpMenu = new FlowLayoutPanel();
            label1 = new Label();
            pcolor = new Panel();
            cDialogColor = new ColorDialog();
            flpMenu.SuspendLayout();
            SuspendLayout();
            // 
            // flpMenu
            // 
            flpMenu.BackColor = SystemColors.ActiveCaptionText;
            flpMenu.Controls.Add(label1);
            flpMenu.Controls.Add(pcolor);
            flpMenu.Dock = DockStyle.Fill;
            flpMenu.Location = new Point(0, 0);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(128, 460);
            flpMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(10, 10, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Color Select";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcolor
            // 
            pcolor.BackColor = SystemColors.Control;
            pcolor.Location = new Point(10, 45);
            pcolor.Margin = new Padding(10, 10, 0, 0);
            pcolor.Name = "pcolor";
            pcolor.Size = new Size(100, 25);
            pcolor.TabIndex = 1;
            pcolor.MouseClick += PColor_MouseClick;
            // 
            // ucColorMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpMenu);
            Name = "ucColorMenu";
            Size = new Size(128, 460);
            Load += ucColorMenu_Load;
            flpMenu.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private FlowLayoutPanel flpMenu;
        private Label label1;
        private Panel pcolor;
        private ColorDialog cDialogColor;
    }
}
