using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace LibraryManagementSystem.Core.ViewModels
{
	public class SubscriberFormViewModel
	{

		public string Id { get; set; }

		[MaxLength(50, ErrorMessage = ValidationMessages.MaxLength)]
		[Display(Name = "First Name")]
		[RegularExpression(RegexPatterns.CharactersOnly_Eng, ErrorMessage = ValidationMessages.OnlyEnglishLetters)]
		public string FirstName { get; set; } = null!;

		[MaxLength(50, ErrorMessage = ValidationMessages.MaxLength)]
		[Display(Name = "Second Name")]
		[RegularExpression(RegexPatterns.CharactersOnly_Eng, ErrorMessage = ValidationMessages.OnlyEnglishLetters)]
		public string SecondName { get; set; } = null!;

		public string FullName => $"{FirstName} {SecondName}";

		[DataType(DataType.Date)]
		[AssertThat("DateOfBirth > (DateTime.Now).AddYears(-18)", ErrorMessage = "The date must be today or earlier.")]
		// [Assert that] it's a property by using ExpressiveAnnotations packeg  to check on the server side that PublishingDate <= Today()
		public DateTime DateOfBirth { get; set; }

		[MaxLength(14, ErrorMessage = ValidationMessages.MaxLength)]
		[RegularExpression(RegexPatterns.NationalId, ErrorMessage = ValidationMessages.InvalidNationalId)]
		public string NationalID { get; set; } = null!;

		[MaxLength(200, ErrorMessage = ValidationMessages.MaxLength)]
		[EmailAddress]
		[Remote("AllowEmail", AdditionalFields = nameof(Id), ErrorMessage = ValidationMessages.Duplicated)]
		public string Email { get; set; } = null!;

		[MaxLength(10, ErrorMessage = ValidationMessages.MaxLength)]
		[Phone]
		[Remote("AllowPhone", AdditionalFields = nameof(Id), ErrorMessage = ValidationMessages.Duplicated)]
		[RegularExpression(RegexPatterns.MobileNumber, ErrorMessage = ValidationMessages.InvalidMobileNumber)]
		public string PhoneNumber { get; set; } = null!;

		public int GovernorateId { get; set; }
		public int AreaId { get; set; }
		public string Address { get; set; } = null!;
		public bool HasWhatsApp { get; set; }
		public string ImageUrl { get; set; } = null!;
	}
}
