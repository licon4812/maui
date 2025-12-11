#nullable disable
using Microsoft.Maui.Controls.Platform;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Platform;

namespace Microsoft.Maui.Controls
{
	public partial class Picker
	{
		public static void MapUpdateMode(IPickerHandler handler, Picker picker)
		{
			if (handler is PickerHandler ph)
				ph.UpdateImmediately = picker.OnThisPlatform().UpdateMode() == UpdateMode.Immediately;
		}

		public static void MapUpdateMode(PickerHandler handler, Picker picker) =>
			MapUpdateMode((IPickerHandler)handler, picker);

		public static void MapBorderColor(IPickerHandler handler, Picker picker)
		{
			// Keep iOS border behavior consistent with Android: delegate to platform extension
			if (handler?.PlatformView is MauiPicker platformView)
			{
				platformView.CreateBorder(picker);
			}
		}

		public static void MapBorderThickness(IPickerHandler handler, Picker picker)
		{
			// Thickness updates use the same iOS platform extension path as color updates
			if (handler?.PlatformView is MauiPicker platformView)
			{
				platformView.CreateBorder(picker);
			}
		}
	}
}