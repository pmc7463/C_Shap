using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stuudy_9_for_foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            tbox.Text = string.Empty;

            StringBuilder sb = new StringBuilder();

            int iResult = 0;

            //for (int i = 1; i <= 10; i+=2)
            //{
            //    iResult += i;

            //    sb.Append(string.Format("1에서 {0} 까지 더하면 {1} \r\n", i, iResult));
            //}

            for (int j = 0; j < 5; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    sb.Append(string.Format("{0} 회차 {1} 스테이지 진행 중 ... \r\n", j, k));
                }
            }

            tbox.Text = sb.ToString();
        }

        private void btnforeach_Click(object sender, EventArgs e)
        {
            tbox.Text = string.Empty;

            StringBuilder sb = new StringBuilder(); // 문장을 이어주는 함수

            string[] strArray = { "나연", "정연", "모모", "사나", "지효", "미나", "다현", "쯔위", "채영", };

            int i = 1;

            foreach(var oValue in strArray) 
            {
                sb.Append(string.Format("{0} 선생님은 {1} 반 입니다.\r\n", oValue, i++));
            }
            tbox.Text = sb.ToString();
        }
    }
}
