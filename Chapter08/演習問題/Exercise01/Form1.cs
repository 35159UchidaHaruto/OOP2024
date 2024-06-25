using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = now.ToString("ggyy”NMŒd“ú(dddd)", culture);
            tbDisp.Text = now.ToString("d") + " " + now.ToString("t") + "\r\n";
            tbDisp.Text += now.ToString("yyyy”NMŒd“ú HHmm•ªss•b\r\n");
            tbDisp.Text += now.ToString(str);
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            DateTime nextweekday = nextWeekday(today, DayOfWeek.Tuesday);
            tbDisp.Text = today + "‚ÌŸT‚Í"+ nextweekday.ToString("d") + nextweekday.ToString("dddd");
        }

        private static DateTime nextWeekday(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 0)
                days += 7;
            return date.AddDays(days);

        }        

        private void btEx8_3_Click(object sender, EventArgs e) {
            
        }
    }
}
