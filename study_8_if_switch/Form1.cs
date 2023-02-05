using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace study_8_if_switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnifResult_Click(object sender, EventArgs e)
        {
            int iNumber1 = (int)nNumber1.Value;
            int iNumber2 = (int)nNumber2.Value;

            if (iNumber1 > iNumber2)
            {
                lblifResult.Text = string.Format("- Number1이 Number2보다 {0} 더 큽니다.", iNumber1 - iNumber2);
            }
            else if (iNumber1 < iNumber2)
            {
                lblifResult.Text = string.Format("- Number2이 Number1보다 {0} 더 큽니다.", iNumber2 - iNumber1);
            }
            else
            {
                lblifResult.Text = string.Format("- 두 숫자는 같습니다. 숫자 : {0}", iNumber1);
            }
        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "월":
                    lblswitchResult.Text = "- 선택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "- 선택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "- 선택 날짜는 수요일 입니다.";
                    break;
                case "목":
                    lblswitchResult.Text = "- 선택 날짜는 목요일 입니다.";
                    break;
                case "금":
                    lblswitchResult.Text = "- 선택 날짜는 금요일 입니다.";
                    break;
                case "토":
                case "일":
                    lblswitchResult.Text = "- 선택 날짜는 토요일, 일요일 입니다.";
                    break;
            }
        }
    }
}
