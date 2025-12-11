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
		// Remove any existing custom border layer
		const string borderLayerName = "MauiPickerBorderLayer";
		if (platformView.Layer.Sublayers is { Length: > 0 } sublayers)
		{
			for (int i = sublayers.Length - 1; i >= 0; i--)
			{
				if (sublayers[i].Name == borderLayerName)
				{ sublayers[i].RemoveFromSuperLayer(); }
			}
		}

		var thickness = picker.BorderThickness;
		var hasAnyBorder = thickness.Left > 0 || thickness.Top > 0 || thickness.Right > 0 || thickness.Bottom > 0;

		if (!hasAnyBorder)
		{
			return;
		}

		var bounds = platformView.Bounds;
		if (bounds.Width <= 0 || bounds.Height <= 0)
		{
			// Nothing to draw yet; rely on future layout/handler updates
			return;
		}

		var path = new UIBezierPath();

		// Draw per-side lines; using separate strokes keeps behavior consistent even though
		// CAShapeLayer.LineWidth is uniform. If needed, this can be expanded to one CAShapeLayer per side.

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
			StrokeColor = picker.BorderColor.ToCGColor(),
			LineWidth = 1, // Actual visual thickness is controlled by positioning lines using the Thickness values
		};

		platformView.Layer.AddSublayer(borderLayer);
	}
}
