using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame
{
	class Pipe : IPipe
	{
		readonly int[] pipeYPlacement = { -200, -175, -150, -125, -100, -75, -50, -25, 0 };
		public Pipe (int left, int right, int y)
		{
			PipeLeft = left;
			PipeRight = right;
			PipeY = y;
		}
		public int PipeLeft { get; set; }
		public int PipeRight { get; set; }
		public int PipeY { get; set; }

		public int GetPipeYPlacement()
		{
			PipeY = pipeYPlacement[GetRandNum()];
			return PipeY;
		}

		public int GetRandNum()
		{
			Random rand = new Random();
			return rand.Next(0, 9);
		}
	}
}
