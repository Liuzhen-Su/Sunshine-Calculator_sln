using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunshine_Calculater.Forms
{
    public partial class Mid_suntime : Form
    {
        public Mid_suntime()
        {
            InitializeComponent();
        }

        private void textBoxJD_TextChanged(object sender, EventArgs e)
        {
            //textBoxInfo.Text = textBoxJD.Text;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            double x;
            if (double.TryParse(textBoxJD.Text, out x) == false)
            {
                textBoxInfo.Text = "经度的范围在[-180,180]之间";
            }
            else if (x < -180 || x > 180)
            {
                textBoxInfo.Text = "经度的范围在[-180,180]之间";
            }
            else
            {
                //labelResult.Text = Calculate(x).ToString();
                textBoxInfo.Text = Calculate(x);
            }
        }
        public string Calculate(double x)
        {
            //int y = (int)x;
            double shi, fen, miao;
            string outcome;
            shi = ((720 + (120 - x) * 4) / 60) % 24;
            int shi2 = (int)shi;
            fen = (720 + (120 - x) * 4) % 60;
            int fen2 = (int)fen;
            miao = ((720 + (120 - x) * 4) % 1) * 60;
            int miao2 = (int)miao;
            outcome = "该地区正午时间是北京时间: " + shi2 + "时 " + fen2 + "分 " + miao2 + "秒";
            return outcome;
        }

        private void buttonSH_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "上海的正午时间是北京时间： 11时 54分 50秒";
        }

        private void buttonSZ_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "深圳的正午时间是北京时间： 12时 24分 0秒";
        }

        private void buttonBJ_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "北京的正午时间是北京时间： 12时 15分 14秒";
        }

        private void buttonGZ_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "广州的正午时间是北京时间： 12时 27分 28秒";
        }

        private void buttonDJ_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "东京的正午时间是北京时间： 10时 42分 14秒";
        }

        private void buttonNY_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "纽约的正午时间是北京时间： 0时 56分 0秒";
        }

        private void buttonBL_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "巴黎的正午时间是北京时间： 19时 51分 12秒";
        }

        private void buttonMSK_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "莫斯科的正午时间是北京时间： 17时 30分 35秒";
        }

        private void buttonCS_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "长沙的正午时间是北京时间： 12时 30分 0秒";
        }

        private void buttonJN_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "济南的正午时间是北京时间： 12时 13分 40秒";
        }

        private void buttonXZ_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "拉萨的正午时间是北京时间： 13时 55分 55秒";
        }

        private void buttonHEB_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "哈尔滨的正午时间是北京时间： 11时 34分 28秒";
        }

        private void Mid_suntime_Load(object sender, EventArgs e)
        {

        }
    }
}
