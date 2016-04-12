using Xunit;
using gameOfLife;
using System.Linq;

namespace Test
{
	public class CellTest
	{
		[Fact]
		public void cell_should_be_dead_when_instantiated_with_no_args()
		{
			var cell = new Cell ();
			Assert.False(cell.IsAlive());
		}

		[Fact]
		public void CellShouldBeAliveWhenInstantiatedAlive()
		{
			var cell = new Cell (true);
			Assert.True(cell.IsAlive());
		}

		[Fact]
		public void ShouldCountNumberOfTrueThings() {
			bool[] cells = { false, false, false, true, true };
			Assert.Equal (2, countTrues (cells));
		}

		private int countTrues(bool[] bools) {
			return bools.Where (b => b).Count();
		}

		private int counter(bool[] bools)
		{
			int countTrue = 0;
			foreach (bool b in bools) {
				if (b) {
					countTrue++;
				}
			}
			return countTrue;
		}
	}
}