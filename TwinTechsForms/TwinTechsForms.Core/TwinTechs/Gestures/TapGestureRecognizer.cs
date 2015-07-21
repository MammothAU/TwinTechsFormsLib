using System;

using Xamarin.Forms;

namespace TwinTechs.Gestures
{
	public interface ITapGestureRecognizer : INativeGestureRecognizer
	{
	}

	public class TapGestureRecognizer  : BaseGestureRecognizer
	{
		public TapGestureRecognizer ()
		{
			NumberOfTouchesRequired = 1;
			NumberOfTapsRequired = 1;
		}

		public int NumberOfTapsRequired { get; set; } 

		public int NumberOfTouchesRequired { get; set; }
	}
}


