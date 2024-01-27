using System;
using System.ComponentModel;
using System.Globalization;
using Microsoft.Maui.Layouts;

#nullable disable
namespace Microsoft.Maui.Converters
{
	/// <inheritdoc/>
	public class FlexJustifyTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexJustify justify))
				{
					return justify;
				}

				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
				{
					return FlexJustify.Start;
				}

				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
				{
					return FlexJustify.End;
				}

				if (strValue.Equals("space-between", StringComparison.OrdinalIgnoreCase))
				{
					return FlexJustify.SpaceBetween;
				}

				if (strValue.Equals("space-around", StringComparison.OrdinalIgnoreCase))
				{
					return FlexJustify.SpaceAround;
				}
			}

			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexJustify)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexJustify fj)
			{
				throw new NotSupportedException();
			}

			return fj.ToString();
		}
	}

	/// <inheritdoc/>
	public class FlexDirectionTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexDirection aligncontent))
				{
					return aligncontent;
				}

				if (strValue.Equals("row-reverse", StringComparison.OrdinalIgnoreCase))
				{
					return FlexDirection.RowReverse;
				}

				if (strValue.Equals("column-reverse", StringComparison.OrdinalIgnoreCase))
				{
					return FlexDirection.ColumnReverse;
				}
			}

			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexDirection)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexDirection fd)
			{
				throw new NotSupportedException();
			}

			return fd.ToString();
		}
	}

	/// <inheritdoc/>
	public class FlexAlignContentTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexAlignContent aligncontent))
				{
					return aligncontent;
				}

				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignContent.Start;
				}

				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignContent.End;
				}

				if (strValue.Equals("space-between", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignContent.SpaceBetween;
				}

				if (strValue.Equals("space-around", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignContent.SpaceAround;
				}
			}

			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexAlignContent)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexAlignContent fac)
			{
				throw new NotSupportedException();
			}

			return fac.ToString();
		}
	}

	/// <inheritdoc/>
	public class FlexAlignItemsTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexAlignItems alignitems))
				{
					return alignitems;
				}

				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignItems.Start;
				}

				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignItems.End;
				}
			}

			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexAlignItems)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexAlignItems fai)
			{
				throw new NotSupportedException();
			}

			return fai.ToString();
		}
	}

	/// <inheritdoc/>
	public class FlexAlignSelfTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexAlignSelf alignself))
				{
					return alignself;
				}

				if (strValue.Equals("flex-start", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignSelf.Start;
				}

				if (strValue.Equals("flex-end", StringComparison.OrdinalIgnoreCase))
				{
					return FlexAlignSelf.End;
				}
			}

			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexAlignSelf)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexAlignSelf fes)
			{
				throw new NotSupportedException();
			}

			return fes.ToString();
		}
	}

	/// <inheritdoc/>
	public class FlexWrapTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				if (Enum.TryParse(strValue, true, out FlexWrap wrap))
				{
					return wrap;
				}

				if (strValue.Equals("wrap-reverse", StringComparison.OrdinalIgnoreCase))
				{
					return FlexWrap.Reverse;
				}
			}

			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexWrap)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexWrap fw)
			{
				throw new NotSupportedException();
			}

			return fw.ToString();
		}
	}

	/// <inheritdoc/>
	public class FlexBasisTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
			=> sourceType == typeof(string);

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
			=> true;

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			var strValue = value?.ToString();

			if (strValue != null)
			{
				strValue = strValue.Trim();

				if (strValue.Equals("auto", StringComparison.OrdinalIgnoreCase))

/* Unmerged change from project 'Core(net8.0)'
Before:
					return FlexBasis.Auto;
				if (ParsePercentage(strValue, out float relflex))
					return new FlexBasis(relflex / 100, isRelative: true);
After:
				{
					return FlexBasis.Auto;
				}
*/

/* Unmerged change from project 'Core(net8.0-android)'
Before:
					return FlexBasis.Auto;
				if (ParsePercentage(strValue, out float relflex))
					return new FlexBasis(relflex / 100, isRelative: true);
After:
				{
					return FlexBasis.Auto;
				}
*/

/* Unmerged change from project 'Core(net8.0-windows10.0.19041)'
Before:
					return FlexBasis.Auto;
				if (ParsePercentage(strValue, out float relflex))
					return new FlexBasis(relflex / 100, isRelative: true);
After:
				{
					return FlexBasis.Auto;
				}
*/

/* Unmerged change from project 'Core(net8.0-windows10.0.20348)'
Before:
					return FlexBasis.Auto;
				if (ParsePercentage(strValue, out float relflex))
					return new FlexBasis(relflex / 100, isRelative: true);
After:
				{
					return FlexBasis.Auto;
				}
*/
				{
					return FlexBasis.Auto;
				}

				if (ParsePercentage(strValue, out float relflex))
				{
					return new FlexBasis(relflex / 100, isRelative: true);
				}

				if (float.TryParse(strValue, NumberStyles.Number, CultureInfo.InvariantCulture, out float flex))
				{
					return new FlexBasis(flex);
				}
			}

			throw new InvalidOperationException(string.Format("Cannot convert \"{0}\" into {1}", strValue, typeof(FlexBasis)));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is not FlexBasis basis)
			{
				throw new NotSupportedException();

/* Unmerged change from project 'Core(net8.0)'
Added:
			}
*/

/* Unmerged change from project 'Core(net8.0-ios)'
Added:
			}
*/

/* Unmerged change from project 'Core(net8.0-maccatalyst)'
Added:
			}
*/

/* Unmerged change from project 'Core(net8.0-android)'
Added:
			}
*/

/* Unmerged change from project 'Core(net8.0-windows10.0.19041)'
Added:
			}
*/

/* Unmerged change from project 'Core(net8.0-windows10.0.20348)'
Added:
			}
*/

/* Unmerged change from project 'Core(net8.0)'
Before:
				return "auto";
			if (basis.IsRelative)
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
After:
			{
				return "auto";
*/

/* Unmerged change from project 'Core(net8.0-ios)'
Before:
				return "auto";
			if (basis.IsRelative)
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
After:
			{
				return "auto";
*/

/* Unmerged change from project 'Core(net8.0-maccatalyst)'
Before:
				return "auto";
			if (basis.IsRelative)
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
After:
			{
				return "auto";
*/

/* Unmerged change from project 'Core(net8.0-android)'
Before:
				return "auto";
			if (basis.IsRelative)
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
After:
			{
				return "auto";
*/

/* Unmerged change from project 'Core(net8.0-windows10.0.19041)'
Before:
				return "auto";
			if (basis.IsRelative)
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
After:
			{
				return "auto";
*/

/* Unmerged change from project 'Core(net8.0-windows10.0.20348)'
Before:
				return "auto";
			if (basis.IsRelative)
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
After:
			{
				return "auto";
*/
			}

			if (basis.IsAuto)
			{
				return "auto";
			}

			if (basis.IsRelative)
			{
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
			}
			}

			if (basis.IsRelative)
			{
				return $"{(basis.Length * 100).ToString(CultureInfo.InvariantCulture)}%";
			}

			return $"{basis.Length.ToString(CultureInfo.InvariantCulture)}";
		}

		static bool ParsePercentage(string strValue, out float relflex)
		{
			if (!strValue.EndsWith("%", StringComparison.OrdinalIgnoreCase))
			{
				relflex = default;
				return false;
			}

			var value =
#if NETSTANDARD2_0 // sigh
				strValue.Substring(0, strValue.Length - 1);
#else
				strValue.AsSpan(0, strValue.Length - 1);
#endif

			return float.TryParse(value, NumberStyles.Number, CultureInfo.InvariantCulture, out relflex);
		}
	}
}