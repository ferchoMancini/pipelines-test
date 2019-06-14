using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;
using data.test.com.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace data.test.com.Pages.Albums
{
	[Authorize(Roles = "Administrator, ChartWriter")]
	public class IndexModel : PageModel
	{
		[BindProperty(SupportsGet = true)]
		public int? ArtistID { get; set; }

		public IEnumerable<SelectListItem> Artists { get; set; }
		public IEnumerable<AlbumModel> List { get; set; }

		public void OnGet()
		{
			List = AlbumService.GetAll(ArtistID);
			Artists = ArtistService.GetAll().Select(a => new SelectListItem
			{
				Value = a.ArtistID.ToString(),
				Text = a.Title,
				Selected = ArtistID == a.ArtistID
			});
		}
	}
}
