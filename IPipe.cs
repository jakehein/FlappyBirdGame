using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBirdGame
{
	interface IPipe
	{
		int GetRandNum();
		int GetPipeYPlacement();
		int PipeLeft { get; set; }
		int PipeRight { get; set; }
		int PipeY { get; set; }
	}
}
