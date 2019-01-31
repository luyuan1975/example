namespace file_convert
{
    partial class F_main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.ofd_1 = new System.Windows.Forms.OpenFileDialog();
            this.lb_1 = new System.Windows.Forms.ListBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.fbd_1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_2 = new System.Windows.Forms.ListBox();
            this.btn_3 = new System.Windows.Forms.Button();
            this.cb_1 = new System.Windows.Forms.CheckBox();
            this.tC_1 = new System.Windows.Forms.TabControl();
            this.tp_1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbb_1 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_dur2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_bitrate2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_dur1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_size2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_bitrate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_format = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_duration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_size = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tC_1.SuspendLayout();
            this.tp_1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "源目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(211, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "输出目录";
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(12, 45);
            this.tb_1.Name = "tb_1";
            this.tb_1.ReadOnly = true;
            this.tb_1.Size = new System.Drawing.Size(180, 21);
            this.tb_1.TabIndex = 3;
            // 
            // tb_2
            // 
            this.tb_2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::file_convert.Properties.Settings.Default, "DirTo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_2.Location = new System.Drawing.Point(210, 45);
            this.tb_2.Name = "tb_2";
            this.tb_2.ReadOnly = true;
            this.tb_2.Size = new System.Drawing.Size(180, 21);
            this.tb_2.TabIndex = 4;
            this.tb_2.Text = global::file_convert.Properties.Settings.Default.DirTo;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(59, 14);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(31, 23);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "...";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // ofd_1
            // 
            this.ofd_1.Filter = "视频文件(*.mov,*.wmv)|*.mov;*.wmv";
            this.ofd_1.Multiselect = true;
            this.ofd_1.Title = "请选择要转换的视频文件";
            // 
            // lb_1
            // 
            this.lb_1.FormattingEnabled = true;
            this.lb_1.ItemHeight = 12;
            this.lb_1.Location = new System.Drawing.Point(12, 71);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(180, 172);
            this.lb_1.TabIndex = 5;
            this.lb_1.SelectedIndexChanged += new System.EventHandler(this.lb_1_SelectedIndexChanged);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(274, 14);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(31, 23);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "...";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // fbd_1
            // 
            this.fbd_1.Description = "选择输出目录";
            // 
            // lb_2
            // 
            this.lb_2.ItemHeight = 12;
            this.lb_2.Location = new System.Drawing.Point(210, 71);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(180, 172);
            this.lb_2.TabIndex = 6;
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(280, 253);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(86, 23);
            this.btn_3.TabIndex = 8;
            this.btn_3.Text = "开始转换";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // cb_1
            // 
            this.cb_1.AutoSize = true;
            this.cb_1.Checked = global::file_convert.Properties.Settings.Default.ShowShell;
            this.cb_1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::file_convert.Properties.Settings.Default, "ShowShell", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_1.Location = new System.Drawing.Point(14, 257);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(120, 16);
            this.cb_1.TabIndex = 7;
            this.cb_1.Text = "显示转换信息窗口";
            this.cb_1.UseVisualStyleBackColor = true;
            // 
            // tC_1
            // 
            this.tC_1.Controls.Add(this.tp_1);
            this.tC_1.Controls.Add(this.tabPage2);
            this.tC_1.Location = new System.Drawing.Point(14, 279);
            this.tC_1.Name = "tC_1";
            this.tC_1.SelectedIndex = 0;
            this.tC_1.Size = new System.Drawing.Size(376, 194);
            this.tC_1.TabIndex = 9;
            // 
            // tp_1
            // 
            this.tp_1.Controls.Add(this.groupBox2);
            this.tp_1.Controls.Add(this.groupBox1);
            this.tp_1.Location = new System.Drawing.Point(4, 22);
            this.tp_1.Name = "tp_1";
            this.tp_1.Padding = new System.Windows.Forms.Padding(3);
            this.tp_1.Size = new System.Drawing.Size(368, 168);
            this.tp_1.TabIndex = 0;
            this.tp_1.Text = "视频";
            this.tp_1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbb_1);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_dur2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_bitrate2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_dur1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_size2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(6, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 76);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "新文件";
            // 
            // cbb_1
            // 
            this.cbb_1.FormattingEnabled = true;
            this.cbb_1.Items.AddRange(new object[] {
            "h264",
            "h265"});
            this.cbb_1.Location = new System.Drawing.Point(41, 50);
            this.cbb_1.Name = "cbb_1";
            this.cbb_1.Size = new System.Drawing.Size(69, 20);
            this.cbb_1.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(230, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(11, 12);
            this.label14.TabIndex = 21;
            this.label14.Text = "~";
            // 
            // tb_dur2
            // 
            this.tb_dur2.Location = new System.Drawing.Point(243, 20);
            this.tb_dur2.Name = "tb_dur2";
            this.tb_dur2.Size = new System.Drawing.Size(79, 21);
            this.tb_dur2.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(295, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "k/bs";
            // 
            // tb_bitrate2
            // 
            this.tb_bitrate2.Location = new System.Drawing.Point(219, 50);
            this.tb_bitrate2.Name = "tb_bitrate2";
            this.tb_bitrate2.Size = new System.Drawing.Size(70, 21);
            this.tb_bitrate2.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "码率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 15;
            this.label11.Text = "编码";
            // 
            // tb_dur1
            // 
            this.tb_dur1.Location = new System.Drawing.Point(155, 20);
            this.tb_dur1.Name = "tb_dur1";
            this.tb_dur1.Size = new System.Drawing.Size(71, 21);
            this.tb_dur1.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "时长";
            // 
            // tb_size2
            // 
            this.tb_size2.Location = new System.Drawing.Point(41, 20);
            this.tb_size2.Name = "tb_size2";
            this.tb_size2.Size = new System.Drawing.Size(70, 21);
            this.tb_size2.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "尺寸";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_bitrate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_code);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_format);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_duration);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_size);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "原文件";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(296, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "k/bs";
            // 
            // tb_bitrate
            // 
            this.tb_bitrate.Location = new System.Drawing.Point(220, 53);
            this.tb_bitrate.Name = "tb_bitrate";
            this.tb_bitrate.ReadOnly = true;
            this.tb_bitrate.Size = new System.Drawing.Size(70, 21);
            this.tb_bitrate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "码率";
            // 
            // tb_code
            // 
            this.tb_code.Location = new System.Drawing.Point(41, 50);
            this.tb_code.Name = "tb_code";
            this.tb_code.ReadOnly = true;
            this.tb_code.Size = new System.Drawing.Size(69, 21);
            this.tb_code.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "编码";
            // 
            // tb_format
            // 
            this.tb_format.Location = new System.Drawing.Point(255, 23);
            this.tb_format.Name = "tb_format";
            this.tb_format.ReadOnly = true;
            this.tb_format.Size = new System.Drawing.Size(74, 21);
            this.tb_format.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "格式";
            // 
            // tb_duration
            // 
            this.tb_duration.Location = new System.Drawing.Point(139, 23);
            this.tb_duration.Name = "tb_duration";
            this.tb_duration.ReadOnly = true;
            this.tb_duration.Size = new System.Drawing.Size(79, 21);
            this.tb_duration.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "时长";
            // 
            // tb_size
            // 
            this.tb_size.Location = new System.Drawing.Point(41, 23);
            this.tb_size.Name = "tb_size";
            this.tb_size.ReadOnly = true;
            this.tb_size.Size = new System.Drawing.Size(61, 21);
            this.tb_size.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "尺寸";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "音频";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // F_main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.tC_1);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::file_convert.Properties.Settings.Default, "WindowLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = global::file_convert.Properties.Settings.Default.WindowLocation;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频文件转换";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.F_main_FormClosing);
            this.Load += new System.EventHandler(this.F_main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.tC_1.ResumeLayout(false);
            this.tp_1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.OpenFileDialog ofd_1;
        private System.Windows.Forms.ListBox lb_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.FolderBrowserDialog fbd_1;
        private System.Windows.Forms.ListBox lb_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.CheckBox cb_1;
        private System.Windows.Forms.TabControl tC_1;
        private System.Windows.Forms.TabPage tp_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_dur2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_bitrate2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_dur1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_size2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_bitrate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_format;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_duration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_1;
    }
}

