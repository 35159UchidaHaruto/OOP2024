using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallApp {
    internal class TennisBall : Obj{
        public static int Count { get; set; }
        Random random = new Random();

        public TennisBall(double xp, double yp)
            : base(xp, yp, @"Picture\tennis_ball.png"){

            MoveX = random.Next(-35, 35);//移動量設定
            MoveY = random.Next(-35, 35);
            Count++;
        }

        public override bool Move(PictureBox pbBar, PictureBox pbBall) {

            Rectangle rBar = new Rectangle(pbBar.Location.X, pbBar.Location.Y,
                                                               pbBar.Width, pbBar.Height);

            Rectangle rBall = new Rectangle(pbBall.Location.X, pbBall.Location.Y,
                                                               pbBall.Width, pbBall.Height);
            PosX += MoveX;
            PosY += MoveY;

            if(PosX > 750 || PosX < 0) {
                //移動量の符号を反転
                MoveX = -MoveX;
            }

            if(PosY < 0 ) {
                //移動量の符号を反転
                MoveY = -MoveY;
            }
            
            //下に落下したか？
            if(PosY > 500) {
                return false;
            }

                return true;
        }

        public override bool Move(Keys direction) {
            return true;
        }
    }
}
