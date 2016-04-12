using System;
using gameOfLife;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
	public class NeighbourhoodFactory
	{
		public static Neighbourhood MakeNeighbourhood(int countAlive, int countDead = 0)
		{
			var aliveCells = Enumerable.Range (0, countAlive).Select (_ => new Cell(CellState.Alive));
			var deadCells = Enumerable.Range (0, countDead).Select (_ => new Cell());
			return new Neighbourhood (aliveCells.Union (deadCells));
		}
	}
}

