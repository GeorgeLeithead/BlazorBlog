namespace BlazorBlog.Models
{
	using System;
	using System.Collections.Generic;

	/// <summary>Entry Model.</summary>
	public class EntryModel
	{
		/// <summary>Gets or sets the blog author.</summary>
		public string Author { get; set; } = "George Leithead";

		/// <summary>Gets or sets the categories.</summary>
		public List<string>? Categories { get; set; }

		/// <summary>Gets or sets the content.</summary>
		public string Content { get; set; }

		/// <summary>Gets or sets the created date time offset.</summary>
		public DateTimeOffset Created { get; set; }

		/// <summary>Gets or sets the unique entry identifier.</summary>
		public int Id { get; set; }

		/// <summary>Gets or sets the PermA link.</summary>
		public string Permalink { get; set; }

		/// <summary>Gets or sets the title.</summary>
		public string Title { get; set; }
	}
}