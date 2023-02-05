namespace Enum_5
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
            this.tboxName = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lboxDay = new System.Windows.Forms.ListBox();
            this.lboxTime = new System.Windows.Forms.ListBox();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnResult2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxName
            // 
            this.tboxName.Location = new System.Drawing.Point(47, 44);
            this.tboxName.Name = "tboxName";
            this.tboxName.Size = new System.Drawing.Size(291, 28);
            this.tboxName.TabIndex = 0;
            // 
            // btnResult
            // 
            this.btnResult.AutoSize = true;
            this.btnResult.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.Location = new System.Drawing.Point(47, 490);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(291, 50);
            this.btnResult.TabIndex = 1;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lboxDay
            // 
            this.lboxDay.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lboxDay.FormattingEnabled = true;
            this.lboxDay.ItemHeight = 32;
            this.lboxDay.Location = new System.Drawing.Point(47, 101);
            this.lboxDay.Name = "lboxDay";
            this.lboxDay.Size = new System.Drawing.Size(291, 356);
            this.lboxDay.TabIndex = 3;
            // 
            // lboxTime
            // 
            this.lboxTime.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lboxTime.FormattingEnabled = true;
            this.lboxTime.ItemHeight = 32;
            this.lboxTime.Location = new System.Drawing.Point(362, 101);
            this.lboxTime.Name = "lboxTime";
            this.lboxTime.Size = new System.Drawing.Size(291, 356);
            this.lboxTime.TabIndex = 4;
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(47, 568);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(606, 193);
            this.tboxResult.TabIndex = 5;
            // 
            // btnResult2
            // 
            this.btnResult2.AutoSize = true;
            this.btnResult2.Font = new System.Drawing.Font("굴림", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult2.Location = new System.Drawing.Point(362, 490);
            this.btnResult2.Name = "btnResult2";
            this.btnResult2.Size = new System.Drawing.Size(291, 50);
            this.btnResult2.TabIndex = 6;
            this.btnResult2.Text = "StringFormat Test";
            this.btnResult2.UseVisualStyleBackColor = true;
            this.btnResult2.Click += new System.EventHandler(this.btnResult2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 790);
            this.Controls.Add(this.btnResult2);
            this.Controls.Add(this.tboxResult);
            this.Controls.Add(this.lboxTime);
            this.Controls.Add(this.lboxDay);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.tboxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxName;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.ListBox lboxDay;
        private System.Windows.Forms.ListBox lboxTime;
        private System.Windows.Forms.Button btnResult2;
        private System.Windows.Forms.TextBox tboxResult;
    }
}

