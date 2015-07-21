using System;

namespace TwinTechs.Gestures
{
	public class LongPressGestureRecognizer : BaseGestureRecognizer
	{
		public double MinimumPressDuration { get; set; } 

		public LongPressGestureRecognizer ()
		{
			MinimumPressDuration = 1;
		}

	}
}

