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
        bool bossDefeated = false;
        Random random = new Random();
        List<Projectile> projectiles = new List<Projectile>();
        List<EnemySprite> sprites = new List<EnemySprite>();
        List<Projectile> bossProjectiles = new List<Projectile>();
        List<Image> backgrounds = new List<Image>() {
            new Bitmap(Resources.background1),
            new Bitmap(Resources.background2),
            new Bitmap(Resources.background3),
            new Bitmap(Resources.background4),
        };

        EnemyBoss boss;
        public int mistakes { get; set; }
        public int playerPoints { get; set; }
        public int onBossHits { get; set; }
        public int timerTicks { get; set; }

        private int currentBG = 0;

        public Game() {
            InitializeComponent();
            DoubleBuffered = true;
            timerTicks = 0;
            mistakes = 0;
            playerPoints = 0;
            onBossHits = 0;
            timer1.Start();
            showBossLifeBar(false);
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

            // Spawn enemies untill point threshold is reached
            if (playerPoints < 150 && timerTicks % 20 == 0) spawnEnemies();
            if (playerPoints >= 150 && !bossSpawned) { // 100 points, 10 for testing
                spawnBoss();
                bossSpawned = true;
                removeAllCurrentProjectiles();
                projectiles.Clear();
                showBossLifeBar(true);
            }

            if (timerTicks % 40 == 0) changeBG();

            if (bossSpawned) {
                removeEnemySprites();
                boss.moveHorizontal();
                if (timerTicks % 25 == 0) boss.moveVertical();
                if (timerTicks % 20 == 0) bossAttack();
                if (timerTicks % 10 == 0) boss.animate();

                if (checkBoundsToSwapDirection()) {
                    boss.switchDirection();
                }
                checkIfBossHitPlayer();
                checkIfPlayerHitBoss();
            }

            movePlayer();
            moveUnits();

            bulletIsOutOfFrame();
            enemyIsOutOfFrame();
            checkHit();

            // Check if game ended
            if (onBossHits == 10) {
                bossDefeated = true;
                bossSpawned = false;
                Controls.Remove(boss.image);
            }
            if (mistakes == 3)
                endGame();
            if (bossDefeated)
                gameWon();
        }

        private void removeAllCurrentProjectiles()
        {
            foreach (var projectile in projectiles)
            {
                Controls.Remove(projectile.image);
            }
        }

        private void changeBG() {
            if (currentBG == 0) {
                BackgroundImage = backgrounds[0];
                currentBG++;
            } else if (currentBG == 1) {
                BackgroundImage = backgrounds[1];
                currentBG++;
            } else if (currentBG == 2) {
                BackgroundImage = backgrounds[2];
                currentBG++;
            } else {
                BackgroundImage = backgrounds[3];
                currentBG = 0;
            }
        }

        private void showBossLifeBar(bool value) {
            bossLiveslbl.Visible = value;
            bossLive1.Visible = value;
            bossLive2.Visible = value;
            bossLive3.Visible = value;
            bossLive4.Visible = value;
            bossLive5.Visible = value;
            bossLive6.Visible = value;
            bossLive7.Visible = value;
            bossLive8.Visible = value;
            bossLive9.Visible = value;
            bossLive10.Visible = value;
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

        private void removeEnemySprites() {
            for (int i = sprites.Count - 1; i >= 0; i--) {
                Controls.Remove(sprites.ElementAt(i).enemy);
                sprites.RemoveAt(i);
            }
        }

        private void endGame() {
            timer1.Stop();
            DialogResult gameIsOver = MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.OK);
            Close();
        }
        private void gameWon() {
            timer1.Stop();
            DialogResult gameIsOver = MessageBox.Show("You have won!\nCongratulations!", "You won", MessageBoxButtons.OK);
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
            if (bossProjectiles.Count > 0)
                bossProjectiles.ForEach(p => p.moveDown());
        }

        private void checkIfPlayerHitBoss() {
            for (int i = projectiles.Count - 1; i >= 0; i--) {
                Projectile projectile = projectiles.ElementAt(i);
                bool isHit = checkIsBossHit(projectile, boss);

                if (isHit) {
                    onBossHits++;
                    Controls.Remove(projectiles.ElementAt(i).image);
                    projectiles.RemoveAt(i);
                    switch (onBossHits) {
                        case 1: bossLive1.Visible = false; break;
                        case 2: bossLive2.Visible = false; break;
                        case 3: bossLive3.Visible = false; break;
                        case 4: bossLive4.Visible = false; break;
                        case 5: bossLive5.Visible = false; break;
                        case 6: bossLive6.Visible = false; break;
                        case 7: bossLive7.Visible = false; break;
                        case 8: bossLive8.Visible = false; break;
                        case 9: bossLive9.Visible = false; break;
                        case 10: bossLive10.Visible = false; break;
                    }
                    break;
                }
            }
        }
        private bool checkIsBossHit(Projectile p, EnemyBoss b) {
            Point projectileLocation = p.image.Location;
            Point bossLocation = b.image.Location;
            int pX = projectileLocation.X;
            int pY = projectileLocation.Y;
            int bX = bossLocation.X;
            int bY = bossLocation.Y;

            if (pX + p.image.Width >= bX && pX <= bX + b.image.Width)
                if (pY >= bY && pY <= bY + b.image.Height)
                    return true;
            return false;
        }

        private void checkIfBossHitPlayer() {
            for (int i = bossProjectiles.Count - 1; i >= 0; i--) {
                Projectile projectile = bossProjectiles.ElementAt(i);
                bool isHit = checkIsPlayerHit(projectile, playerPB);

                if (isHit) {
                    mistakes++;
                    Controls.Remove(bossProjectiles.ElementAt(i).image);
                    bossProjectiles.RemoveAt(i);
                    break;
                }
                if (mistakes == 1) {
                    firstLifeToGo.Visible = false;
                } else if (mistakes == 2) {
                    secondLifeToGo.Visible = false;
                } else if (mistakes == 3) {
                    thirdLifeToGo.Visible = false;
                }
            }
        }
        private bool checkIsPlayerHit(Projectile p, PictureBox player) {
            Point projectileLocation = p.image.Location;
            Point playerLocation = player.Location;
            int pX = projectileLocation.X;
            int pY = projectileLocation.Y;
            int playerX = playerLocation.X;
            int playerY = playerLocation.Y;

            if (pX >= playerX && pX <= playerX + player.Width)
                if (pY + p.image.Height >= playerY && pY + p.image.Height <= playerY + player.Height)
                    return true;
            return false;
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

            if (pX + p.image.Width >= eX && pX <= eX + enemy.enemy.Width)
                if (pY >= eY && pY <= eY + enemy.enemy.Height)
                    return true;
            return false;
        }

        private void enemyIsOutOfFrame() {
            for (int i = sprites.Count - 1; i >= 0; i--) {
                if (sprites.ElementAt(i).enemy.Location.Y > 400) {
                    Controls.Remove(sprites.ElementAt(i).enemy);
                    sprites.RemoveAt(i);
                    mistakes++;
                }
                label3.Text = $"Enemies Num: {sprites.Count}";
                if (mistakes == 1) {
                    firstLifeToGo.Visible = false;
                } else if (mistakes == 2) {
                    secondLifeToGo.Visible = false;
                } else if (mistakes == 3) {
                    thirdLifeToGo.Visible = false;
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
            boss = new EnemyBoss(new Point(Width / 2 - 100, 50));
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
