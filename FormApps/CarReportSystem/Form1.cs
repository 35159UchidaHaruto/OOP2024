using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();


        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            //dgvCarReport.Columns["Picture"].Visible = false; //画像を表示しない
        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btAddReport_Click(object sender, EventArgs e) {
            CarReport carReport = new CarReport() {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMakerGroup(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture =

            };
            listCarReports.Add(carReport);
        }



        //選択されているメーカー名を列挙型で返す
        private CarReport.MakerGroup GetRadioButtonMakerGroup() {
        //指定したメーカーのラジオボタンをセット
        /*private void RadioButtonMaker(CarReport.MakerGroup targetMaker) {
                if (targetMaker) {
                    return CarReport.MakerGroup.トヨタ;
                } else if (rbNissan.Checked) {
                    return CarReport.MakerGroup.日産;
                } else if (rbHonda.Checked) {
                    return CarReport.MakerGroup.ホンダ;
                } else if (rbSubaru.Checked) {
                    return CarReport.MakerGroup.スバル;
                } else if (rbImporter.Checked) {
                    return CarReport.MakerGroup.輸入車;
                } else {
                    return CarReport.MakerGroup.その他;
                }
            }*/

            //var makers = CarReport.Maker
            foreach (var s in listCarReports) {

            }
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            } else if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            } else if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            } else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            } else if (rbImporter.Checked) {
                return CarReport.MakerGroup.輸入車;
            } else {
                return CarReport.MakerGroup.その他;
            }
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);

        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void dgvCarReport_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarReport.CurrentRow.Cells["Author"].Value;
            
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvCarReport.CurrentRow.Cells["Report"].Value;
            //Image = (string)dgvCarReport.CurrentRow.Cells["Image"].Value;
        }
    }
}
