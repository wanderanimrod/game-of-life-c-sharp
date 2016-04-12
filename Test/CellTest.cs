using Xunit;
using gameOfLife;
using System.Collections.Generic;
using System;

namespace Test
{
	public class CellTest
	{
		[Fact]
		public void ShouldBeDeadWhenCreatedWithoutArguments()
		{
			var cell = new Cell ();

			var cellIsAlive = cell.IsAlive ();

			Assert.False (cellIsAlive);
		}

		[Fact]
		public void ShouldBeAliveWhenCreatedAlive()
		{
			var cell = new Cell (CellState.Alive);

			var cellIsAlive = cell.IsAlive ();
				
			Assert.True (cellIsAlive);
		}

		[Fact]
		public void WhenAlive_ShouldBecomeDead_WhenMoreThan3NeighboursAreAlive()
		{
			var cell = new Cell (CellState.Alive);
			Neighbourhood neighbourhood = NeighbourhoodFactory.MakeNeighbourhood(4);

			cell.Transition (neighbourhood);

			Assert.False (cell.IsAlive ());
		}

		[Fact]
		public void WhenAlive_ShouldBecomeDead_WhenLessThan2NeighboursAreAlive()
		{
			var cell = new Cell (CellState.Alive);
			Neighbourhood neighbourhood = NeighbourhoodFactory.MakeNeighbourhood(1);

			cell.Transition (neighbourhood);

			Assert.False (cell.IsAlive ());
		}

		[Fact]
		public void WhenDead_ShouldBecomeAlive_WhenExactly3NeighboursAreAlive()
		{
			var cell = new Cell ();
			Neighbourhood neighbourhood = NeighbourhoodFactory.MakeNeighbourhood(3);

			cell.Transition (neighbourhood);

			Assert.True (cell.IsAlive());
		}
			
		[Fact]
		public void WhenDead_ShouldRemainDead_WhenAliveNeighboursAreLessThan3()
		{
			var cell = new Cell ();
			Neighbourhood neighbourhood = NeighbourhoodFactory.MakeNeighbourhood(2);

			cell.Transition (neighbourhood);

			Assert.False (cell.IsAlive());
		}

		[Fact]
		public void WhenDead_ShouldRemainDead_WhenAliveNeighboursAreMoreThan3()
		{
			var cell = new Cell ();
			Neighbourhood neighbourhood = NeighbourhoodFactory.MakeNeighbourhood(4);

			cell.Transition (neighbourhood);

			Assert.False (cell.IsAlive());
		}
	}
}