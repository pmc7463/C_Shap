﻿namespace study_11_Struct_Class
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pboxNone = new System.Windows.Forms.PictureBox();
            this.pboxStar = new System.Windows.Forms.PictureBox();
            this.pboxMoon = new System.Windows.Forms.PictureBox();
            this.pboxSun = new System.Windows.Forms.PictureBox();
            this.rdoPlayer1 = new System.Windows.Forms.RadioButton();
            this.rdoPlayer2 = new System.Windows.Forms.RadioButton();
            this.lboxResult1 = new System.Windows.Forms.ListBox();
            this.lboxResult2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lboxNow = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player는 한 번 씩 돌아가면서 그림을 선택 합니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(592, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "각 10회 진행 후 해, 달, 별의 숫자의 합이 가장 높은 사람이 승리 입니다.";
            // 
            // pboxNone
            // 
            this.pboxNone.Image = global::study_11_Struct_Class.Properties.Resources.우주선;
            this.pboxNone.Location = new System.Drawing.Point(958, 155);
            this.pboxNone.Name = "pboxNone";
            this.pboxNone.Size = new System.Drawing.Size(154, 154);
            this.pboxNone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxNone.TabIndex = 5;
            this.pboxNone.TabStop = false;
            this.pboxNone.Click += new System.EventHandler(this.pboxNone_Click);
            // 
            // pboxStar
            // 
            this.pboxStar.Image = global::study_11_Struct_Class.Properties.Resources.별;
            this.pboxStar.Location = new System.Drawing.Point(643, 155);
            this.pboxStar.Name = "pboxStar";
            this.pboxStar.Size = new System.Drawing.Size(154, 154);
            this.pboxStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxStar.TabIndex = 4;
            this.pboxStar.TabStop = false;
            this.pboxStar.Click += new System.EventHandler(this.pboxStar_Click);
            // 
            // pboxMoon
            // 
            this.pboxMoon.Image = global::study_11_Struct_Class.Properties.Resources.달;
            this.pboxMoon.Location = new System.Drawing.Point(344, 155);
            this.pboxMoon.Name = "pboxMoon";
            this.pboxMoon.Size = new System.Drawing.Size(154, 154);
            this.pboxMoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMoon.TabIndex = 3;
            this.pboxMoon.TabStop = false;
            this.pboxMoon.Click += new System.EventHandler(this.pboxMoon_Click);
            // 
            // pboxSun
            // 
            this.pboxSun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pboxSun.Image = global::study_11_Struct_Class.Properties.Resources.free_icon_sun_77146841;
            this.pboxSun.Location = new System.Drawing.Point(45, 155);
            this.pboxSun.Name = "pboxSun";
            this.pboxSun.Size = new System.Drawing.Size(154, 154);
            this.pboxSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxSun.TabIndex = 2;
            this.pboxSun.TabStop = false;
            this.pboxSun.Click += new System.EventHandler(this.pboxSun_Click);
            // 
            // rdoPlayer1
            // 
            this.rdoPlayer1.AutoSize = true;
            this.rdoPlayer1.Location = new System.Drawing.Point(45, 338);
            this.rdoPlayer1.Name = "rdoPlayer1";
            this.rdoPlayer1.Size = new System.Drawing.Size(93, 22);
            this.rdoPlayer1.TabIndex = 8;
            this.rdoPlayer1.TabStop = true;
            this.rdoPlayer1.Text = "Player1";
            this.rdoPlayer1.UseVisualStyleBackColor = true;
            // 
            // rdoPlayer2
            // 
            this.rdoPlayer2.AutoSize = true;
            this.rdoPlayer2.Location = new System.Drawing.Point(673, 338);
            this.rdoPlayer2.Name = "rdoPlayer2";
            this.rdoPlayer2.Size = new System.Drawing.Size(93, 22);
            this.rdoPlayer2.TabIndex = 9;
            this.rdoPlayer2.TabStop = true;
            this.rdoPlayer2.Text = "Player2";
            this.rdoPlayer2.UseVisualStyleBackColor = true;
            // 
            // lboxResult1
            // 
            this.lboxResult1.FormattingEnabled = true;
            this.lboxResult1.ItemHeight = 18;
            this.lboxResult1.Location = new System.Drawing.Point(42, 400);
            this.lboxResult1.Name = "lboxResult1";
            this.lboxResult1.Size = new System.Drawing.Size(571, 220);
            this.lboxResult1.TabIndex = 10;
            // 
            // lboxResult2
            // 
            this.lboxResult2.FormattingEnabled = true;
            this.lboxResult2.ItemHeight = 18;
            this.lboxResult2.Location = new System.Drawing.Point(640, 400);
            this.lboxResult2.Name = "lboxResult2";
            this.lboxResult2.Size = new System.Drawing.Size(571, 220);
            this.lboxResult2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "-상황판";
            // 
            // lboxNow
            // 
            this.lboxNow.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lboxNow.Font = new System.Drawing.Font("굴림", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lboxNow.ForeColor = System.Drawing.SystemColors.Window;
            this.lboxNow.FormattingEnabled = true;
            this.lboxNow.ItemHeight = 28;
            this.lboxNow.Location = new System.Drawing.Point(42, 693);
            this.lboxNow.Name = "lboxNow";
            this.lboxNow.Size = new System.Drawing.Size(1166, 228);
            this.lboxNow.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 936);
            this.Controls.Add(this.lboxNow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lboxResult2);
            this.Controls.Add(this.lboxResult1);
            this.Controls.Add(this.rdoPlayer2);
            this.Controls.Add(this.rdoPlayer1);
            this.Controls.Add(this.pboxNone);
            this.Controls.Add(this.pboxStar);
            this.Controls.Add(this.pboxMoon);
            this.Controls.Add(this.pboxSun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pboxSun;
        private System.Windows.Forms.PictureBox pboxMoon;
        private System.Windows.Forms.PictureBox pboxStar;
        private System.Windows.Forms.PictureBox pboxNone;
        private System.Windows.Forms.RadioButton rdoPlayer1;
        private System.Windows.Forms.RadioButton rdoPlayer2;
        private System.Windows.Forms.ListBox lboxResult1;
        private System.Windows.Forms.ListBox lboxResult2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lboxNow;
    }
}

