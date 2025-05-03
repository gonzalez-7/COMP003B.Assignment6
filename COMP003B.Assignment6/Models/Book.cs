using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment6.Models
{
	public class Book
	{
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		public int YearPublished { get; set; }

		[ValidateNever]
		public virtual ICollection<BookAuthor> BookAuthors { get; set; }
	}
}