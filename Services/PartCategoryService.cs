using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;

namespace data.test.com.Services
{
	public class PartCategoryService
	{
		private static List<PartCategoryModel> _categories = new List<PartCategoryModel>
		{
			new PartCategoryModel
			{
				CategoryID = 1,
				Title = "Piano"
			},
			new PartCategoryModel
			{
				CategoryID = 2,
				Title = "Guitar"
			}
		};

		public static IEnumerable<PartCategoryModel> GetAll() => _categories;
	}
}
