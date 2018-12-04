using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Sunshine_Calculater.Forms;

namespace Sunshine_Calculater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormClosing += MainForm_FormClosing;
            button_Midtime.Click += button_Click;
            button_Direction.Click += button_Click;
            button_Timelength.Click += button_Click;
            button_Risetime.Click += button_Click;
            button_Help.Click += button_Click;
        }
        
        //设计主窗体关闭时的提示
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出Sunshine_Calculater？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;  //关闭窗体
            }
        }
        
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Form fm = null;
            switch (btn.Text)
            {
                case "查询正午时间":
                    fm = new Mid_suntime();
                    break;
                case "查询太阳角":
                    fm = new Direction();
                    break;
                case "查询日照时长":
                    fm = new Timelength();
                    break;
                case "查询日出日落时间":
                    fm = new Risetime();
                    break;
                case "帮助":
                    fm = new Info();
                    break;

            }
            if (fm != null)
            {
                fm.Owner = this;
                fm.StartPosition = FormStartPosition.CenterParent;
                fm.ShowDialog(this);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Midtime_Click(object sender, EventArgs e)
        {

        }

        private void button_Direction_Click(object sender, EventArgs e)
        {

        }

        private void button_Timelength_Click(object sender, EventArgs e)
        {

        }

        private void button_Risetime_Click(object sender, EventArgs e)
        {

        }

        private void button_Help_Click(object sender, EventArgs e)
        {

        }
    }
}
