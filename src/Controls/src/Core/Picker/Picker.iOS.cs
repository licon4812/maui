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

		static void MapBorderColor(IPickerHandler handler, Picker picker)
		{
			// For iOS, apply border-related properties via the platform view's layer, similar to other text-based controls.
			if (handler?.PlatformView is MauiPicker platformView)
			{
				platformView.Layer.BorderColor = picker.BorderColor.ToCGColor();
			}
		}

		static void MapBorderThickness(IPickerHandler handler, Picker picker)
		{
			// Border thickness changes share the same update path as border color.
			if (handler?.PlatformView is MauiPicker platformView)
			{
				platformView.UpdateBorder(picker);
			}
		}
	}
}