using SpaceShooters.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace SpaceShooters.Classes {
    public class Projectile {
        public PictureBox image;

        public Projectile() {
            image = new PictureBox {
                Image = Image.FromFile("Resources/bulletTEMP.png"),
                Size = new Size(5, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
        }

        public void move() {
            Point pos = image.Location;
            pos.Y -= 10;
            image.Location = pos;
        }
    }
}
