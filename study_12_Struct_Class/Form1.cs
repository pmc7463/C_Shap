using study_12_Struct_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CP = study_12_Struct_Class.CPlayer;

namespace study_11_Struct_Class
{
    public partial class Form1 : Form
    {
        struct structPlayer
        {
            public int iCount;  // Player가 몇회 진행 중인지
            public int iSun;    // 해에 대한 값
            public int iMoon;   // 달에 대한 값
            public int iStar;   // 별에 대한 값
            public int iCardSum;    // 해, 달, 별을 더한 값
        }

        structPlayer _stPlayer1;
        structPlayer _stPlayer2;

        Random _rd = new Random();  // 전역변수

        public Form1()
        {
            InitializeComponent();
        }
       
        private void pboxSun_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
               _stPlayer1.iSun = iNumber;   
            }
            else
            {
                _stPlayer2.iSun = iNumber;
            }

            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iMoon = iNumber;
            }
            else
            {
                _stPlayer2.iMoon = iNumber;
            }
            Result();

        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int iNumber = _rd.Next(1, 21);

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iStar = iNumber;
            }
            else
            {
                _stPlayer2.iStar = iNumber;
            }
            Result();

        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            // 아무 것도 안하고 한 턴을 넘긴다.
            Result();

        }

        private void iCheckedChange()
        {
            if (rdoPlayer1.Checked)
            {
                rdoPlayer2.Checked = true;
            }
            else
            {
                rdoPlayer1.Checked = true;
            }
        }

       study_12_Struct_Class.CPlayer cPlayer = new study_12_Struct_Class.CPlayer();

        private void Result()
        {
            string strResult = string.Empty;

            int iCardSum = 0;

            if (rdoPlayer1.Checked)
            {
                _stPlayer1.iCount++;

                _stPlayer1.iCardSum = cPlayer.CardSun(_stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar);

                strResult = cPlayer.ResultText(_stPlayer1.iCount, _stPlayer1.iSun, _stPlayer1.iMoon, _stPlayer1.iStar, _stPlayer1.iCardSum);

                lboxResult1.Items.Add(strResult);
            }

            else
            {
                _stPlayer2.iCount++;

                _stPlayer2.iCardSum = cPlayer.CardSun(_stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar);

                strResult = cPlayer.ResultText(_stPlayer2.iCount, _stPlayer2.iSun, _stPlayer2.iMoon, _stPlayer2.iStar, _stPlayer2.iCardSum);

                lboxResult2.Items.Add(strResult);
            }

            iCheckedChange();

            if (_stPlayer1.iCount == _stPlayer2.iCount) 
            {
                lboxNow.Items.Add(cPlayer.PlayerPair(_stPlayer1.iCount, _stPlayer1.iCardSum, _stPlayer2.iCardSum));

                if (_stPlayer2.iCount >= 5)
                {
                    lboxNow.Items.Add(cPlayer.PlayerResult(_stPlayer1.iCardSum, _stPlayer2.iCardSum));
                }
            }
        }
    }
}
