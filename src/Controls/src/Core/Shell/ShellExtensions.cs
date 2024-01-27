#nullable disable
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Maui.Controls
{
	internal static class ShellExtensions
	{
		public static T SearchForRoute<T>(this Shell shell, string route) where T : BaseShellItem =>
			(T)SearchForRoute(shell, route);

		public static BaseShellItem SearchForRoute(this Shell shell, string route) =>
			SearchForPart(shell, (p) => p.Route == route);


		public static T SearchForRoute<T>(this BaseShellItem shell, string route) where T : BaseShellItem =>
			(T)SearchForRoute(shell, route);

		public static BaseShellItem SearchForRoute(this BaseShellItem shell, string route) =>
			SearchForPart(shell, (p) => p.Route == route);


		public static BaseShellItem SearchForPart(this IShellController shell, Func<BaseShellItem, bool> searchBy)
		{
			var items = shell.GetItems();
			for (var i = 0; i < items.Count; i++)
			{
				var result = SearchForPart(items[i], searchBy);
				if (result != null)
				{
					return result;
				}
			}

			return null;
		}

		public static BaseShellItem SearchForPart(this BaseShellItem part, Func<BaseShellItem, bool> searchBy)
		{
			if (searchBy(part))

/* Unmerged change from project 'Controls.Core(net8.0)'
Before:
				return part;

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
After:
			{
				return part;
			}

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-ios)'
Before:
				return part;

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
After:
			{
				return part;
			}

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-maccatalyst)'
Before:
				return part;

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
After:
			{
				return part;
			}

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-android)'
Before:
				return part;

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
After:
			{
				return part;
			}

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.19041)'
Before:
				return part;

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
After:
			{
				return part;
			}

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
*/

/* Unmerged change from project 'Controls.Core(net8.0-windows10.0.20348)'
Before:
				return part;

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
							return baseShellItem;
After:
			{
				return part;
			}

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
*/
			{
				return part;
			}

			BaseShellItem baseShellItem = null;
			switch (part)
			{
				case IShellItemController item:
					foreach (var section in item.GetItems())
					{
						baseShellItem = SearchForPart(section, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
				case IShellSectionController section:
					foreach (var content in section.GetItems())
					{
						baseShellItem = SearchForPart(content, searchBy);
						if (baseShellItem != null)
						{
							return baseShellItem;
						}
					}
					break;
			}

			return null;
		}
	}
}
