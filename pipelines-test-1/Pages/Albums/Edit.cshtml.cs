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
	public class EditModel : PageModel
	{
		public AlbumModel Album { get; set; }

		public void OnGet(int albumID)
		{
			Album = AlbumService.GetById(albumID);
		}

		public IActionResult OnPost(AlbumModel album)
		{
			if (!ModelState.IsValid)
			{
				Album = album;
				return Page();
			}

			AlbumService.Update(album);
			return RedirectToPage("/Albums/Index");
		}
	}
}
