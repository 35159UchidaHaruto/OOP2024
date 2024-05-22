using System.Threading;

namespace BallApp {
    public partial class Form1 : Form {



        //リストコレクション
        private List<Obj> balls = new List<Obj>();   //ボールインスタンス格納用
        private List<PictureBox> pbs = new List<PictureBox>(); //表示用

        //バー用
        private Bar bar;
        private PictureBox pbBar;

        //コンストラクタ
        public Form1() {
            InitializeComponent();
        }

        //フォームが最初にロードされるとき一度だけ実行される
        private void Form1_Load(object sender, EventArgs e) {
            this.Text = "BallApp Soccerball :0 Tennisball : 0";

            bar = new Bar(340, 500);
            pbBar = new PictureBox();

            pbBar.Image = bar.Image;
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
            pbBar.Size = new Size(150, 10);
            pbBar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBar.Parent = this;
        }

        private void timer1_Tick(object sender, EventArgs e) {

            for (int i = 0; i < balls.Count; i++) {
                if (!balls[i].Move(pbBar, pbs[i])) {
                    //落下したボールインスタンスを削除する
                    balls[i].Move(pbBar, pbs[i]);
                }

                pbs[i].Location = new Point((int)balls[i].PosX, (int)balls[i].PosY);
            }
        }

        //マウスクリックイベントハンドラ
        private void Form1_MouseClick(object sender, MouseEventArgs e) {

            PictureBox pb = new PictureBox(); //画像を表示するコントロール
            Obj ball = null;

            if (e.Button == MouseButtons.Left) {
                ball = new SoccerBall(e.X - 15, e.Y - 15);
                pb.Size = new Size(50, 50);
            } else if (e.Button == MouseButtons.Right) {
                ball = new TennisBall(e.X - 35, e.Y - 35);
                pb.Size = new Size(25, 25);
            }
            pb.Image = ball.Image;
            pb.Location = new Point((int)ball.PosX, (int)ball.PosY);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Parent = this;
            timer1.Start();

            balls.Add(ball);
            pbs.Add(pb);
            this.Text = "BallApp SoccerBall:" + SoccerBall.Count + "TennisBall:" + TennisBall.Count;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e) {
            bar.Move(e.KeyCode);
            pbBar.Location = new Point((int)bar.PosX, (int)bar.PosY);
        }

        private void Score_Click(object sender, EventArgs e) {

        }
    }
}

/*private double posX;  x座標
      private double posY;    y座標
      private double moveX;   移動量（x方向）
      private double moveY;   移動量（y方向）*/
