namespace study_8_if_switch
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
            this.lblifResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblswitchResult = new System.Windows.Forms.Label();
            this.btnswitchResult = new System.Windows.Forms.Button();
            this.cboxDay = new System.Windows.Forms.ComboBox();
            this.nNumber1 = new System.Windows.Forms.NumericUpDown();
            this.nNumber2 = new System.Windows.Forms.NumericUpDown();
            this.btnifResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(56, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(333, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number2)";
            // 
            // lblifResult
            // 
            this.lblifResult.AutoSize = true;
            this.lblifResult.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblifResult.Location = new System.Drawing.Point(56, 286);
            this.lblifResult.Name = "lblifResult";
            this.lblifResult.Size = new System.Drawing.Size(42, 40);
            this.lblifResult.TabIndex = 2;
            this.lblifResult.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(56, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "요일선택)";
            // 
            // lblswitchResult
            // 
            this.lblswitchResult.AutoSize = true;
            this.lblswitchResult.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblswitchResult.Location = new System.Drawing.Point(56, 577);
            this.lblswitchResult.Name = "lblswitchResult";
            this.lblswitchResult.Size = new System.Drawing.Size(42, 40);
            this.lblswitchResult.TabIndex = 4;
            this.lblswitchResult.Text = "-";
            // 
            // btnswitchResult
            // 
            this.btnswitchResult.AutoSize = true;
            this.btnswitchResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnswitchResult.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnswitchResult.Location = new System.Drawing.Point(623, 463);
            this.btnswitchResult.Name = "btnswitchResult";
            this.btnswitchResult.Size = new System.Drawing.Size(267, 53);
            this.btnswitchResult.TabIndex = 5;
            this.btnswitchResult.Text = "선택요일확인";
            this.btnswitchResult.UseVisualStyleBackColor = true;
            this.btnswitchResult.Click += new System.EventHandler(this.btnswitchResult_Click);
            // 
            // cboxDay
            // 
            this.cboxDay.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxDay.FormattingEnabled = true;
            this.cboxDay.Items.AddRange(new object[] {
            "월",
            "화",
            "수",
            "목",
            "금",
            "토",
            "일"});
            this.cboxDay.Location = new System.Drawing.Point(63, 466);
            this.cboxDay.Name = "cboxDay";
            this.cboxDay.Size = new System.Drawing.Size(121, 48);
            this.cboxDay.TabIndex = 6;
            this.cboxDay.Text = "월";
            // 
            // nNumber1
            // 
            this.nNumber1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nNumber1.Location = new System.Drawing.Point(63, 183);
            this.nNumber1.Name = "nNumber1";
            this.nNumber1.Size = new System.Drawing.Size(193, 53);
            this.nNumber1.TabIndex = 7;
            // 
            // nNumber2
            // 
            this.nNumber2.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nNumber2.Location = new System.Drawing.Point(340, 183);
            this.nNumber2.Name = "nNumber2";
            this.nNumber2.Size = new System.Drawing.Size(193, 53);
            this.nNumber2.TabIndex = 8;
            // 
            // btnifResult
            // 
            this.btnifResult.AutoSize = true;
            this.btnifResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnifResult.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnifResult.Location = new System.Drawing.Point(623, 183);
            this.btnifResult.Name = "btnifResult";
            this.btnifResult.Size = new System.Drawing.Size(267, 53);
            this.btnifResult.TabIndex = 9;
            this.btnifResult.Text = "Number 비교";
            this.btnifResult.UseVisualStyleBackColor = true;
            this.btnifResult.Click += new System.EventHandler(this.btnifResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 660);
            this.Controls.Add(this.btnifResult);
            this.Controls.Add(this.nNumber2);
            this.Controls.Add(this.nNumber1);
            this.Controls.Add(this.cboxDay);
            this.Controls.Add(this.btnswitchResult);
            this.Controls.Add(this.lblswitchResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblifResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nNumber2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblifResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblswitchResult;
        private System.Windows.Forms.Button btnswitchResult;
        private System.Windows.Forms.ComboBox cboxDay;
        private System.Windows.Forms.NumericUpDown nNumber1;
        private System.Windows.Forms.NumericUpDown nNumber2;
        private System.Windows.Forms.Button btnifResult;
    }
}

