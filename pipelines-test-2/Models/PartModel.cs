using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.test.com.Models
{
	public class PartModel
	{
		public PartModel()
		{

		}

		public int PartID { get; set; }
		[Required]
		public string Title { get; set; }
		public int CategoryID { get; set; }
		public string Category { get; set; }
	}
}
