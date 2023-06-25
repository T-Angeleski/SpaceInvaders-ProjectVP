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
            this.firstLifeToGo = new System.Windows.Forms.PictureBox();
            this.secondLifeToGo = new System.Windows.Forms.PictureBox();
            this.thirdLifeToGo = new System.Windows.Forms.PictureBox();
            this.playerPB = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstLifeToGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondLifeToGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdLifeToGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(883, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lives: ";
            // 
            // firstLifeToGo
            // 
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
            this.playerPB.Image = global::SpaceShooters.Properties.Resources.keyboard;
            this.playerPB.Location = new System.Drawing.Point(471, 452);
            this.playerPB.Name = "playerPB";
            this.playerPB.Size = new System.Drawing.Size(147, 105);
            this.playerPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerPB.TabIndex = 0;
            this.playerPB.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bullets Num: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enemies Num: 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Points: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1097, 569);
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
    }
}

