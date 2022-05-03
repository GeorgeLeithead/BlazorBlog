namespace BlazorBlog.Models
{
	using System.Collections.Generic;

	/// <summary>Blog entries model.</summary>
	public class BlogEntriesModel
	{
		/// <summary>Gets or sets an array or entries.</summary>
		public List<EntryModel>? Entries { get; set; }
	}
}