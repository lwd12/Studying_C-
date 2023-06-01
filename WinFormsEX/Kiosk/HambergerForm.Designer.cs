namespace Kiosk
{
    partial class HambergerForm
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
            this.bulgogi = new System.Windows.Forms.RadioButton();
            this.doublebulgogi = new System.Windows.Forms.RadioButton();
            this.cheese = new System.Windows.Forms.RadioButton();
            this.doublecheese = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bulgogi
            // 
            this.bulgogi.AutoSize = true;
            this.bulgogi.Location = new System.Drawing.Point(290, 215);
            this.bulgogi.Name = "bulgogi";
            this.bulgogi.Size = new System.Drawing.Size(61, 19);
            this.bulgogi.TabIndex = 0;
            this.bulgogi.TabStop = true;
            this.bulgogi.Text = "불고기";
            this.bulgogi.UseVisualStyleBackColor = true;
            this.bulgogi.CheckedChanged += new System.EventHandler(this.bulgogi_CheckedChanged);
            // 
            // doublebulgogi
            // 
            this.doublebulgogi.AutoSize = true;
            this.doublebulgogi.Location = new System.Drawing.Point(87, 215);
            this.doublebulgogi.Name = "doublebulgogi";
            this.doublebulgogi.Size = new System.Drawing.Size(89, 19);
            this.doublebulgogi.TabIndex = 1;
            this.doublebulgogi.TabStop = true;
            this.doublebulgogi.Text = "더블 불고기";
            this.doublebulgogi.UseVisualStyleBackColor = true;
            this.doublebulgogi.CheckedChanged += new System.EventHandler(this.doublebulgogi_CheckedChanged);
            // 
            // cheese
            // 
            this.cheese.AutoSize = true;
            this.cheese.Location = new System.Drawing.Point(207, 215);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(49, 19);
            this.cheese.TabIndex = 2;
            this.cheese.TabStop = true;
            this.cheese.Text = "치즈";
            this.cheese.UseVisualStyleBackColor = true;
            this.cheese.CheckedChanged += new System.EventHandler(this.cheese_CheckedChanged);
            // 
            // doublecheese
            // 
            this.doublecheese.AutoSize = true;
            this.doublecheese.Location = new System.Drawing.Point(382, 215);
            this.doublecheese.Name = "doublecheese";
            this.doublecheese.Size = new System.Drawing.Size(77, 19);
            this.doublecheese.TabIndex = 3;
            this.doublecheese.TabStop = true;
            this.doublecheese.Text = "더블 치즈";
            this.doublecheese.UseVisualStyleBackColor = true;
            this.doublecheese.CheckedChanged += new System.EventHandler(this.doublecheese_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(50, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(450, 250);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HambergerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.doublecheese);
            this.Controls.Add(this.cheese);
            this.Controls.Add(this.doublebulgogi);
            this.Controls.Add(this.bulgogi);
            this.Controls.Add(this.textBox1);
            this.Name = "HambergerForm";
            this.Size = new System.Drawing.Size(621, 578);
            this.Load += new System.EventHandler(this.HambergerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton bulgogi;
        private System.Windows.Forms.RadioButton doublebulgogi;
        private System.Windows.Forms.RadioButton cheese;
        private System.Windows.Forms.RadioButton doublecheese;
        private System.Windows.Forms.TextBox textBox1;
    }
}
