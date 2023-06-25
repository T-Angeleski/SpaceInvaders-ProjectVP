using SpaceShooters.Classes;
using SpaceShooters.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShooters {
    public partial class Game : Form {

        bool isRightPressed = false;
        bool isLeftPressed = false;
        bool bossSpawned = false;
        Random random = new Random();
        List<Projectile> projectiles = new List<Projectile>();
        List<EnemySprite> sprites = new List<EnemySprite>();
        List<Projectile> bossProjectiles = new List<Projectile>();
        EnemyBoss boss;
        public int deletedEnemies { get; set; }
        public int playerPoints { get; set; }
        public int timerTicks { get; set; }

        public Game() {
            InitializeComponent();
            DoubleBuffered = true;
            timerTicks = 0;
            deletedEnemies = 0;
            playerPoints = 0;
            timer1.Start();
        }

        private void Game_Load(object sender, EventArgs e) {
            
        }

        private void Game_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) {
                isLeftPressed = true;
            }
            if (e.KeyCode == Keys.Right) {
                isRightPressed = true;
            }

            if (e.KeyCode == Keys.Space) {
                Projectile bullet = new Projectile(new Bitmap(Resources.bulletTEMP));
                bullet.image.Location = getCenterPointPlayer(); // Shoot projectile from player center
                Controls.Add(bullet.image);
                projectiles.Add(bullet);
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) {
                isLeftPressed = false;
            }
            if (e.KeyCode == Keys.Right) {
                isRightPressed = false;
            }
        }


        private void timer1_Tick(object sender, EventArgs e) {
            timerTicks++;
            if (playerPoints < 10 && timerTicks % 20 == 0) spawnEnemies();
            if (playerPoints >= 10 && !bossSpawned) { // 100 points, 10 for testing
                spawnBoss();
                bossSpawned = true;
            }

            if(bossSpawned) {
                boss.moveHorizontal();
                if (timerTicks % 25 == 0) boss.moveVertical();
                if (timerTicks % 20 == 0) bossAttack();

                if(checkBoundsToSwapDirection()) {
                    boss.switchDirection();
                }
            }
            movePlayer();
            moveUnits();
            bulletIsOutOfFrame();
            enemyIsOutOfFrame();
            checkHit();
            if (playerPoints == 150)
                endGame();
        }

        

        private void movePlayer() {
            Point newPos = playerPB.Location;
            if (isLeftPressed && newPos.X - 7 >= 0) { // Check out of bounds
                newPos.X -= 12;
            }
            if (isRightPressed && newPos.X + 7 - playerPB.Width <= 610) {
                newPos.X += 12;
            }
            playerPB.Location = newPos;
        }

        private void endGame() {
            timer1.Stop();
            DialogResult gameIsOver = MessageBox.Show("You have won!\nCongratulations!", "You won");
            Close();
        }
        // For projectiles
        private Point getCenterPointPlayer() {
            int x = playerPB.Location.X + playerPB.Width / 2 - 5;
            int y = playerPB.Location.Y - 21;
            return new Point(x, y);
        }
        private void bulletIsOutOfFrame() {
            for (int i = projectiles.Count - 1; i >= 0; i--) {
                if (projectiles.ElementAt(i).image.Location.Y + projectiles.ElementAt(i).image.Height < 0) {
                    Controls.Remove(projectiles.ElementAt(i).image);
                    projectiles.RemoveAt(i);
                }
                label2.Text = $"Bullets Num: {projectiles.Count}";
            }
        }

        private void moveUnits() {
            if (projectiles.Count > 0)
                projectiles.ForEach(p => p.move());
            if (sprites.Count > 0)
                sprites.ForEach(s => s.move());
            if(bossProjectiles.Count > 0)
                bossProjectiles.ForEach(p => p.moveDown());
        }

        private void checkHit() {
            for (int i = projectiles.Count - 1; i >= 0; i--) {
                for (int j = sprites.Count - 1; j >= 0; j--) {

                    Projectile projectile = projectiles.ElementAt(i);
                    EnemySprite enemy = sprites.ElementAt(j);
                    bool isHit = checkCollision(projectile, enemy);

                    if (isHit) {
                        playerPoints += 10;
                        Controls.Remove(projectiles.ElementAt(i).image);
                        projectiles.RemoveAt(i);
                        Controls.Remove(sprites.ElementAt(j).enemy);
                        sprites.RemoveAt(j);
                        label2.Text = $"Bullets Num: {projectiles.Count}";
                        label3.Text = $"Enemies Num: {sprites.Count}";
                        label4.Text = $"Points {playerPoints}";
                        break;
                    }
                }
            }
        }
        private void spawnEnemies() {
            EnemySprite enemySprite = new EnemySprite();
            enemySprite.enemy.Location = new Point(random.Next(playerPB.Width / 2, 770 - playerPB.Width / 2), 0);
            Controls.Add(enemySprite.enemy);
            sprites.Add(enemySprite);
        }

        private bool checkCollision(Projectile p, EnemySprite enemy) {
            Point projectileLocation = p.image.Location;
            Point enemyLocation = enemy.enemy.Location;
            int pX = projectileLocation.X;
            int pY = projectileLocation.Y;
            int eX = enemyLocation.X;
            int eY = enemyLocation.Y;

            if (pX >= eX && pX <= eX + enemy.enemy.Width)
                if (pY >= eY && pY <= eY + enemy.enemy.Height)
                    return true;
            return false;
        }

        private void enemyIsOutOfFrame() {
            for (int i = sprites.Count - 1; i >= 0; i--) {
                if (sprites.ElementAt(i).enemy.Location.Y > 400) {
                    Controls.Remove(sprites.ElementAt(i).enemy);
                    sprites.RemoveAt(i);
                    deletedEnemies++;
                }
                label3.Text = $"Enemies Num: {sprites.Count}";
                if (deletedEnemies == 1) {
                    firstLifeToGo.Visible = false;
                } else if (deletedEnemies == 2) {
                    secondLifeToGo.Visible = false;
                } else if (deletedEnemies == 3) {
                    thirdLifeToGo.Visible = false;
                    endGame();
                }
            }
        }

        // BOSS CODE
        private bool checkBoundsToSwapDirection() {
            if (boss.image.Location.X < 5) return true;
            if (boss.image.Location.X + boss.image.Width > Width - 5) return true;
            return false;
        }

        private void spawnBoss() {
            boss = new EnemyBoss(new Point(Width / 2 - 100, 0));
            Controls.Add(boss.image);
        }

        private void bossAttack() {
            Point center = getCenterPointBoss();
            Projectile projectile = new Projectile(new Bitmap(Resources.bossProjectile));
            projectile.image.Location = center;
            Controls.Add(projectile.image);
            bossProjectiles.Add(projectile);
        }

        private Point getCenterPointBoss() {
            int x = boss.image.Location.X + boss.image.Width / 2;
            int y = boss.image.Location.Y + 150;
            return new Point(x, y);
        }
    }
}
