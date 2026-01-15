namespace Reminder
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_start = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            label6 = new Label();
            numWrkTime = new NumericUpDown();
            numRstTime = new NumericUpDown();
            label7 = new Label();
            numStandTime = new NumericUpDown();
            label8 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            主窗体ToolStripMenuItem = new ToolStripMenuItem();
            关于ToolStripMenuItem = new ToolStripMenuItem();
            exit_ToolStripMenuItem = new ToolStripMenuItem();
            label4 = new Label();
            ckBoxInput = new CheckBox();
            ckBoxAutoStart = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numWrkTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRstTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStandTime).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 39);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 0;
            label1.Text = "坐姿工作时间：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(14, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 14);
            label2.TabIndex = 3;
            label2.Text = "计时器：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 17);
            label3.TabIndex = 5;
            label3.Text = "休息活动时间：";
            // 
            // btn_start
            // 
            btn_start.BackColor = Color.Transparent;
            btn_start.FlatAppearance.BorderColor = Color.DimGray;
            btn_start.FlatStyle = FlatStyle.Flat;
            btn_start.Location = new Point(79, 225);
            btn_start.Margin = new Padding(4);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(88, 33);
            btn_start.TabIndex = 11;
            btn_start.Text = "开始";
            btn_start.UseVisualStyleBackColor = false;
            btn_start.Click += Btn_start_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 40);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 17);
            label5.TabIndex = 14;
            label5.Text = "（分钟）";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(180, 110);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 17);
            label6.TabIndex = 15;
            label6.Text = "（秒）";
            // 
            // numWrkTime
            // 
            numWrkTime.BorderStyle = BorderStyle.FixedSingle;
            numWrkTime.Location = new Point(122, 35);
            numWrkTime.Margin = new Padding(4);
            numWrkTime.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numWrkTime.Name = "numWrkTime";
            numWrkTime.Size = new Size(59, 23);
            numWrkTime.TabIndex = 16;
            numWrkTime.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // numRstTime
            // 
            numRstTime.BackColor = Color.White;
            numRstTime.BorderStyle = BorderStyle.FixedSingle;
            numRstTime.Location = new Point(122, 107);
            numRstTime.Margin = new Padding(4);
            numRstTime.Maximum = new decimal(new int[] { 600, 0, 0, 0 });
            numRstTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRstTime.Name = "numRstTime";
            numRstTime.Size = new Size(59, 23);
            numRstTime.TabIndex = 17;
            numRstTime.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 74);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 17);
            label7.TabIndex = 20;
            label7.Text = "站立工作时间：";
            // 
            // numStandTime
            // 
            numStandTime.BackColor = Color.White;
            numStandTime.BorderStyle = BorderStyle.FixedSingle;
            numStandTime.Location = new Point(122, 71);
            numStandTime.Margin = new Padding(4);
            numStandTime.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numStandTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numStandTime.Name = "numStandTime";
            numStandTime.Size = new Size(59, 23);
            numStandTime.TabIndex = 21;
            numStandTime.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(180, 75);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(56, 17);
            label8.TabIndex = 22;
            label8.Text = "（分钟）";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Reminder";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackgroundImageLayout = ImageLayout.Center;
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 主窗体ToolStripMenuItem, 关于ToolStripMenuItem, exit_ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(113, 70);
            // 
            // 主窗体ToolStripMenuItem
            // 
            主窗体ToolStripMenuItem.Name = "主窗体ToolStripMenuItem";
            主窗体ToolStripMenuItem.Size = new Size(112, 22);
            主窗体ToolStripMenuItem.Text = "首选项";
            主窗体ToolStripMenuItem.Click += 主窗体ToolStripMenuItem_Click;
            // 
            // 关于ToolStripMenuItem
            // 
            关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            关于ToolStripMenuItem.Size = new Size(112, 22);
            关于ToolStripMenuItem.Text = "关于";
            关于ToolStripMenuItem.Click += 关于ToolStripMenuItem_Click;
            // 
            // exit_ToolStripMenuItem
            // 
            exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            exit_ToolStripMenuItem.Size = new Size(112, 22);
            exit_ToolStripMenuItem.Text = "退出";
            exit_ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("宋体", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(14, 139);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 14);
            label4.TabIndex = 18;
            label4.Text = "选项：";
            // 
            // ckBoxInput
            // 
            ckBoxInput.AutoSize = true;
            ckBoxInput.Checked = true;
            ckBoxInput.CheckState = CheckState.Checked;
            ckBoxInput.Location = new Point(34, 169);
            ckBoxInput.Margin = new Padding(4);
            ckBoxInput.Name = "ckBoxInput";
            ckBoxInput.Size = new Size(147, 21);
            ckBoxInput.TabIndex = 19;
            ckBoxInput.Text = "休息时屏蔽键盘和鼠标";
            ckBoxInput.UseVisualStyleBackColor = true;
            //
            // ckBoxAutoStart
            //
            ckBoxAutoStart.AutoSize = true;
            ckBoxAutoStart.Location = new Point(34, 195);
            ckBoxAutoStart.Margin = new Padding(4);
            ckBoxAutoStart.Name = "ckBoxAutoStart";
            ckBoxAutoStart.Size = new Size(95, 21);
            ckBoxAutoStart.TabIndex = 20;
            ckBoxAutoStart.Text = "开机自启动";
            ckBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(248, 270);
            Controls.Add(ckBoxAutoStart);
            Controls.Add(ckBoxInput);
            Controls.Add(label4);
            Controls.Add(numRstTime);
            Controls.Add(numWrkTime);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(numStandTime);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_start);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sedentary Reminder";
            TopMost = true;
            FormClosing += MainFrm_FormClosing;
            Load += MainFrm_Load;
            ((System.ComponentModel.ISupportInitialize)numWrkTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRstTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStandTime).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_start;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numWrkTime;
        private System.Windows.Forms.NumericUpDown numRstTime;
        protected System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主窗体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckBoxInput;
        private System.Windows.Forms.CheckBox ckBoxAutoStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numStandTime;
        private System.Windows.Forms.Label label8;
    }
}