namespace LibraryManagementSystem.Core.Models
{
	[Index(Name =nameof(Name),IsUnique = true)]	
	public class Author:BaseModel
	{
		public int Id { get; set; }

		[MaxLength(100)]
		public string Name { get; set; } = null!;
	}
}
