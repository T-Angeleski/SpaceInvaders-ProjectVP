using SpaceShooters.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooters.Classes {

    public class Player {
        public int width { get; set; }
        public int height { get; set; }

        public PictureBox keyboard;

        public Player(Point center) {

            this.keyboard = new PictureBox();
            keyboard.Image = new Bitmap(Resources.keyboard);
            keyboard.Location = center;
            this.keyboard.Size = new Size(200, 150);
            this.height = keyboard.Size.Width;
            this.height = keyboard.Size.Height;
        }
    }
}
