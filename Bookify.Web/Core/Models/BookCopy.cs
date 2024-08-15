namespace LibraryManagementSystem.Core.Models
{
	public class BookCopy
	{

		public int Id { get; set; }
		public int BookId { get; set; }

		public Book? Book { get; set; }

		public bool IsAvailableforRental { get; set; }

		public int EditionNumber { get; set; }

		public int SerialNumber { get; set; }

		//public ICollection<RenterCopy> Rentals { get; set; } = new List<RenterCopy>();

	}
}
