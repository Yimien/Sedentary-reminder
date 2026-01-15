using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Reminder
{
    public partial class MainFrm : Form
    {
        WorkFrm? wrkFrm;
        private Button btn_stop;
        public MainFrm()
        {
            InitializeComponent();
            btn_stop = new Button();
            btn_stop.BackColor = Color.Transparent;
            btn_stop.FlatAppearance.BorderColor = Color.DimGray;
            btn_stop.FlatStyle = FlatStyle.Flat;
            btn_stop.Location = btn_start.Location;
            btn_stop.Size = btn_start.Size;
            btn_stop.Text = "停止";
            btn_stop.ForeColor = Color.Red;
            btn_stop.UseVisualStyleBackColor = false;
            btn_stop.Visible = false;
            btn_stop.Click += Btn_stop_Click;
            this.Controls.Add(btn_stop);
        }

        private static bool IsAutoStartEnabled()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", false))
            {
                return key != null && key.GetValue("Reminder") != null;
            }
        }

        private static void SetAutoStart(bool enable)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true))
            {
                if (enable)
                {
                    key.SetValue("Reminder", Application.ExecutablePath);
                }
                else
                {
                    key.DeleteValue("Reminder", false);
                }
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // Load user settings
            // Ensure values are within bounds
            numWrkTime.Value = Math.Max(Properties.Settings.Default.WorkTime, (int)numWrkTime.Minimum);
            numRstTime.Value = Math.Max(Properties.Settings.Default.RestTime, (int)numRstTime.Minimum);
            numStandTime.Value = Math.Max(Properties.Settings.Default.StandTime, (int)numStandTime.Minimum);
            ckBoxInput.Checked = Properties.Settings.Default.BlockInput;
            ckBoxAutoStart.Checked = IsAutoStartEnabled();
            ckBoxAutoStart.CheckedChanged += CkBoxAutoStart_CheckedChanged;
            UpdateButtonVisibility();
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
            btn_start.Visible = false;
            btn_stop.Visible = true;

        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form is WorkFrm || form is RestFrm || form is StandFrm)
                {
                    form.Close();
                }
            }
            btn_stop.Visible = false;
            btn_start.Visible = true;
        }

        private void UpdateButtonVisibility()
        {
            bool hasTimerForm = false;
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form is WorkFrm || form is RestFrm || form is StandFrm)
                {
                    hasTimerForm = true;
                    break;
                }
            }
            if (hasTimerForm)
            {
                btn_stop.Visible = true;
                btn_start.Visible = false;
            }
            else
            {
                btn_stop.Visible = false;
                btn_start.Visible = true;
            }
        }

        private void 主窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            UpdateButtonVisibility();

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

        private void CkBoxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            SetAutoStart(ckBoxAutoStart.Checked);
        }
    }
}
