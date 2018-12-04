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
    public partial class Risetime : Form
    {
        double Month, Day, Weidu, Jindu;
        string City;
        public Risetime()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox4.TextChanged += textBox4_TextChanged;
        }

        private void Risetime_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            textBoxInfo.Text = "";
            Getmonth();
            Getday();
            Getweidu();
            Getjindu();
            if (Weidu == -1000 || Jindu == -1000)
            {
                foreach (var v in groupBoxCity.Controls)
                {
                    RadioButton r = v as RadioButton;
                    if (r.Checked == true)
                    {
                        SelectCity(r.Name);
                        textBoxInfo.Text = "您选择了城市： " + City + "；\n";
                        calculate(Month, Day, Weidu, Jindu);
                    }
                }
                if (Weidu == -1000 || Jindu == -1000)
                {
                    textBoxInfo.Text = "请选择城市或正确输入经纬度！";
                    return;
                }
            }
            else calculate(Month, Day, Weidu, Jindu);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Getmonth();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Getday();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Getweidu();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Getjindu();
        }
        private void Getmonth()
        {
            if (double.TryParse(textBox1.Text, out Month) == false) { Month = 1; }
        }
        private void Getday()
        {
            if (double.TryParse(textBox2.Text, out Day) == false) { Day = 1; }
        }
        private void Getweidu()
        {
            if (double.TryParse(textBox3.Text, out Weidu) == false) { Weidu = -1000; }
        }
        private void Getjindu()
        {
            if (double.TryParse(textBox4.Text, out Jindu) == false) { Jindu = -1000; }
        }
        private void SelectCity(string name)
        {
            switch (name)
            {
                case "RBSH":
                    City = "上海"; Jindu = 121.26; Weidu = 31.12; break;
                case "RBSZ":
                    City = "深圳"; Jindu = 114.07; Weidu = 22.62; break;
                case "RBBJ":
                    City = "北京"; Jindu = 116.19; Weidu = 39.57; break;
                case "RBGZ":
                    City = "广州"; Jindu = 113.13; Weidu = 23.00; break;
                case "RBDJ":
                    City = "东京"; Jindu = 139.46; Weidu = 35.42; break;
                case "RBNY":
                    City = "纽约"; Jindu = -74; Weidu = 40.43; break;
                case "RBBL":
                    City = "巴黎"; Jindu = 2.20; Weidu = 42.51; break;
                case "RBMSK":
                    City = "莫斯科"; Jindu = 37.37; Weidu = 55.45; break;
                case "RBCS":
                    City = "长沙"; Jindu = 112.5; Weidu = 28.15; break;
                case "RBJN":
                    City = "济南"; Jindu = 116.58; Weidu = 36.11; break;
                case "RBLS":
                    City = "拉萨"; Jindu = 91.02; Weidu = 29.13; break;
                case "RBHEB":
                    City = "哈尔滨"; Jindu = 126.38; Weidu = 45.45; break;
                default:
                    textBoxInfo.Text = "请选择城市或正确输入纬度！"; break;
            }
        }
        private void calculate(double month, double day, double weidu, double jindu)
        {
            //时差E表格
            int[,] a ={
                { -3,-5,-7,-8,-10,-11,-12,-13},
                {-13,-14,-14,-14,-14,-14,-13,0 },
                { -13,-12,-11,-10,-9,-8,-6,-5},
                { -4,-3,-2,-1,0,1,2,3},
                { 3,3,4,4,4,4,3,3},
                { 2,2,1,0,-1,-1,-2,-3},
                { -4,-4,-5,-6,-6,-6,-6,-6,},
                { -6,-6,-6,-5,-4,-3,-2,-1},
                { 0,1,2,4,5,7,8,9},
                {10,11,12,13,14,15,16,16 },
                {16,16,16,16,15,14,13,12 },
                { 11,10,8,6,4,2,0,-1},
            };
            //赤纬表格
            double[,] b =
            {
                { -23.1,-22.7,-22.2,-21.6,-20.9,-20.1,-19.2,-18.2 },
                { -17.3,-16.2,-14.9,-13.7,-12.3,-10.9,-9.4,0},
                { -7.9,-6.4,-4.8,-3.3,-1.7,-0.1,1.5,3},
                { 4.2,5.8,7.3,8.7,10.2,11.6,12.9,14.2},
                { 14.8,16,17.1,18.2,19.1,20,20.8,21.5 },
                { 21.9,22.5,21.9,23.2,23.4,23.4,23.4,23.3 },
                { 23.2,22.9,22.5,21.9,21.3,20.6,19.8,19},
                { 18.2,17.2,16.1,14.9,13.7,12.4,11.1,9.7},
                { 8.6,7.1,5.6,4.1,2.6,1,-0.5,-2.1},
                { -2.9,-4.4,-5.9,-7.5,-8.9,-10.4,-11.8,-13.2},
                { -14.2,-15.4,-16.6,-17.7,-18.8,-19.7,-20.6,-21.3},
                { -21.7,-22.3,-22.7,-23.1,-23.3,-23.4,-23.4,-23.3}
            };
            if (jindu>180 || jindu<-180 || weidu > 90 || weidu < -90 || month > 12 || month < 0 || day > 31 || day < 0)
            {
                textBoxInfo.Text = "请正确输入时间和经纬度！";
                return;
            }
            //计算赤纬和时角,m为中间值,N为日照时长
            double chiwei, m, shijiao, N;
            int shi, fen;
            int r1 = (int)((day - 1) / 4); int r2 = (int)((day - 1) % 4);
            int mon = (int)month;
            chiwei = b[mon - 1, r1] + r2 / 4 * (b[mon - 1, r1 + 1] - b[mon - 1, r1]);
            if ((Math.Abs(weidu + chiwei)) > 90)
            {
                shi = 24; fen = 0;
                textBoxInfo.Text = textBoxInfo.Text + "该地当天的日照时长为： 24小时。";
            }
            else if ((Math.Abs(weidu - chiwei)) > 90)
            {
                shi = 0; fen = 0;
                textBoxInfo.Text = textBoxInfo.Text + "该地当天的日照时长为： 0小时。";
            }
            else
            {
                m = -(Math.Tan(weidu * Math.PI / 180)) * (Math.Tan(chiwei * Math.PI / 180));
                shijiao = (Math.Abs(((Math.Acos(m)) / Math.PI * 180))) % 180;
                N = 2 * shijiao / 15;
                shi = (int)N;
                fen = (int)(((N * 60) % 60)+0.5);
                textBoxInfo.Text = textBoxInfo.Text + "该地当天的日照时长为： " + shi + "小时 " + fen + "分钟。\n";
                
                //计算日出日落时间
                double e, sunrise_zhenshi, sunrise_beishi, sundown_zhenshi, sundown_beishi;
                e = a[mon - 1, r1] + r2 / 4 * (a[mon - 1, r1 + 1] - a[mon - 1, r1]);
                sunrise_zhenshi = 12 - N / 2; sundown_zhenshi = 12 + N / 2;
                sunrise_beishi = sunrise_zhenshi - e / 60 + (120 - jindu) / 15;
                sundown_beishi = sundown_zhenshi - e / 60 + (120 - jindu) / 15;

                int sunrise_shi = ((int)sunrise_beishi)%24;
                int sunrise_fen = (int)(((sunrise_beishi * 60) % 60)+0.5);
                textBoxInfo.Text = textBoxInfo.Text + "该地当天的日出时间为： " + sunrise_shi + "时 " + sunrise_fen + "分。\n";

                int sundown_shi = ((int)sundown_beishi)%24;
                int sundown_fen = (int)(((sundown_beishi * 60) % 60)+0.5);
                textBoxInfo.Text = textBoxInfo.Text + "该地当天的日落时间为： " + sundown_shi + "时 " + sundown_fen + "分。";
            }
            return;
        }
    }
}
