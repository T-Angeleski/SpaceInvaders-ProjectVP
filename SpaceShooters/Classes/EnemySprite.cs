using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceShooters.Properties;
using static System.Windows.Forms.LinkLabel;

namespace SpaceShooters.Classes {
    public class EnemySprite {

        public PictureBox enemy { get; set; }
        public List<Image> enemyImages { get; set; } = new List<Image>  {
            new Bitmap(Resources.triangle_transparent),
            new Bitmap(Resources._404_transparent),
            new Bitmap(Resources.error_transparent),
            new Bitmap(Resources.missing_transparent),
            new Bitmap(Resources.dinosaur_transparent)
        };

        Random random = new Random();

        public EnemySprite() {
            // Choose random image from enemy sprites
            enemy = new PictureBox {
                Image = enemyImages.ElementAt(random.Next(0, enemyImages.Count)),
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }
        public void move() {
            Point pos = enemy.Location;
            pos.Y += 5;
            enemy.Location = pos;
        }
    }
}
