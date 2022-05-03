namespace BlazorBlog.Shared
{
	using Microsoft.AspNetCore.Components;
	using System.Collections.Generic;

	/// <summary>Categories component.</summary>
	public partial class Categories
	{
		/// <summary>Gets or sets an array of categories.</summary>
		[Parameter]
		public List<string>? CategoryArray { get; set; }
	}
}