using SpaceShooters.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooters.Classes {
    public class EnemyBoss {
        public PictureBox image;
        public int healthPoints = 20;
        public bool direction = false; // right/left
        public bool moveDown { get; set; }

        public EnemyBoss(Point center) {
            image = new PictureBox() {
                Image = new Bitmap(Resources._404_transparent),
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = center
            };
            moveDown = true;
        }

        public void switchDirection() {
            direction = !direction;
        }

        public void moveHorizontal() {
            Point pos = image.Location;
            pos.X += direction ? 7 : -7;
            image.Location = pos;
        }

        public void moveVertical() {
            Point pos = image.Location;
            if (moveDown){
                if (pos.Y + image.Height + 10 > 250)
                    moveDown = false;
                pos.Y += 10;
                image.Location = pos;
            }
            else {
                if (pos.Y - 10 < 50)
                    moveDown = true;
                pos.Y -= 10;
                image.Location = pos;
            }
        }
    }
}
