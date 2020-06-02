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

namespace FlappyBirdGame
{
	public partial class GameCode : Form
	{
		private int PipeSpeed { get; set; }
		private int Gravity { get; set; }
		private int ScoreValue { get; set; }
		private string ScoreString { get; set; }
		private SoundPlayer music;
		private SoundPlayer quack;
		private IPipe topPipeObject;
		private IPipe bottomPipeObject;
		private IBird birdObject;

		public GameCode()
		{
			PipeSpeed = 8;
			Gravity = 5;
			ScoreValue = 0;
			ScoreString = "Score: ";
			quack = new SoundPlayer(Properties.Resources.Quack_Sound_Effect);
			PlayMusic();
			InitializeComponent();
			Restart.Enabled = false;
			topPipeObject = new Pipe(TopPipe.Left, TopPipe.Right, TopPipe.Bottom);
			bottomPipeObject = new Pipe(BottomPipe.Left, BottomPipe.Right, BottomPipe.Top);
			birdObject = new Bird(Bird.Top, Bird.Bottom, Bird.Left, Bird.Right);
		}

		private void PlayMusic()
		{
			music = new SoundPlayer(Properties.Resources.Dead_Or_Alive___You_Spin_Me_Round__MIDI_);
			music.Play();
		}

		private void PlacePipes()
		{
			MovePipes(GameCode.ActiveForm.Width);
			TopPipe.Top = topPipeObject.GetPipeYPlacement();
			topPipeObject.PipeY += TopPipe.Height;

			BottomPipe.Top = TopPipe.Bottom + 100;
			bottomPipeObject.PipeY = BottomPipe.Top;
		}
		private void MovePipes (int newLocale)
		{
			if (newLocale == GameCode.ActiveForm.Width)
			{
				TopPipe.Left = GameCode.ActiveForm.Width;
				BottomPipe.Left = GameCode.ActiveForm.Width;
			}
			else
			{
				BottomPipe.Left -= PipeSpeed;
				TopPipe.Left -= PipeSpeed;
			}
			UpdatePipes();
		}
		private void UpdatePipes()
		{
			topPipeObject.PipeLeft = TopPipe.Left;
			topPipeObject.PipeRight = TopPipe.Right;
			bottomPipeObject.PipeLeft = BottomPipe.Left;
			bottomPipeObject.PipeRight = BottomPipe.Right;
		}
		private void UpdateBird()
		{
			Bird.Top += Gravity;
			UpdateBirdHelper();
			GameOverCheck();
		}
		private void UpdateBirdHelper()
		{
			if (birdObject.BirdBottom >= Ground.Top - 5)
			{
				Bird.Top -= 5;
			}
			birdObject.BirdTop = Bird.Top;
			birdObject.BirdBottom = Bird.Bottom;
		}
		private void GameOverCheck()
		{
			if (IsGameOver())
			{
				GameTimer.Stop();
				music.Dispose();
				quack.Play();
				ScoreString = "Final Score: ";
				ScoreText.BringToFront();
				Restart.Enabled = true;
			}
		}
		private bool IsGameOver()
		{
			return ((birdObject.BirdTop <= topPipeObject.PipeY && 
				birdObject.BirdRight >= topPipeObject.PipeLeft && 
				birdObject.BirdLeft <= topPipeObject.PipeRight) ||
				(birdObject.BirdBottom >= bottomPipeObject.PipeY && 
				birdObject.BirdRight >= bottomPipeObject.PipeLeft && 
				birdObject.BirdLeft <= bottomPipeObject.PipeRight));
		}
		private void GameTimerEvent(object sender, EventArgs e)
		{
			UpdateBird();
			ScoreText.Text = ScoreString + (ScoreValue++);
			MovePipes(PipeSpeed);

			if (BottomPipe.Left + BottomPipe.Width < 0)
			{
				PlacePipes();

			}
			if (ScoreValue % 500 == 0)
			{
				PipeSpeed += 1;
			}
		}

		private void GameKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				Gravity = -5;
			}
		}

		private void GameKeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				Gravity = 5;
			}
		}

		private void MusicTimerEvent(object sender, EventArgs e)
		{
			music.Stop();
			music.Play();
		}

		private void Restart_Click(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
