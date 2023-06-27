namespace SpaceShooters
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bossLiveslbl = new System.Windows.Forms.Label();
            this.bossLive1 = new System.Windows.Forms.PictureBox();
            this.bossLive2 = new System.Windows.Forms.PictureBox();
            this.bossLive3 = new System.Windows.Forms.PictureBox();
            this.bossLive4 = new System.Windows.Forms.PictureBox();
            this.bossLive5 = new System.Windows.Forms.PictureBox();
            this.bossLive6 = new System.Windows.Forms.PictureBox();
            this.bossLive7 = new System.Windows.Forms.PictureBox();
            this.bossLive8 = new System.Windows.Forms.PictureBox();
            this.bossLive9 = new System.Windows.Forms.PictureBox();
            this.bossLive10 = new System.Windows.Forms.PictureBox();
            this.firstLifeToGo = new System.Windows.Forms.PictureBox();
            this.secondLifeToGo = new System.Windows.Forms.PictureBox();
            this.thirdLifeToGo = new System.Windows.Forms.PictureBox();
            this.playerPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLifeToGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondLifeToGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdLifeToGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(856, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lives: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bullets Num: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enemies Num: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 41);
            this.label4.TabIndex = 7;
            this.label4.Text = "Points: 0";
            // 
            // bossLiveslbl
            // 
            this.bossLiveslbl.AutoSize = true;
            this.bossLiveslbl.BackColor = System.Drawing.Color.Transparent;
            this.bossLiveslbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bossLiveslbl.ForeColor = System.Drawing.Color.White;
            this.bossLiveslbl.Location = new System.Drawing.Point(236, 3);
            this.bossLiveslbl.Name = "bossLiveslbl";
            this.bossLiveslbl.Size = new System.Drawing.Size(185, 41);
            this.bossLiveslbl.TabIndex = 8;
            this.bossLiveslbl.Text = "BOSS LIVES: ";
            // 
            // bossLive1
            // 
            this.bossLive1.BackColor = System.Drawing.Color.Red;
            this.bossLive1.Location = new System.Drawing.Point(751, 9);
            this.bossLive1.Name = "bossLive1";
            this.bossLive1.Size = new System.Drawing.Size(30, 30);
            this.bossLive1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive1.TabIndex = 18;
            this.bossLive1.TabStop = false;
            // 
            // bossLive2
            // 
            this.bossLive2.BackColor = System.Drawing.Color.Red;
            this.bossLive2.Location = new System.Drawing.Point(715, 9);
            this.bossLive2.Name = "bossLive2";
            this.bossLive2.Size = new System.Drawing.Size(30, 30);
            this.bossLive2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive2.TabIndex = 17;
            this.bossLive2.TabStop = false;
            // 
            // bossLive3
            // 
            this.bossLive3.BackColor = System.Drawing.Color.Red;
            this.bossLive3.Location = new System.Drawing.Point(679, 9);
            this.bossLive3.Name = "bossLive3";
            this.bossLive3.Size = new System.Drawing.Size(30, 30);
            this.bossLive3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive3.TabIndex = 16;
            this.bossLive3.TabStop = false;
            // 
            // bossLive4
            // 
            this.bossLive4.BackColor = System.Drawing.Color.Red;
            this.bossLive4.Location = new System.Drawing.Point(643, 9);
            this.bossLive4.Name = "bossLive4";
            this.bossLive4.Size = new System.Drawing.Size(30, 30);
            this.bossLive4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive4.TabIndex = 15;
            this.bossLive4.TabStop = false;
            // 
            // bossLive5
            // 
            this.bossLive5.BackColor = System.Drawing.Color.Red;
            this.bossLive5.Location = new System.Drawing.Point(607, 9);
            this.bossLive5.Name = "bossLive5";
            this.bossLive5.Size = new System.Drawing.Size(30, 30);
            this.bossLive5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive5.TabIndex = 14;
            this.bossLive5.TabStop = false;
            // 
            // bossLive6
            // 
            this.bossLive6.BackColor = System.Drawing.Color.Red;
            this.bossLive6.Location = new System.Drawing.Point(571, 9);
            this.bossLive6.Name = "bossLive6";
            this.bossLive6.Size = new System.Drawing.Size(30, 30);
            this.bossLive6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive6.TabIndex = 13;
            this.bossLive6.TabStop = false;
            // 
            // bossLive7
            // 
            this.bossLive7.BackColor = System.Drawing.Color.Red;
            this.bossLive7.Location = new System.Drawing.Point(535, 9);
            this.bossLive7.Name = "bossLive7";
            this.bossLive7.Size = new System.Drawing.Size(30, 30);
            this.bossLive7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive7.TabIndex = 12;
            this.bossLive7.TabStop = false;
            // 
            // bossLive8
            // 
            this.bossLive8.BackColor = System.Drawing.Color.Red;
            this.bossLive8.Location = new System.Drawing.Point(499, 9);
            this.bossLive8.Name = "bossLive8";
            this.bossLive8.Size = new System.Drawing.Size(30, 30);
            this.bossLive8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive8.TabIndex = 11;
            this.bossLive8.TabStop = false;
            // 
            // bossLive9
            // 
            this.bossLive9.BackColor = System.Drawing.Color.Red;
            this.bossLive9.Location = new System.Drawing.Point(463, 9);
            this.bossLive9.Name = "bossLive9";
            this.bossLive9.Size = new System.Drawing.Size(30, 30);
            this.bossLive9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive9.TabIndex = 10;
            this.bossLive9.TabStop = false;
            // 
            // bossLive10
            // 
            this.bossLive10.BackColor = System.Drawing.Color.Red;
            this.bossLive10.Location = new System.Drawing.Point(427, 9);
            this.bossLive10.Name = "bossLive10";
            this.bossLive10.Size = new System.Drawing.Size(30, 30);
            this.bossLive10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossLive10.TabIndex = 9;
            this.bossLive10.TabStop = false;
            // 
            // firstLifeToGo
            // 
            this.firstLifeToGo.BackColor = System.Drawing.Color.Transparent;
            this.firstLifeToGo.Image = global::SpaceShooters.Properties.Resources.lives_logo;
            this.firstLifeToGo.Location = new System.Drawing.Point(1055, 14);
            this.firstLifeToGo.Name = "firstLifeToGo";
            this.firstLifeToGo.Size = new System.Drawing.Size(30, 30);
            this.firstLifeToGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstLifeToGo.TabIndex = 4;
            this.firstLifeToGo.TabStop = false;
            // 
            // secondLifeToGo
            // 
            this.secondLifeToGo.BackColor = System.Drawing.Color.Transparent;
            this.secondLifeToGo.Image = global::SpaceShooters.Properties.Resources.lives_logo;
            this.secondLifeToGo.Location = new System.Drawing.Point(1007, 14);
            this.secondLifeToGo.Name = "secondLifeToGo";
            this.secondLifeToGo.Size = new System.Drawing.Size(30, 30);
            this.secondLifeToGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondLifeToGo.TabIndex = 3;
            this.secondLifeToGo.TabStop = false;
            // 
            // thirdLifeToGo
            // 
            this.thirdLifeToGo.BackColor = System.Drawing.Color.Transparent;
            this.thirdLifeToGo.Image = global::SpaceShooters.Properties.Resources.lives_logo;
            this.thirdLifeToGo.Location = new System.Drawing.Point(959, 14);
            this.thirdLifeToGo.Name = "thirdLifeToGo";
            this.thirdLifeToGo.Size = new System.Drawing.Size(30, 30);
            this.thirdLifeToGo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thirdLifeToGo.TabIndex = 2;
            this.thirdLifeToGo.TabStop = false;
            // 
            // playerPB
            // 
            this.playerPB.BackColor = System.Drawing.Color.Transparent;
            this.playerPB.Image = global::SpaceShooters.Properties.Resources.keyboard;
            this.playerPB.Location = new System.Drawing.Point(471, 452);
            this.playerPB.Name = "playerPB";
            this.playerPB.Size = new System.Drawing.Size(147, 105);
            this.playerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPB.TabIndex = 0;
            this.playerPB.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::SpaceShooters.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1097, 569);
            this.Controls.Add(this.bossLive1);
            this.Controls.Add(this.bossLive2);
            this.Controls.Add(this.bossLive3);
            this.Controls.Add(this.bossLive4);
            this.Controls.Add(this.bossLive5);
            this.Controls.Add(this.bossLive6);
            this.Controls.Add(this.bossLive7);
            this.Controls.Add(this.bossLive8);
            this.Controls.Add(this.bossLive9);
            this.Controls.Add(this.bossLive10);
            this.Controls.Add(this.bossLiveslbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstLifeToGo);
            this.Controls.Add(this.secondLifeToGo);
            this.Controls.Add(this.thirdLifeToGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerPB);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bossLive1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossLive10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstLifeToGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondLifeToGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdLifeToGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox thirdLifeToGo;
        private System.Windows.Forms.PictureBox secondLifeToGo;
        private System.Windows.Forms.PictureBox firstLifeToGo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bossLiveslbl;
        private System.Windows.Forms.PictureBox bossLive10;
        private System.Windows.Forms.PictureBox bossLive9;
        private System.Windows.Forms.PictureBox bossLive8;
        private System.Windows.Forms.PictureBox bossLive7;
        private System.Windows.Forms.PictureBox bossLive6;
        private System.Windows.Forms.PictureBox bossLive5;
        private System.Windows.Forms.PictureBox bossLive4;
        private System.Windows.Forms.PictureBox bossLive3;
        private System.Windows.Forms.PictureBox bossLive2;
        private System.Windows.Forms.PictureBox bossLive1;
    }
}

