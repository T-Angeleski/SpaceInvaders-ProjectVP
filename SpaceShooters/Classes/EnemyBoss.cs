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
        // Represent the enemy
        public PictureBox image;
        // Store image frames for animation
        private List<Image> frames = new List<Image>() {
            new Bitmap(Resources.boss_1),
            new Bitmap(Resources.boss_2),
            new Bitmap(Resources.boss_3)
        };
        // Private counter for looping through frames
        private int currentFrame = 1;

        public bool direction = false; // flag for moving right/left
        public bool moveDown { get; set; } // flag for moving up/down

        public EnemyBoss(Point center) { // Draw enemy at point provided from argument
            image = new PictureBox() {
                Image = new Bitmap(Resources.boss_1),
                Size = new Size(150, 150),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = center,
                BackColor = Color.Transparent
            };
            moveDown = true;
        }

        // Switch boss' direction upon hitting edge of screen
        public void switchDirection() {
            direction = !direction;
        }

        // Methods for moving boss, update position
        public void moveHorizontal() {
            Point pos = image.Location;
            pos.X += direction ? 7 : -7; // Move right/left depending on direction
            image.Location = pos;
        }

        public void moveVertical() {
            Point pos = image.Location;
            // Check whether boss reached height bounds for up/down
            if (moveDown) {
                if (pos.Y + image.Height + 10 > 250)
                    moveDown = false;
                pos.Y += 10;
            } else {
                if (pos.Y - 10 < 50)
                    moveDown = true;
                pos.Y -= 10;
            }
            image.Location = pos;
        }

        // Loop through frames, method is called on timer1.tick()
        public void animate() {
            if (currentFrame == 1) {
                image.Image = frames[0];
                currentFrame++;
            } else if (currentFrame == 2) {
                image.Image = frames[1];
                currentFrame++;
            } else {
                image.Image = frames[2];
                currentFrame = 1;
            }
        }
    }
}
