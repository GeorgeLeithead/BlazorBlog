namespace BlazorBlog.Shared
{
	using Microsoft.AspNetCore.Components;
	using System;

	/// <summary>Blog pager component.</summary>
	public partial class BlogPager
	{
		private int pageNumber;

		/// <summary>Gets or sets the count of entries.</summary>
		[Parameter]
		public int Count { get; set; }

		/// <summary>Gets or sets the day filter.</summary>
		[Parameter]
		public int Day { get; set; }

		/// <summary>Gets or sets the month filter.</summary>
		[Parameter]
		public int Month { get; set; }

		/// <summary>Gets the number of pages.</summary>
		public int NumberOfPages => (int)Math.Ceiling(Count / (double)PageSize);

		/// <summary>Gets or sets the current page number.</summary>
		[Parameter]
		public int PageNumber
		{
			get => pageNumber;
			set
			{
				if (value < 1)
				{
					pageNumber = 1;
				}
				else
				{
					pageNumber = value;
				}
			}
		}

		/// <summary>Gets or sets the page size.</summary>
		[Parameter]
		public int PageSize { get; set; }

		/// <summary>Gets or sets the year filter.</summary>
		[Parameter]
		public int Year { get; set; }

		private bool DisplayNewer => PageNumber > 1;

		private bool DisplayOlder => PageNumber < NumberOfPages;

		private string GetNewerHref
		{
			get
			{
				string href = string.Empty;
				if (Year != 0)
				{
					href = string.Format("/{0}", Year);
				}

				if (Month != 0)
				{
					href = string.Format("{0}/{1}", href, Month);
				}

				if (Day != 0)
				{
					href = string.Format("{0}/{1}", href, Day);
				}

				return string.Format("{0}/Page/{1}", href, PageNumber - 1);
			}
		}

		private string GetOlderHref
		{
			get
			{
				string href = string.Empty;
				if (Year != 0)
				{
					href = string.Format("/{0}", Year);
				}

				if (Month != 0)
				{
					href = string.Format("{0}/{1}", href, Month);
				}

				if (Day != 0)
				{
					href = string.Format("{0}/{1}", href, Day);
				}

				return string.Format("{0}/Page/{1}", href, PageNumber + 1);
			}
		}
	}
}