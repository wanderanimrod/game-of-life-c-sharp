using System;
using System.Collections.Generic;
using System.Linq;

namespace gameOfLife
{
	public class Cell
	{
		private CellState currentState = CellState.Dead;

		public Cell() {}

		public Cell(CellState initialState)
		{
			this.currentState = initialState;
		}

		public bool IsAlive ()
		{
			return this.currentState == CellState.Alive;
		}

		private bool IsDead()
		{
			return !this.IsAlive ();	
		}

		public void Transition(Neighbourhood neighbourhood)
		{
			var aliveNeighbours = neighbourhood.AliveCellCount();
			if (this.IsDead () && aliveNeighbours == 3) {
				this.currentState = CellState.Alive;
			} else if (aliveNeighbours < 2 || aliveNeighbours > 3) {
				this.currentState = CellState.Dead;
			}
		}
	}
}

