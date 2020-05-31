using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame
{
	interface IBird
	{
		int BirdTop { get; set; }
		int BirdBottom { get; set; }
		int BirdLeft { get; set; }
		int BirdRight { get; set; }
	}
}
