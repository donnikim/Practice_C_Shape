namespace _32_Study_AssemblyVersion
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
            gbox = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnControl = new Button();
            listBox1 = new ListBox();
            gbox.SuspendLayout();
            SuspendLayout();
            // 
            // gbox
            // 
            gbox.Controls.Add(label2);
            gbox.Controls.Add(label1);
            gbox.Controls.Add(button5);
            gbox.Controls.Add(button4);
            gbox.Controls.Add(button3);
            gbox.Controls.Add(button2);
            gbox.Location = new Point(21, 23);
            gbox.Name = "gbox";
            gbox.Size = new Size(451, 185);
            gbox.TabIndex = 0;
            gbox.TabStop = false;
            gbox.Text = "groupBox1";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(341, 73);
            label2.Name = "label2";
            label2.Size = new Size(39, 99);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(124, 133);
            label1.Name = "label1";
            label1.Size = new Size(167, 19);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // button5
            // 
            button5.Location = new Point(43, 80);
            button5.Name = "button5";
            button5.Size = new Size(35, 92);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(307, 32);
            button4.Name = "button4";
            button4.Size = new Size(73, 20);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(142, 22);
            button3.Name = "button3";
            button3.Size = new Size(80, 91);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(20, 32);
            button2.Name = "button2";
            button2.Size = new Size(116, 42);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnControl
            // 
            btnControl.Location = new Point(328, 214);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(144, 33);
            btnControl.TabIndex = 1;
            btnControl.Text = "확인";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 257);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(451, 169);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(listBox1);
            Controls.Add(btnControl);
            Controls.Add(gbox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Title";
            Load += Form1_Load;
            gbox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbox;
        private Label label2;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnControl;
        private ListBox listBox1;
    }
}
