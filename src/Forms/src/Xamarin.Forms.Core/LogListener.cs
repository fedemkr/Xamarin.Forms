using System.ComponentModel;
using Xamarin.Platform;

namespace Xamarin.Forms.Internals
{
	[PortHandler]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class LogListener
	{
		public abstract void Warning(string category, string message);
	}
}