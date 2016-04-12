using gameOfLife;
using System.Collections.Generic;
using System.Linq;

namespace gameOfLife
{
	public class Neighbourhood
	{
		private IEnumerable<Cell> cells;

		public Neighbourhood(IEnumerable<Cell> cells)
		{
			this.cells = cells;
		}

		public int AliveCellCount()
		{
			return this.cells.Where (cell => cell.IsAlive()).Count ();
		}
	}

}