using SpaceShooters.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooters
{
    public partial class MainMenuForm : Form
    {
        SoundPlayer player;
        public bool musicIsPlaying { get; set; }
        public MainMenuForm()
        {
            InitializeComponent();
            player = new SoundPlayer(Resources.Space_invaders_Main_Menu_Music);
            player.PlayLooping();
            musicIsPlaying = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);
            if (messageBox == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game newGame = new Game();
            newGame.Show();
            player.Stop();
            newGame.FormClosed += new FormClosedEventHandler(newGame_FormClosed);
        }
        private void newGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (musicIsPlaying)
            {
                player.PlayLooping();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (musicIsPlaying)
            {
                musicIsPlaying = false;
                player.Stop();
                button2.BackgroundImage = new Bitmap(Resources.sound_speaker_disabled);
            }
            else
            {
                musicIsPlaying = true;
                player.PlayLooping();
                button2.BackgroundImage = new Bitmap(Resources.sound_speaker_icon_on_white_background_free_vector);
            }
        }
    }
}
