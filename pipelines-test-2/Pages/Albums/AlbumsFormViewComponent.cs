using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;
using data.test.com.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace data.test.com.Pages.Albums
{
	public class AlbumsFormViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke(AlbumModel album)
		{
			ViewData["Artists"] = ArtistService.GetAll().Select(a => new SelectListItem
			{
				Value = a.ArtistID.ToString(),
				Text = a.Title,
				Selected = album?.ArtistID == a.ArtistID
			});
			return View("Default", album);
		}
	}
}
