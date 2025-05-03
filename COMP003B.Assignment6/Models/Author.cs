using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
	public class Author
	{
		public int Id { get; set; }

		[Required]
		public string Name { get; set; }

		public string Biography { get; set; }

		[ValidateNever]
		// Collection navigation property
		public virtual ICollection<BookAuthor> BookAuthors { get; set; }
	}
}