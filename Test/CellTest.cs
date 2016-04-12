using Xunit;
using gameOfLife;
using System.Collections.Generic;

namespace Test
{
	public class CellTest
	{
		[Fact]
		public void CellShouldBeDeadWhenCreatedWithoutArguments()
		{
			var cell = new Cell ();

			var cellIsAlive = cell.IsAlive ();

			Assert.False (cellIsAlive);
		}

		[Fact]
		public void CellShouldBeAliveWhenCreatedAlive()
		{
			var cell = new Cell (true);

			var cellIsAlive = cell.IsAlive ();
				
			Assert.True (cellIsAlive);
		}

		[Fact]
		public void CellShouldBecomeAliveWhen2NeighboursAreAlive()
		{
			var cell = new Cell ();
			List<Cell> neighbours = new List<Cell>{ new Cell (true), new Cell (true)};

			cell.Transition (neighbours);

			Assert.True (cell.IsAlive());
		}

		[Fact]
		public void CellShouldBecomeDeadWhen4NeighboursAreAlive()
		{
			var cell = new Cell (true);
			List<Cell> neighbours = new List<Cell>{ new Cell (true), new Cell (true), new Cell(true), new Cell(true)};

			cell.Transition (neighbours);

			Assert.False (cell.IsAlive ());
		}
	}
}