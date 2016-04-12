using System;

namespace gameOfLife
{
	public class Cell
	{
		private bool isAlive;

		public Cell (bool isAlive)
		{
			this.isAlive = isAlive;
		}

		public Cell () 
		{
			
		}

		public void Translate() {
			
		}

		public bool IsAlive()
		{
			return this.isAlive;
		}
	}
}

