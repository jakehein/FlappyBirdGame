namespace FlappyBirdGame
{
	partial class GameCode
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
			this.ScoreText = new System.Windows.Forms.Label();
			this.BottomPipe = new System.Windows.Forms.PictureBox();
			this.Bird = new System.Windows.Forms.PictureBox();
			this.Ground = new System.Windows.Forms.PictureBox();
			this.TopPipe = new System.Windows.Forms.PictureBox();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			this.RightClouds = new System.Windows.Forms.PictureBox();
			this.LeftClouds = new System.Windows.Forms.PictureBox();
			this.MusicTimer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RightClouds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LeftClouds)).BeginInit();
			this.SuspendLayout();
			// 
			// ScoreText
			// 
			this.ScoreText.AutoSize = true;
			this.ScoreText.BackColor = System.Drawing.Color.Transparent;
			this.ScoreText.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ScoreText.Location = new System.Drawing.Point(13, 13);
			this.ScoreText.Name = "ScoreText";
			this.ScoreText.Size = new System.Drawing.Size(189, 55);
			this.ScoreText.TabIndex = 4;
			this.ScoreText.Text = "Score: 0";
			// 
			// BottomPipe
			// 
			this.BottomPipe.AccessibleName = "";
			this.BottomPipe.Image = global::FlappyBirdGame.Properties.Resources.pipe;
			this.BottomPipe.Location = new System.Drawing.Point(700, 250);
			this.BottomPipe.Name = "BottomPipe";
			this.BottomPipe.Size = new System.Drawing.Size(100, 400);
			this.BottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.BottomPipe.TabIndex = 3;
			this.BottomPipe.TabStop = false;
			// 
			// Bird
			// 
			this.Bird.AccessibleName = "";
			this.Bird.BackColor = System.Drawing.Color.Transparent;
			this.Bird.Image = global::FlappyBirdGame.Properties.Resources.bird;
			this.Bird.Location = new System.Drawing.Point(68, 119);
			this.Bird.Name = "Bird";
			this.Bird.Size = new System.Drawing.Size(100, 50);
			this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Bird.TabIndex = 2;
			this.Bird.TabStop = false;
			// 
			// Ground
			// 
			this.Ground.AccessibleName = "";
			this.Ground.Image = global::FlappyBirdGame.Properties.Resources.ground;
			this.Ground.Location = new System.Drawing.Point(-71, 596);
			this.Ground.Name = "Ground";
			this.Ground.Size = new System.Drawing.Size(1061, 157);
			this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Ground.TabIndex = 1;
			this.Ground.TabStop = false;
			// 
			// TopPipe
			// 
			this.TopPipe.AccessibleName = "";
			this.TopPipe.Image = global::FlappyBirdGame.Properties.Resources.pipedown;
			this.TopPipe.Location = new System.Drawing.Point(700, -300);
			this.TopPipe.Name = "TopPipe";
			this.TopPipe.Size = new System.Drawing.Size(100, 400);
			this.TopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.TopPipe.TabIndex = 0;
			this.TopPipe.TabStop = false;
			// 
			// GameTimer
			// 
			this.GameTimer.Enabled = true;
			this.GameTimer.Interval = 20;
			this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
			// 
			// RightClouds
			// 
			this.RightClouds.Image = global::FlappyBirdGame.Properties.Resources.clouds;
			this.RightClouds.Location = new System.Drawing.Point(487, 39);
			this.RightClouds.Name = "RightClouds";
			this.RightClouds.Size = new System.Drawing.Size(307, 265);
			this.RightClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.RightClouds.TabIndex = 5;
			this.RightClouds.TabStop = false;
			// 
			// LeftClouds
			// 
			this.LeftClouds.BackColor = System.Drawing.Color.Transparent;
			this.LeftClouds.Image = global::FlappyBirdGame.Properties.Resources.clouds2;
			this.LeftClouds.Location = new System.Drawing.Point(-85, -3);
			this.LeftClouds.Name = "LeftClouds";
			this.LeftClouds.Size = new System.Drawing.Size(425, 190);
			this.LeftClouds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.LeftClouds.TabIndex = 6;
			this.LeftClouds.TabStop = false;
			// 
			// MusicTimer
			// 
			this.MusicTimer.Enabled = true;
			this.MusicTimer.Interval = 209000;
			this.MusicTimer.Tick += new System.EventHandler(this.MusicTimerEvent);
			// 
			// GameCode
			// 
			this.AccessibleName = "";
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Cyan;
			this.ClientSize = new System.Drawing.Size(878, 844);
			this.Controls.Add(this.Ground);
			this.Controls.Add(this.BottomPipe);
			this.Controls.Add(this.TopPipe);
			this.Controls.Add(this.Bird);
			this.Controls.Add(this.ScoreText);
			this.Controls.Add(this.LeftClouds);
			this.Controls.Add(this.RightClouds);
			this.Name = "GameCode";
			this.Text = "Flappy Bird Game";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
			((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RightClouds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LeftClouds)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox TopPipe;
		private System.Windows.Forms.PictureBox Ground;
		private System.Windows.Forms.PictureBox Bird;
		private System.Windows.Forms.PictureBox BottomPipe;
		private System.Windows.Forms.Label ScoreText;
		private System.Windows.Forms.Timer GameTimer;
		private System.Windows.Forms.PictureBox RightClouds;
		private System.Windows.Forms.PictureBox LeftClouds;
		private System.Windows.Forms.Timer MusicTimer;
	}
}

