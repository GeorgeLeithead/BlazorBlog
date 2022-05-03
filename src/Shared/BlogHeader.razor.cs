namespace BlazorBlog.Shared
{
	using Microsoft.AspNetCore.Components;
	using System;
	using System.Globalization;

	/// <summary>Blog header component.</summary>
	public partial class BlogHeader
	{
		/// <summary>Gets or sets the category filter.</summary>
		[Parameter]
		public string? Category { get; set; }

		/// <summary>Gets or sets the day filter.</summary>
		[Parameter]
		public int Day { get; set; }

		/// <summary>Gets or sets the month filter.</summary>
		[Parameter]
		public int Month { get; set; }

		/// <summary>Gets or sets the permalink filter.</summary>
		[Parameter]
		public string PermaLink { get; set; }

		/// <summary>Gets or sets the year filter.</summary>
		[Parameter]
		public int Year { get; set; }

		private string DisplayHeader
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(Category))
				{
					return string.Format(CultureInfo.InvariantCulture, "Category: {0}", Category);
				}

				if (Year == 0 || !string.IsNullOrEmpty(PermaLink))
				{
					return string.Empty;
				}

				if (Day != 0)
				{
					DateTime fakeDateTime = new(Year, Month, Day);
					return string.Format(CultureInfo.InvariantCulture, "Day: {0}", fakeDateTime.ToString("dddd dd MMMM yyyy", CultureInfo.InvariantCulture));
				}
				else
				{
					if (Month != 0)
					{
						DateTime fakeDateTime = new(Year, Month, 1);
						return string.Format(CultureInfo.InvariantCulture, "Month: {0}", fakeDateTime.ToString("MMMM yyyy", CultureInfo.InvariantCulture));
					}
					else
					{
						return string.Format(CultureInfo.InvariantCulture, "Year: {0}", Year);
					}
				}
			}
		}
	}
}