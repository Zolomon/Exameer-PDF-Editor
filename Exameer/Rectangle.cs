using System;

namespace Exameer
{
	public class Rectangle
	{
		public int x1 { get; set; }

		public int y1 { get; set; }

		public int x2 { get; set; }

		public int y2 { get; set; }

		public Rectangle (int x1, int y1, int x2, int y2)
		{
			this.x1 = x1;
			this.y1 = y1;
			this.x2 = x2;
			this.y2 = y2;
		}
	}
}

