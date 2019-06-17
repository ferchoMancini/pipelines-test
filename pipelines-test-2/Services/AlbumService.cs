using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;

namespace data.test.com.Services
{
	public class AlbumService
	{
		private static List<AlbumModel> _albums = new List<AlbumModel>
		{
			new AlbumModel
			{
				AlbumID = 1,
				Title ="What a beautiful MVC it is",
				ArtistID = 1,
				Artist= "test.com"
			},
			new AlbumModel
			{
				AlbumID = 2,
				Title ="I Did It Again",
				ArtistID = 2,
				Artist= "Hillsong"
			},
			new AlbumModel
			{
				AlbumID = 3,
				Title ="In the Zone",
				ArtistID = 2,
				Artist= "Hillsong"
			}
		};

		public static IEnumerable<AlbumModel> GetAll(int? artistID) => _albums.Where(a => !artistID.HasValue || a.ArtistID == artistID);

		public static void New(AlbumModel album)
		{
			album.AlbumID = _albums.Count + 1;
			album.Artist = ArtistService.GetAll().First(a => a.ArtistID == album.ArtistID)?.Title	;

			_albums.Add(album);
		}

		public static AlbumModel GetById(int ID) => _albums.FirstOrDefault(a => a.AlbumID == ID);

		public static void Update(AlbumModel album)
		{
			var savedAlbum = GetById(album.AlbumID);
			savedAlbum.Title = album.Title;
			savedAlbum.ArtistID= album.ArtistID;
			savedAlbum.Artist = ArtistService.GetAll().First(a => a.ArtistID == album.ArtistID)?.Title;
		}

		public static void Delete(int albumID) => _albums.Remove(GetById(albumID));
	}
}
