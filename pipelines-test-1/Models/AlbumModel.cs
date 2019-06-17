using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.test.com.Models
{
	public class AlbumModel
	{
		public AlbumModel()
		{

		}

		public int AlbumID { get; set; }
		[Required]
		public string Title { get; set; }
		public int ArtistID { get; set; }
		public string Artist { get; set; }
	}
}
