using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Reminder
{
    public partial class RestFrm : Form
    {
        private int rst_m;//总秒数
        private int wrk_m;
        private int rst_m2;//备份总秒数
        private bool input_flag;

        public RestFrm()
        {
            InitializeComponent();
        }
        public RestFrm(int rst_seconds,int wrk_minutes, bool input_flag)
        {
            InitializeComponent();
            this.rst_m = rst_seconds;
            this.wrk_m = wrk_minutes;
            this.rst_m2 = rst_seconds;
            this.input_flag = input_flag;
        }
        
        private void RestFrm_Load(object sender, EventArgs e)
        {           
            if (input_flag)
            {
                lblText.Text = "您已久坐" + wrk_m.ToString() + "分钟了，键盘和鼠标被锁定，站起来活动下！";
            }
            else
            {
                lblText.Text = "您已久坐" + wrk_m.ToString() + "分钟了，站起来活动下！Alt+F4 退出本界面。";
            }

            //lblText.Text = "您已久坐60分钟了，键盘和鼠标被锁定，站起来活动下！";

            timerRst.Enabled = true;            
            this.TopMost = true;
           
            this.WindowState = FormWindowState.Maximized;
            this.Opacity = 0.75;
            if (input_flag)
            {
                KeyboardBlocker.off();//锁定键盘               
            }

            // 计算分钟和秒
            int minutes = rst_m / 60;
            int seconds = rst_m % 60;

            if (seconds >= 10)
            {
                lbl_seconds.Text = seconds.ToString();
            }
            else
            {
                lbl_seconds.Text = "0" + seconds.ToString();
            }

            if (minutes >= 10)
            {
                lbl_minutes.Text = minutes.ToString();
            }
            else
            {
                lbl_minutes.Text = "0" + minutes.ToString();
            }
            
            

        }

        private void TimerRst_Tick(object sender, EventArgs e)
        {
            timing();
        }

        private void timing()
        {
            rst_m--;

            // 计算并更新显示分钟和秒
            int minutes = rst_m / 60;
            int seconds = rst_m % 60;

            if (seconds >= 10)
            {
                lbl_seconds.Text = seconds.ToString();
            }
            else
            {
                lbl_seconds.Text = "0" + seconds.ToString();
            }

            if (minutes >= 10)
            {
                lbl_minutes.Text = minutes.ToString();
            }
            else
            {
                lbl_minutes.Text = "0" + minutes.ToString();
            }

            if (rst_m <= 0)
            {
                timerRst.Enabled = false;

                if (input_flag)
                {
                    KeyboardBlocker.on();//解锁键盘
                }

                WorkFrm workFrm = new WorkFrm(wrk_m, rst_m2, input_flag);
                workFrm.Show();
                this.Close();
            }
        }

        private void RestFrm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void RestFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //WorkFrm workFrm = new WorkFrm(wrk_m, rst_m2, input_flag);
           // workFrm.Show();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
    }
}
