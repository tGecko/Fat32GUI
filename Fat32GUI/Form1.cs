using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Fat32GUI
{
    public partial class Form1 : Form
    {
        const int WM_DEVICECHANGE = 0x0219;
        DriveInfo[] allDrives;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            refreshDrives();
        }

        private void refreshDrives()
        {
            Cursor.Current = Cursors.WaitCursor;
            txtVolInfo.Text = "Loading...";
            cmbVolumes.Items.Clear();
            allDrives = null;
            allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.DriveType != DriveType.Removable || d.IsReady == false)
                    continue;
                try
                {
                    _ = cmbVolumes.Items.Add(d.Name + " " + d.VolumeLabel);
                }
                catch {
                    MessageBox.Show("whats happen");
                }
            }
            if (cmbVolumes.Items.Count > 0)
            {
                cmbVolumes.SelectedIndex = 0;
            }
            getVolumeInfo();
            Cursor.Current = Cursors.Default;

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_DEVICECHANGE)
            {
                refreshDrives();
            }
            base.WndProc(ref m);
        }

        private void getVolumeInfo()
        {
            if (cmbVolumes.SelectedIndex != -1)
            {
                foreach (DriveInfo d in allDrives)
                {
                    if (d.Name == cmbVolumes.Text.Substring(0, 3))
                    {
                        try
                        {
                            txtVolInfo.Clear();
                            txtVolInfo.Text = "Label = " + d.VolumeLabel;
                            double size = d.TotalSize / 1073741824d;
                            txtVolInfo.Text += "\r\nSize = " + Math.Round(size, 2) + " GiB";
                            txtVolInfo.Text += "\r\nFormat = " + d.DriveFormat;
                            btnFormat.Enabled = true;
                            btnFormat.Text = "Format " + d.Name;
                        }
                        catch (Exception ex)
                        {
                            txtVolInfo.Text = ex.Message;
                            btnFormat.Enabled = false;
                            btnFormat.Text = "Select drive";
                        }
                    }
                }
            }
            else
            {
                txtVolInfo.Text = "No drive detected.";
                btnFormat.Enabled = false;
                btnFormat.Text = "Select drive";
            }
        }
        private void cmbVolumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            getVolumeInfo();

        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string driveToFormat = cmbVolumes.Text.Substring(0, 2);
            string arguments = String.Empty;
            DialogResult dialogResult = MessageBox.Show("This will delete all data on " + driveToFormat + "\r\nand format it to FAT32!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                btnFormat.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                UseWaitCursor = true;
                string path = Path.Combine(Path.GetTempPath(), "fat32format.exe");
                File.WriteAllBytes(path, Properties.Resources.fat32format);

                arguments = "-y " + driveToFormat;
                if (txtLabel.Text.Length > 0)
                {
                    arguments += " -l" + txtLabel.Text;
                }
                var process = new Process
                {
                    StartInfo =
                    {
                        FileName = path,
                        Arguments = arguments,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                process.WaitForExit();
                Cursor.Current = Cursors.Default;
                UseWaitCursor = false;
                int result = process.ExitCode;
                if (result == 0)
                {
                    MessageBox.Show("Format successful!");
                }
                else
                {
                    MessageBox.Show("Format failed");
                }
                File.Delete(path);
                refreshDrives();
            }
        }


        private void txtLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToolTip tt = new ToolTip();

            if (@"*?/\|,;:+=<>[]""".Contains(e.KeyChar.ToString()))
            {
                SystemSounds.Beep.Play();
                tt.Show(@"Not allowed: * ? / \ | , ; : + = < > [ ] "" ", (TextBox)sender, 0, 20, 3000);
                e.Handled = true;
            }
            else if (txtLabel.Text.Length == 11)
            {
                tt.Show(@"11 characters maximum", (TextBox)sender, 0, 20, 500);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            refreshDrives();
        }
    }
}
