using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetBackgroundAndTime(Properties.Resources.baku, "Azerbaijan Standard Time");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetBackgroundAndTime(Properties.Resources.london, "GMT Standard Time");
        }

        private void SetBackgroundAndTime(System.Drawing.Image backgroundImage, string timeZoneId)
        {
            BackgroundImage = backgroundImage;
            TimeZoneInfo selectedTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            label1.Text = GetTimeForTimeZone(selectedTimeZone);
        }

        private string GetTimeForTimeZone(TimeZoneInfo timeZone)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, timeZone).ToString("HH:mm");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
