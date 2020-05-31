using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame
{
	class Bird : IBird
	{
		public Bird (int top, int bottom, int left, int right)
		{
			BirdTop = top;
			BirdBottom = bottom;
			BirdLeft = left;
			BirdRight = right;
		}
		public int BirdTop { get; set; }
		public int BirdBottom { get; set; }
		public int BirdLeft { get; set; }
		public int BirdRight { get; set; }
	}
}
