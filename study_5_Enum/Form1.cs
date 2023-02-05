using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        enum enumDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        enum enumTime
        {
            Morning,
            Afternoon,
            Evening,
        }

        private void Form1_Load(object sender, EventArgs e)    //폼이 로딩 될 때
        {
            lboxDay.Items.Add(enumDay.Monday.ToString());
            lboxDay.Items.Add(enumDay.Tuesday);
            lboxDay.Items.Add(enumDay.Wednesday);
            lboxDay.Items.Add(enumDay.Thursday);
            lboxDay.Items.Add(enumDay.Friday);
            lboxDay.Items.Add(enumDay.Saturday);
            lboxDay.Items.Add(enumDay.Sunday);

            lboxTime.Items.Add(enumTime.Morning);
            lboxTime.Items.Add(enumTime.Afternoon);
            lboxTime.Items.Add(enumTime.Evening);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            // 민철님이 Monday Afternoon에 예약 했습니다.
            string strResult = tboxName.Text + "님이 " + lboxDay.SelectedItem.ToString() + " " + lboxTime.SelectedItem.ToString() + "에 예약 했습니다.";

            tboxResult.Text = strResult;

        }
        
        private void btnResult2_Click(object sender, EventArgs e)
        {
            //string strResult = string.Format("{0} 님이 {1} {2}에 예약 했습니다.", tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            string strResult = TextLoad(tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());

            tboxResult.Text = strResult;
        }
        /// <summary>
        /// 00님이 요일 시간에 예약 했습니다.
        /// </summary>
        /// <param name="strName">이름</param>
        /// <param name="strDay">요일</param>
        /// <param name="strTime">시간</param>
        /// <returns>합친 문자들을 출력합니다.</returns>
        private string TextLoad(string strName, string strDay, string strTime)
        {
            string strText = string.Format("{0} 님이 {1} {2}에 예약 했습니다.", strName, strDay, strTime);

            return strText;
        }
    }
}
