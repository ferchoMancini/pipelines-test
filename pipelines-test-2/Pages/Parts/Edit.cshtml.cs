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
	public class EditModel : PageModel
	{
		public PartModel Part { get; set; }
		public IEnumerable<SelectListItem> Categories { get; set; }

		public void OnGet(int partID)
		{
			Part = PartService.GetById(partID);
			Categories = PartCategoryService.GetAll().Select(a => new SelectListItem
			{
				Value = a.CategoryID.ToString(),
				Text = a.Title
			});
		}

		public IActionResult OnPost(PartModel part)
		{
			if (!ModelState.IsValid)
			{
				Categories = PartCategoryService.GetAll().Select(a => new SelectListItem
				{
					Value = a.CategoryID.ToString(),
					Text = a.Title,
					Selected = part.CategoryID == a.CategoryID
				});
				return Page();
			}

			PartService.Update(part);
			return RedirectToPage("/Parts/Index");
		}
	}
}
