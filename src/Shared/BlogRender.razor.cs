namespace BlazorBlog.Shared
{
	using BlazorBlog.Models;
	using Microsoft.AspNetCore.Components;

	/// <summary>Blog Render component.</summary>
	public partial class BlogRender
	{
		/// <summary>Gets or sets the Entry parameter.</summary>
		[Parameter]
		public EntryModel? Entry { get; set; }
	}
}