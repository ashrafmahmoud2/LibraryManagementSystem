namespace LibraryManagementSystem.Core.Models
{

	[Index(nameof(FullName), IsUnique = true)]
	[Index(nameof(NationalID), IsUnique = true)]
	[Index(nameof(Email), IsUnique = true)]
	public class Subscriber
	{

		//add conntru area

		public int Id { get; set; }
		public string FirstName { get; set; } = null!;
		public string SecondName { get; set; } = null!;
		public string FullName => $"{FirstName} {SecondName}"; 
		public DateTime DateOfBirth { get; set; }
		public string NationalID { get; set; } = null!;
		public string Email { get; set; } = null!;
		public string PhoneNumber { get; set; } = null!;
		public int GovernorateId { get; set; }
		public int AreaId { get; set; }
		public string Address { get; set; } = null!;
		public bool HasWhatsApp { get; set; }
		public string ImageUrl { get; set; } = null!;

	}
}
