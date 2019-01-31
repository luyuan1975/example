using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace file_convert {
    public partial class F_main : Form {
        public F_main() {
/*
            this.AllowDrop = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            file_convert.Properties.Settings.Default.WindowLocation
*/
            InitializeComponent();
            tb_1.Text = Application.StartupPath;
            get_files_name(tb_1.Text, lb_1);
        }

        private void get_files_name(string dir, ListBox lb)  {
            lb.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(dir);
            foreach (FileInfo fi in di.GetFiles()) {
                lb.Items.Add(fi.Name);
            }
        }

        private void btn_1_Click(object sender, EventArgs e) {
            ofd_1.InitialDirectory = tb_1.Text;
            if (DialogResult.OK == ofd_1.ShowDialog()) {
                lb_1.Items.Clear();
                foreach (string s in ofd_1.SafeFileNames) {
                    lb_1.Items.Add(s);
                }
                tb_1.Text = Path.GetDirectoryName(ofd_1.FileName);
            }
        }

        private void btn_2_Click(object sender, EventArgs e) {
            fbd_1.SelectedPath = tb_2.Text;
            if (DialogResult.OK == fbd_1.ShowDialog()) {
                tb_2.Text = fbd_1.SelectedPath;
                get_files_name(tb_2.Text, lb_2);
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if ((files != null) && (files.Length > 0)) {
                tb_1.Text = Path.GetDirectoryName(files[0]);
                lb_1.Items.Clear();
                foreach (string f in files) {
                    lb_1.Items.Add(Path.GetFileName(f));
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) {
                e.Effect = DragDropEffects.Link;
                this.lb_1.Cursor = System.Windows.Forms.Cursors.Arrow;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void F_main_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings mySet = new Properties.Settings();
            mySet.DirTo = tb_2.Text;
            mySet.ShowShell = cb_1.Checked;
            mySet.WindowLocation = new Point(this.Location.X, this.Location.Y);
            mySet.Save();
        }

        private void F_main_Load(object sender, EventArgs e)   {
            if (0 == tb_2.Text.Length) {
                tb_2.Text = Application.StartupPath;
            }
            get_files_name(tb_2.Text, lb_2);
            cbb_1.SelectedIndex = 0;
        }

        private void lb_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string argu, info;
            argu = " -i \"" + tb_1.Text + "\\" + lb_1.SelectedItem + '"';
            Process p = new Process();
            p.StartInfo.FileName = "ffmpeg.exe";
            p.StartInfo.Arguments = argu;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
           //p.StartInfo.RedirectStandardOutput = true;
           p.StartInfo.RedirectStandardError = true;
            p.Start();
            //info = p.StandardOutput.ReadToEnd();
            info = p.StandardError.ReadToEnd();
            p.WaitForExit();
            p.Close();
            //MessageBox.Show(info);
            info = Regex.Replace(info, @"[\s\S]* (Duration:.*)", "$1");
            tb_code.Text   = Regex.Replace(info, @"[\s\S]*Video: (.*?) [\s\S]*", "$1");
            tb_format.Text = Regex.Replace(info, @"[\s\S]*Video:.*?, (.*?),[\s\S]*", "$1");

            tb_size.Text = Regex.Replace(info, @"[\s\S]*Video:.*?, (\d+.*?) [\s\S]*", "$1").Replace(',', ' ');
            tb_size2.Text = tb_size.Text;

            tb_bitrate.Text = Regex.Replace(info, @"[\s\S]*Video:.*?, \d+.*?, (.*?) [\s\S]*", "$1");
            tb_bitrate2.Text = tb_bitrate.Text;

            tb_duration.Text = Regex.Replace(info, @"Duration: (.*?),[\s\S]*", "$1");
            tb_dur1.Text = "00:00:00";
            tb_dur2.Text = tb_duration.Text;
        }

        private void btn_3_Click(object sender, EventArgs e) {
            string argu;
            double len_1;
            if (0 == lb_1.SelectedItems.Count)  {
                MessageBox.Show("请至少选择一个文件进行转换！");
                return;
            }
            string[] arr_time = tb_dur1.Text.Split(':');
            len_1 = double.Parse(arr_time[0]) * 3600 + double.Parse(arr_time[1]) * 60 + double.Parse(arr_time[2]);
            arr_time = tb_dur2.Text.Split(':');
            len_1 += double.Parse(arr_time[0]) * 3600 + double.Parse(arr_time[1]) * 60 + double.Parse(arr_time[2]);
            foreach (string f in lb_1.SelectedItems)  {
                argu = " -i \"" + tb_1.Text + "\\" + f + "\"  -s  " + tb_size2.Text;
                argu += "  -ss  " + tb_dur1.Text + "  -t  " + len_1.ToString();
                argu += "  -b:v " + tb_bitrate2.Text + 'k';
                if ("h264" == cbb_1.Text)  argu += " -vcodec h264 ";
                if ("h265" == cbb_1.Text)  argu += " -vcodec hevc ";
                argu += "  -y  \"" + tb_2.Text + "\\" + f + ".mp4\"";
                Process p = new Process();
                p.StartInfo.FileName = "ffmpeg.exe";
                p.StartInfo.Arguments = argu;
                p.StartInfo.UseShellExecute = cb_1.Checked;
                p.StartInfo.CreateNoWindow = !cb_1.Checked;
                p.Start();
                p.WaitForExit();
                p.Close();
            }
            MessageBox.Show("转换完成！");
        }
    }
}
