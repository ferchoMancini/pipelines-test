using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;

namespace data.test.com.Services
{
	public class ArtistService
	{
		private static List<ArtistModel> _artists = new List<ArtistModel>
		{
			new ArtistModel
			{
				ArtistID = 1,
				Title = "test.com"
			},
			new ArtistModel
			{
				ArtistID = 2,
				Title = "Hillsong"
			}
		};

		public static IEnumerable<ArtistModel> GetAll() => _artists;
	}
}
