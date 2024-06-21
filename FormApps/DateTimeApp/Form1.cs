using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void tbDisp_TextChanged(object sender, EventArgs e) {

        }

        private void btDateCount_Click(object sender, EventArgs e) {                                  
            
            var today = DateTime.Today; //¡“ú‚Ì“ú•t

            TimeSpan timeSpan = today - dtpBirthday.Value; //¡“ú‚©‚ç’a¶“ú‚Ü‚Å‚Ì“ú”‚ğŒvZ‚·‚é
            tbDisp.Text = timeSpan.Days + "“ú–Ú";            

        }
    }
}
