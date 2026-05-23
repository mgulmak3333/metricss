using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetriCss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x84 && (int)m.Result == 0x1)
                m.Result = (IntPtr)0x2;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void uıTextBox1_TextChanged(object sender, EventArgs e) { }
        private void before_metric_SelectedIndexChanged(object sender, EventArgs e) { }
        private void after_metrcis_SelectedIndexChanged(object sender, EventArgs e) { }
        private void response_label_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(response_label.Text))
            {
                
                Clipboard.SetText(response_label.Text);

                
                string eskiMetin = response_label.Text;
                response_label.Text = "Copied! ✔";

                
                Task.Delay(1000).ContinueWith(t => {
                    this.Invoke((MethodInvoker)delegate {
                        response_label.Text = eskiMetin;
                    });
                });
            }
        }
        private void preview_number_Click(object sender, EventArgs e) { }

        private double ToPx(double value, string unit, double w, double h, double fs)
        {
            double min = Math.Min(w, h);
            double max = Math.Max(w, h);

            switch (unit)
            {
                case "px": return value;
                case "rem": return value * fs;
                case "em": return value * fs;
                case "ex": return value * fs * 0.5;
                case "%": return value * w / 100;
                case "vw": return value * w / 100;
                case "vh": return value * h / 100;
                case "vmin": return value * min / 100;
                case "vmax": return value * max / 100;
                case "lh": return value * fs * 1.2;
                case "pc": return value * 16.0;
                case "cm": return value * 37.7952755906;
                case "mm": return value * 3.77952755906;
                default: throw new ArgumentException("Bilinmeyen birim: " + unit);
            }
        }

        private double FromPx(double px, string unit, double w, double h, double fs)
        {
            double min = Math.Min(w, h);
            double max = Math.Max(w, h);

            switch (unit)
            {
                case "px": return px;
                case "rem": return px / fs;
                case "em": return px / fs;
                case "ex": return px / (fs * 0.5);
                case "%": return px / w * 100;
                case "vw": return px / w * 100;
                case "vh": return px / h * 100;
                case "vmin": return px / min * 100;
                case "vmax": return px / max * 100;
                case "lh": return px / (fs * 1.2);
                case "pc": return px / 16.0;
                case "cm": return px / 37.7952755906;
                case "mm": return px / 3.77952755906;
                default: throw new ArgumentException("Unknown unit: " + unit);
            }
        }

        private void convert_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uıTextBox1.Text))
            {
                
                response_label.Text = "Please enter a value!";
                return;
            }

            if (before_metric.SelectedItem == null || after_metrcis.SelectedItem == null)
            {
                
                response_label.Text = "Please select the units!";
                return;
            }

            if (!double.TryParse(uıTextBox1.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double inputValue))
            {
               
                response_label.Text = "Invalid number format!";
                return;
            }

            string from = before_metric.SelectedItem.ToString().Trim();
            string to = after_metrcis.SelectedItem.ToString().Trim();

            double w = Screen.PrimaryScreen != null ? Screen.PrimaryScreen.Bounds.Width : 1920;
            double h = Screen.PrimaryScreen != null ? Screen.PrimaryScreen.Bounds.Height : 1080;
            double fs = 16.0;

            preview_number.Text = inputValue + from;

            if (from == to)
            {
                response_label.Text = inputValue + from;
                return;
            }

            try
            {
                double px = ToPx(inputValue, from, w, h, fs);
                double result = FromPx(px, to, w, h, fs);

                
                string fmt;
                if (to == "rem" || to == "em" || to == "ex" || to == "cm")
                    fmt = "F3";
                else
                    fmt = "F2";

                
                response_label.Text = result.ToString(fmt) + to;
            }
            catch (Exception ex)
            {
                response_label.Text = "Mistake: " + ex.Message;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = convert_btn;
        }
    }
}