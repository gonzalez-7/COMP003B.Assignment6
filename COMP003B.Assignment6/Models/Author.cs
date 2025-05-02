namespace COMP003B.Assignment6.Models
{
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<BookAuthor> BookAuthors { get; set; }
	}
}
