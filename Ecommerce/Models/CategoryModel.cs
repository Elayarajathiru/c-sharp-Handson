using System;
using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Models
{
	public class CategoryModel
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
	}
}

