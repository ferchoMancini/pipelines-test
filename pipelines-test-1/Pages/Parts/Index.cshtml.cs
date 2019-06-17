using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;
using data.test.com.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace data.test.com.Pages.Parts
{
	public class IndexModel : PageModel
	{
		[BindProperty(SupportsGet = true)]
		public int? CategoryID { get; set; }

		public IEnumerable<SelectListItem> Categories { get; set; }
		public IEnumerable<PartModel> List { get; set; }

		public void OnGet()
		{
			List = PartService.GetAll(CategoryID);
			Categories = PartCategoryService.GetAll().Select(a => new SelectListItem
			{
				Value = a.CategoryID.ToString(),
				Text = a.Title,
				Selected = CategoryID == a.CategoryID
			});
		}
	}
}
