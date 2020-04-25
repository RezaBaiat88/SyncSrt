using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UntertitelHilferApp
{
    public partial class frmSrtFixer : Form
    {
        public frmSrtFixer()
        {
            InitializeComponent();
        }

        int lastSearchLoc = 0;
        decimal delayRate = 0;
        string realStart = "";
        bool dontReactToEndChange = false;

        private void btnSelectSrtFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSrtFilePath.Text = openFileDialog1.FileName;
                rtxtPreview.Text = System.IO.File.ReadAllText(openFileDialog1.FileName, Encoding.UTF7); // ?
                rtxtPreview.Tag = rtxtPreview.Text; // save default text
            }
        }

        private void showPreviewChange(object sender, EventArgs e)
        {
            if (dontReactToEndChange)
                return;

            string searchText = $"{endHour.Value.ToString("00")}:{endMinute.Value.ToString("00")}:{endSecond.Value.ToString("00")},{endMillisecond.Value.ToString("000")}";
            var splitter = new string[] { " --> " };
            bool found = false;
            for (int i = 0; i < rtxtPreview.Lines.Length; i++)
            {
                if (rtxtPreview.Lines[i].Contains(splitter[0]))
                {
                    var parts = rtxtPreview.Lines[i].Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        if (string.Compare(parts[0], searchText) <= 0 && string.Compare(parts[1], searchText) >= 0)
                        {
                            rtxtPreview.Text = rtxtPreview.Tag.ToString(); // reset text
                            rtxtPreview.SelectionStart = rtxtPreview.Find(rtxtPreview.Lines[i]);
                            rtxtPreview.SelectionLength = 29;
                            rtxtPreview.SelectionColor = Color.Red;
                            rtxtPreview.ScrollToCaret();
                            realStart = parts[0];

                            found = true;
                            break;
                        }
                    }
                }
            }
            if (!found)
                lblDelay.Text = "0";
            else
                calcDelay();
        }

        private void frmSrtFixer_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void frmSrtFixer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnFindNext_Click(btnFind, new EventArgs());
            if (e.KeyCode == Keys.F3)
                btnFindNext_Click(btnFindNext, new EventArgs());
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lastSearchLoc = 0;
            int loc = rtxtPreview.Find(txtSearch.Text);
            if (loc != -1)
            {
                lastSearchLoc = loc;
                gotoFind();
                setStart();
                calcDelay();
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            int loc = rtxtPreview.Find(txtSearch.Text, lastSearchLoc + 1, RichTextBoxFinds.None);
            if (loc != -1)
            {
                lastSearchLoc = loc;
                gotoFind();
                setStart();
                calcDelay();
            }
        }

        private void gotoFind()
        {
            // rtxtPreview.Text = rtxtPreview.Tag.ToString(); // reset text
            rtxtPreview.SelectionStart = lastSearchLoc;
            rtxtPreview.SelectionLength = txtSearch.Text.Length;
            rtxtPreview.SelectionColor = Color.Blue;
            rtxtPreview.ScrollToCaret();
        }

        private void setStart()
        {
            int lineIndex = rtxtPreview.GetLineFromCharIndex(lastSearchLoc);
            string[] splitter = new string[] { " --> " };
            for (int i = lineIndex - 1; i >= 0; i--)
            {
                if (rtxtPreview.Lines[i].Contains(splitter[0]))
                {
                    var parts = rtxtPreview.Lines[i].Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                    startHour.Value = int.Parse(parts[0].Substring(0, 2));
                    startMinute.Value = int.Parse(parts[0].Substring(3, 2));
                    startSecond.Value = int.Parse(parts[0].Substring(6, 2));
                    startMilisecond.Value = int.Parse(parts[0].Substring(9, 3));

                    break;
                }
            }
        }

        private void calcDelay()
        {
            decimal foundAt = (startHour.Value * 3600000) + (startMinute.Value * 60000) + (startSecond.Value * 1000) + startMilisecond.Value;
            decimal expectedAt = (endHour.Value * 3600000) + (endMinute.Value * 60000) + (endSecond.Value * 1000) + endMillisecond.Value;
            delayRate = expectedAt / foundAt;
            lblDelay.Text = delayRate.ToString();
        }

        private void btnSetEnd_Click(object sender, EventArgs e)
        {
            dontReactToEndChange = true;
            endHour.Value = int.Parse(realStart.Substring(0, 2));
            endMinute.Value = int.Parse(realStart.Substring(3, 2));
            endSecond.Value = int.Parse(realStart.Substring(6, 2));
            endMillisecond.Value = int.Parse(realStart.Substring(9, 3));
            dontReactToEndChange = false;
            calcDelay();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            var sourceData = System.IO.File.ReadAllLines(txtSrtFilePath.Text, Encoding.UTF7);
            string destPath = txtSrtFilePath.Text.Substring(0, txtSrtFilePath.Text.Length - 4) + "-fix.srt";
            StringBuilder sb = new StringBuilder();
            var splitter = new string[] { " --> " };
            bool timeFixed = false;
            for (var i = 0; i < sourceData.Length; i++)
            {
                timeFixed = false;
                string line = sourceData[i];
                if (line.Contains(splitter[0]))
                {
                    var parts = rtxtPreview.Lines[i].Split(splitter, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2 && parts[0].Length == 12 && parts[1].Length == 12)
                    {
                        string start = fixTime(parts[0], delayRate);
                        string end = fixTime(parts[1], delayRate);

                        sb.AppendLine($"{start}{splitter[0]}{end}");
                        timeFixed = true;
                    }
                }

                if (!timeFixed)
                    sb.AppendLine(line);
            }

            System.IO.File.WriteAllText(destPath, sb.ToString(), Encoding.UTF8);
        }

        private string fixTime(string timeString, decimal rate)
        {
            decimal hour = int.Parse(timeString.Substring(0, 2));
            decimal minute = int.Parse(timeString.Substring(3, 2));
            decimal second = int.Parse(timeString.Substring(6, 2));
            decimal millisecond = int.Parse(timeString.Substring(9, 3));

            decimal totalMillisecond = (hour * 3600000) + (minute * 60000) + (second * 1000) + millisecond;
            decimal newTotalMillisecond = totalMillisecond * rate;

            return new DateTime().AddMilliseconds((double)newTotalMillisecond).ToString("HH:mm:ss,fff");
        }
    }
}
