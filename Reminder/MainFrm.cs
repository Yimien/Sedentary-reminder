using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reminder
{
    public partial class MainFrm : Form
    {
        WorkFrm? wrkFrm;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // Load user settings
            numWrkTime.Value = Properties.Settings.Default.WorkTime;
            numRstTime.Value = Properties.Settings.Default.RestTime;
            numStandTime.Value = Properties.Settings.Default.StandTime;
            ckBoxInput.Checked = Properties.Settings.Default.BlockInput;
        }
       

        private void Btn_start_Click(object sender, EventArgs e)
        {
            // Save current settings
            Properties.Settings.Default.WorkTime = (int)this.numWrkTime.Value;
            Properties.Settings.Default.RestTime = (int)this.numRstTime.Value;
            Properties.Settings.Default.StandTime = (int)this.numStandTime.Value;
            Properties.Settings.Default.BlockInput = this.ckBoxInput.Checked;
            Properties.Settings.Default.Save();

            bool input_flag = this.ckBoxInput.Checked;

            int wrkTime = (int)this.numWrkTime.Value;
            int rstTime = (int)this.numRstTime.Value;
            int standTime = (int)this.numStandTime.Value;
            wrkFrm = new WorkFrm(wrkTime, rstTime, standTime, input_flag);
            wrkFrm.Show();
            //MainFrm.Visible = false;
            this.Visible = false;

        }

        private void 主窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            if (wrkFrm!=null)
            {
                wrkFrm.Close();
            }
            

        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {            
            //取消关闭窗口
            e.Cancel = true;
            //最小化主窗口
            this.WindowState = FormWindowState.Minimized;
            this.Visible = false;
            //不在系统任务栏显示主窗口图标
            this.ShowInTaskbar = false;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            System.Environment.Exit(0);
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
