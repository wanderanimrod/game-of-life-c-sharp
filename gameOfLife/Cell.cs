using System;
using System.Collections.Generic;
using System.Linq;

namespace gameOfLife
{
	public class Cell
	{
		private bool isAlive = false;

		public Cell() {
		}

		public Cell(bool initialState)
		{
			this.isAlive = initialState;
		}

		public bool IsAlive ()
		{
			return this.isAlive;
		}

		public void Transition(List<Cell> neighbours)
		{
			this.isAlive = true;
			var aliveNeighbours = this.CountAliveNeighbours (neighbours);
			if (aliveNeighbours > 3) {
				this.isAlive = false;
			}
		}

		private int CountAliveNeighbours(List<Cell> neighbours)
		{
			return neighbours.Where (neighbour => neighbour.IsAlive()).Count ();
		}

	}
}

