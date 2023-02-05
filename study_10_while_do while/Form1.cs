using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_10_while_do_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwhileResult_Click(object sender, EventArgs e)
        {
            // 1 ~ 45 6개의 번호

            int[] iArray = new int[6];
            int iCount = 0;

            StringBuilder sb = new StringBuilder();
            Random rd = new Random();

            // iArray가 다 안차면 계속 진행
            while (Array.IndexOf(iArray, 0) != -1)
            {
                int iNumber = rd.Next(1, 46);   // 1 <= x < 46

                if (Array.IndexOf(iArray, iNumber) == -1)
                {
                    iArray[iCount] = iNumber;

                    //sb.Append(string.Format("{0}. ", iNumber));

                    iCount++;
                }    
            }

            Array.Sort(iArray);

            foreach (int iNum in iArray)
            {
                sb.Append(string.Format("{0}. ", iNum));
            }
            // 배열 sort

            lblwhileResult.Text = sb.ToString();
            lboxwhileResult.Items.Add(sb.ToString());
        }

        private void btndowhileResult_Click(object sender, EventArgs e)
        {
            // 1 ~ 100
            Random rd = new Random();

            int iNumer = int.Parse(tboxNumber.Text);

            if (iNumer < 1 || iNumer > 100)
            {
                MessageBox.Show("1~100 사이의 숫자를 지정해 주세요");
                return;
            }

            int iCheckNumer = 0;
            int iCount = 0;

            do
            {
                iCheckNumer = rd.Next(1, 101);  // 1 <= x < 101
                iCount++;
            } while (iNumer != iCheckNumer);

            lbldowhileResult.Text = string.Format("- 뽑은 숫자 {0}을 {1}회만에 찾았습니다.", iNumer, iCount);
        }
    }
}
