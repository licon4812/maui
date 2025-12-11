using System;
using System.Collections.Generic;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using UIKit;

namespace Microsoft.Maui.Controls.Platform;

public static class PickerExtensions
{
	public static void CreateBorder(this MauiPicker platformView, Picker picker)
	{
		// If all sides are equal, use the native uniform border support
		var t = picker.BorderThickness;
		var uniform = t.Left == t.Top && t.Top == t.Right && t.Right == t.Bottom;

		if (uniform)
		{
			// Clear any custom layers we may have added previously
			const string borderLayerNamePrefix = "MauiPickerBorderLayer_";
			if (platformView.Layer.Sublayers is { Length: > 0 } sublayersUniform)
			{
				for (int i = sublayersUniform.Length - 1; i >= 0; i--)
				{
					if (sublayersUniform[i].Name != null && sublayersUniform[i].Name!
						    .StartsWith(borderLayerNamePrefix, StringComparison.Ordinal))
					{
						sublayersUniform[i].RemoveFromSuperLayer();
					}
				}
			}

			if (t.Left <= 0)
			{
				platformView.Layer.BorderWidth = 0;
				return;
			}

			platformView.Layer.BorderColor = picker.BorderColor.ToCGColor();
			platformView.Layer.BorderWidth = (nfloat)t.Left;
			return;
		}

		// Non-uniform thickness: custom per-side drawing via CAShapeLayer(s)
		const string borderLayerName = "MauiPickerBorderLayer_Custom";
		if (platformView.Layer.Sublayers is { Length: > 0 } sublayers)
		{
			for (int i = sublayers.Length - 1; i >= 0; i--)
			{
				if (sublayers[i].Name == borderLayerName)
				{
					sublayers[i].RemoveFromSuperLayer();
				}
			}
		}

		var thickness = picker.BorderThickness;
		var hasAnyBorder = thickness.Left > 0 || thickness.Top > 0 || thickness.Right > 0 || thickness.Bottom > 0;

		if (!hasAnyBorder)
		{
			platformView.Layer.BorderWidth = 0;
			return;
		}

		var bounds = platformView.Bounds;
		if (bounds.Width <= 0 || bounds.Height <= 0)
		{
			// Nothing to draw yet; rely on future layout/handler updates
			return;
		}

		var color = picker.BorderColor.ToCGColor();

		var path = new UIBezierPath();

		// Top
		if (thickness.Top > 0)
		{
			var y = thickness.Top / 2.0;
			path.MoveTo(new CGPoint(0, y));
			path.AddLineTo(new CGPoint(bounds.Width, y));
		}

		// Bottom
		if (thickness.Bottom > 0)
		{
			var y = bounds.Height - thickness.Bottom / 2.0;
			path.MoveTo(new CGPoint(0, y));
			path.AddLineTo(new CGPoint(bounds.Width, y));
		}

		// Left
		if (thickness.Left > 0)
		{
			var x = thickness.Left / 2.0;
			path.MoveTo(new CGPoint(x, 0));
			path.AddLineTo(new CGPoint(x, bounds.Height));
		}

		// Right
		if (thickness.Right > 0)
		{
			var x = bounds.Width - thickness.Right / 2.0;
			path.MoveTo(new CGPoint(x, 0));
			path.AddLineTo(new CGPoint(x, bounds.Height));
		}

		var borderLayer = new CAShapeLayer
		{
			Name = borderLayerName,
			Frame = bounds,
			Path = path.CGPath,
			FillColor = UIColor.Clear.CGColor,
			StrokeColor = color,
			LineWidth = 1,
		};

		// Ensure the native border does not interfere when using custom drawing
		platformView.Layer.BorderWidth = 0;
		platformView.Layer.AddSublayer(borderLayer);
	}
}
