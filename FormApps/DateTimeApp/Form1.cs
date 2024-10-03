namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {

            var today = DateTime.Today;

            TimeSpan diff = today - dtpDate.Value;

            //tbDisp.Text = "ÅZÅZì˙ñ⁄";
            tbDisp.Text = (diff.Days + 1) + "ì˙ñ⁄";
        }

        private void btDayBufore_Click(object sender, EventArgs e) {
            // tbDisp.Text = numericUpDown1.Value.ToString();
            var past = dtpDate.Value.AddDays(-(double)nudDay.Value);
            tbDisp.Text = past.ToString("D");
        }

        private void BtDayafter_Click(object sender, EventArgs e) {
            var future = dtpDate.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = future.ToString("D");
        }

        private void btAege_Click(object sender, EventArgs e) {
            var brithday = dtpDate.Value;
            var today = DateTime.Today;
            int age = GetAge(brithday, today);
            tbDisp.Text = age.ToString();
        }

        private int GetAge(DateTime brithday, DateTime targetDay) {
            var age = targetDay.Year - brithday.Year;
            if(targetDay< brithday.AddYears(age).AddDays(-1)) {
                age--;
            }
            return age;
        }
    }
}
