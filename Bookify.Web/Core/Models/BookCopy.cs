namespace LibraryManagementSystem.Core.Models
{
	public class BookCopy : BaseModel
	{

		public int Id { get; set; }
		public int BookId { get; set; }

		public Book? Book { get; set; }

		public bool IsAvailableforRental { get; set; }

		public int EditionNumber { get; set; }

		public int SerialNumber { get; set; }

		public bool IsDeleted { get; set; }

		public DateTime CreatedOn { get; set; } = DateTime.Now;

		//public ICollection<RenterCopy> Rentals { get; set; } = new List<RenterCopy>();

	}
}
