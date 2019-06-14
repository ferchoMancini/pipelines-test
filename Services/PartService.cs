using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data.test.com.Models;

namespace data.test.com.Services
{
	public class PartService
	{
		private static List<PartModel> _parts = new List<PartModel>
		{
			new PartModel
			{
				PartID = 1,
				Title ="Piano",
				CategoryID = 1,
				Category = "Piano"
			},
			new PartModel
			{
				PartID = 2,
				Title ="Guitar 1",
				CategoryID = 2,
				Category = "Guitar"
			},
			new PartModel
			{
				PartID = 3,
				Title ="Guitar 2",
				CategoryID = 2,
				Category= "Guitar"
			}
		};

		public static IEnumerable<PartModel> GetAll(int? CategoryID) => _parts.Where(a => !CategoryID.HasValue || a.CategoryID == CategoryID);

		public static void New(PartModel Part)
		{
			Part.PartID = _parts.Count + 1;
			Part.Category = PartCategoryService.GetAll().First(a => a.CategoryID == Part.CategoryID)?.Title	;

			_parts.Add(Part);
		}

		public static PartModel GetById(int ID) => _parts.FirstOrDefault(a => a.PartID == ID);

		public static void Update(PartModel Part)
		{
			var savedPart = GetById(Part.PartID);
			savedPart.Title = Part.Title;
			savedPart.CategoryID= Part.CategoryID;
			savedPart.Category = PartCategoryService.GetAll().First(a => a.CategoryID == Part.CategoryID)?.Title;
		}

		public static void Delete(int PartID) => _parts.Remove(GetById(PartID));
	}
}
