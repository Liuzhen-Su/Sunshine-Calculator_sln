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
    public partial class Direction : Form
    {
        double Jindu, Weidu,Month,Day,Hour,Min;
        string City;
        public Direction()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox3.TextChanged += textBox3_TextChanged;
            textBox4.TextChanged += textBox4_TextChanged;
            textBox5.TextChanged += textBox5_TextChanged;
            textBox6.TextChanged += textBox6_TextChanged;
            textBox7.TextChanged += textBox7_TextChanged;
            buttonOK.Click += buttonOK_Click;
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            Getweidu();
            Getjindu();
            Getmonth();
            Getday();
            Gethour();
            Getmin();
            //labelResult.Text = "经度和纬度值："+Jindu+"  " + Weidu + "。\n\n";
            if (Jindu == -1000 || Weidu == -1000)
            {
                foreach (var v in groupBoxCity.Controls)
                {
                    RadioButton r = v as RadioButton;
                    if (r.Checked == true)
                    {
                        SelectCity(r.Name);
                        labelResult.Text ="您选择了城市： " + City + "。\n\n";
                        calculate(Month, Day, Hour, Min, Jindu, Weidu);
                    }
                }
                if (Jindu == -1000 || Weidu == -1000)
                {
                    labelResult.Text = "请选择城市或正确输入经纬度！";
                    return;
                }
            }
            else calculate(Month, Day, Hour, Min, Jindu, Weidu);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Getmonth();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Getday();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Gethour();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Getmin();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Getjindu();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Getweidu();
        }
        private void Getmonth()
        {
            if (double.TryParse(textBox2.Text, out Month) == false) { Month = 1; }
        }
        private void Getday()
        {
            if (double.TryParse(textBox3.Text, out Day) == false) { Day = 1; }
        }
        private void Gethour()
        {
            if (double.TryParse(textBox4.Text, out Hour) == false) { Hour = 0; }
        }
        private void Getmin()
        {
            if (double.TryParse(textBox5.Text, out Min) == false) { Min = 0; }
        }
        private void Getweidu()
        {
            if (double.TryParse(textBox7.Text, out Weidu) == false) { Weidu = -1000; }
        }
        private void Getjindu()
        {
            if (double.TryParse(textBox6.Text, out Jindu) == false) { Jindu = -1000; }
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
                    labelResult.Text = "请选择城市或正确输入经纬度！"; break;
            }
            
            
        }
        private void calculate(double month, double day, double hour, double min, double jindu, double weidu)
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
            //太阳赤纬表格
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
            if (jindu>180 || jindu<-180 || weidu>90 || weidu<-90 || month>12 || month<0 || day>31 || day<0 || hour>24 || hour<0 || min>60 || min<0)
            {
                labelResult.Text = "请正确输入时间和经纬度！";
                return;
            }
            labelResult.Text = labelResult.Text +"该地的经度为："+jindu+"度, "+"纬度为："+weidu+"度。\n";
            labelResult.Text = labelResult.Text + "北京时间： "+month+"月 "+day+"日 "+hour+"时 "+min+"分。\n\n";

            //计算平太阳时
            double pinshi, pinfen, zhenshi, zhenfen, e;
            pinshi = (((hour * 60 + min) - 4 * (120 - jindu)) / 60) % 24;
            int pinshi2 = (int)pinshi;
            pinfen = ((hour * 60 + min) - 4 * (120 - jindu)) % 60;
            int pinfen2 = (int)pinfen;
            labelResult.Text = labelResult.Text + "平太阳时为： " + pinshi2 + "时 " + pinfen2 + "分;\n\n";

            //计算真太阳时
            int r1 = (int)((day - 1) / 4); int r2 = (int)((day - 1) % 4);
            int mon = (int)month;
            e = a[mon - 1, r1] + r2 / 4 * (a[mon - 1, r1 + 1] - a[mon - 1, r1]);
            zhenshi = (((hour * 60 + min) - 4 * (120 - jindu) + e) / 60) % 24;
            int zhenshi2 = (int)zhenshi;
            zhenfen = ((hour * 60 + min) - 4 * (120 - jindu) + e) % 60;
            int zhenfen2 = (int)zhenfen;
            labelResult.Text = labelResult.Text + "真太阳时为： " + zhenshi2 + "时 " + zhenfen2 + "分;\n\n";

            //计算正午太阳高度角
            double chiwei, as_mid;
            chiwei = b[mon - 1, r1] + r2 / 4 * (b[mon - 1, r1 + 1] - b[mon - 1, r1]);
            if (weidu >= chiwei) { as_mid = 90 - weidu + chiwei; }
            else { as_mid = 90 + weidu - chiwei; }
            string gaodujiao = as_mid.ToString("f2");
            labelResult.Text = labelResult.Text + "当天的正午太阳高度角为： " + gaodujiao + "度;\n\n";

            //计算任意时刻的太阳高度角
            double shijiao, h, as_any;
            shijiao = (60 * zhenshi + zhenfen - 720) / 4;
            h = (Math.Sin(weidu * Math.PI / 180)) * (Math.Sin(chiwei * Math.PI / 180)) + (Math.Cos(weidu * Math.PI / 180)) * (Math.Cos(chiwei * Math.PI / 180)) * (Math.Cos(shijiao * Math.PI / 180));
            as_any = (Math.Asin(h)) / Math.PI * 180;
            string gaodujiao2 = as_any.ToString("f2");
            labelResult.Text = labelResult.Text + "此时的太阳高度角为：" + gaodujiao2 + "度;\n\n";

            //计算任意时刻的太阳方位角
            double rs, k;
            k = -(Math.Cos(chiwei * Math.PI / 180)) * (Math.Sin(shijiao * Math.PI / 180)) / (Math.Cos(as_any * Math.PI / 180));
            rs = (Math.Asin(k)) / Math.PI * 180;
            string fangweijiao = rs.ToString("f2");
            labelResult.Text = labelResult.Text + "此时的太阳方位角为：" + fangweijiao + "度。";

            return;
        }
        private void Direction_Load(object sender, EventArgs e)
        {

        }
    }
}
