using System;
using ObjCRuntime;
using UIKit;

namespace Microsoft.Maui.Graphics.Platform
{
	public static class UIColorExtensions
	{
		public static string ToHex(this UIColor color)
		{
			if (color == null)

/* Unmerged change from project 'Graphics(net7.0-ios)'
Before:
				return null;

			color.GetRGBA(out var red, out var green, out var blue, out var alpha);

			if (alpha < 1)
				return "#" + ToHexString(red) + ToHexString(green) + ToHexString(blue) + ToHexString(alpha);
After:
			{
				return null;
*/

/* Unmerged change from project 'Graphics(net7.0-maccatalyst)'
Before:
				return null;

			color.GetRGBA(out var red, out var green, out var blue, out var alpha);

			if (alpha < 1)
				return "#" + ToHexString(red) + ToHexString(green) + ToHexString(blue) + ToHexString(alpha);
After:
			{
				return null;
*/
			{
				return null;
			}

			color.GetRGBA(out var red, out var green, out var blue, out var alpha);

			if (alpha < 1)
			{
				return "#" + ToHexString(red) + ToHexString(green) + ToHexString(blue) + ToHexString(alpha);
			}
			}

			color.GetRGBA(out var red, out var green, out var blue, out var alpha);

			if (alpha < 1)
			{
				return "#" + ToHexString(red) + ToHexString(green) + ToHexString(blue) + ToHexString(alpha);
			}

			return "#" + ToHexString(red) + ToHexString(green) + ToHexString(blue);
		}

		private static string ToHexString(nfloat value)
		{
			var intValue = (int)(255f * value);
			var stringValue = intValue.ToString("X");
			if (stringValue.Length == 1)
			{
				return "0" + stringValue;
			}

			return stringValue;
		}
	}
}
