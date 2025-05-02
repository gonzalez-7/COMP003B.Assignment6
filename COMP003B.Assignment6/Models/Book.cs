namespace COMP003B.Assignment6.Models
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
	}
}
