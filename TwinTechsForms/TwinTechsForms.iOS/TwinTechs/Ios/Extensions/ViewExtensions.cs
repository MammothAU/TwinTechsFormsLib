using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;

namespace TwinTechs.Ios.Extensions
{
	public static class ViewExtensions
	{
		
		/***
		 * Thanks to Adam Kemp for generously making this code available.
		 * If you are reading this, please petition Xamarin to give us public access to the GetRenderer method:
		 * https://bugzilla.xamarin.com/show_bug.cgi?id=30467
		 */

		#region GetRenderer Hack

		private delegate IVisualElementRenderer GetRendererDelegate (VisualElement bindable);

		private static GetRendererDelegate _getRendererDelegate;

		public static IVisualElementRenderer GetRenderer (this VisualElement bindable)
		{
			if (bindable == null) {
				return null;
			}
				
			return Platform.GetRenderer (bindable);
		}

		#endregion
	}
}

