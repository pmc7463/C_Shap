﻿namespace Study_2_DataType
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
            this.btnDouble = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.lblShort = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExe = new System.Windows.Forms.Button();
            this.tBoxNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(542, 362);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(200, 59);
            this.btnDouble.TabIndex = 25;
            this.btnDouble.Text = "Double 변환";
            this.btnDouble.UseVisualStyleBackColor = true;
            this.btnDouble.Click += new System.EventHandler(this.btnDouble_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(542, 280);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(200, 59);
            this.btnInt.TabIndex = 24;
            this.btnInt.Text = "Int 변환";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(542, 201);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(200, 59);
            this.btnShort.TabIndex = 23;
            this.btnShort.Text = "Short  변환";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(355, 221);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(18, 18);
            this.lblShort.TabIndex = 22;
            this.lblShort.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(355, 300);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(18, 18);
            this.lblInt.TabIndex = 21;
            this.lblInt.Text = "0";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(355, 382);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(18, 18);
            this.lblDouble.TabIndex = 20;
            this.lblDouble.Text = "0";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(355, 459);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(17, 18);
            this.lblException.TabIndex = 19;
            this.lblException.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Exception";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Double";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Int";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Short";
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(1494, 111);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(200, 59);
            this.btnExe.TabIndex = 14;
            this.btnExe.Text = "알아서 변환";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // tBoxNumber
            // 
            this.tBoxNumber.Location = new System.Drawing.Point(107, 128);
            this.tBoxNumber.Name = "tBoxNumber";
            this.tBoxNumber.Size = new System.Drawing.Size(1323, 28);
            this.tBoxNumber.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1815, 600);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.tBoxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.TextBox tBoxNumber;
    }
}

