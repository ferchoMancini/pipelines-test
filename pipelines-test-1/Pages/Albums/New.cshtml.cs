using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;
using data.test.com.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace data.test.com.Pages.Albums
{
	[Authorize(Roles = "Administrator")]
	public class NewModel : PageModel
	{
		public void OnGet()
		{

		}

		public IActionResult OnPost(AlbumModel album)
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}

			AlbumService.New(album);
			return RedirectToPage("/Albums/Index");
		}
	}
}
