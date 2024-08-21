using Microsoft.AspNetCore.Mvc.Rendering;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace LibraryManagementSystem.Core.ViewModels
{
	public class UserFormViewModel
	{
		public string? Id { get; set; }

		[MaxLength(100, ErrorMessage = ValidationMessages.MaxLength)]
		[Display(Name = "Full Name")]
		[RegularExpression(RegexPatterns.CharactersOnly_Eng, ErrorMessage = ValidationMessages.OnlyEnglishLetters)]
		public string FullName { get; set; } = null!;

		[MaxLength(20, ErrorMessage = ValidationMessages.MaxLength)]
		[Display(Name = "Username")]
		[RegularExpression(RegexPatterns.Username, ErrorMessage = ValidationMessages.InvalidUsername)]
		[Remote("AllowUserName", null!, AdditionalFields = "Id", ErrorMessage = ValidationMessages.Duplicated)]
		public string UserName { get; set; } = null!;

		[MaxLength(200, ErrorMessage = ValidationMessages.MaxLength)]
		[EmailAddress]
		[Remote("AllowEmail", null!, AdditionalFields = "Id", ErrorMessage = ValidationMessages.Duplicated)]
		public string Email { get; set; } = null!;

		[DataType(DataType.Password)]
		[StringLength(100, ErrorMessage = ValidationMessages.MaxMinLength, MinimumLength = 8)]
		[RegularExpression(RegexPatterns.Password, ErrorMessage = ValidationMessages.WeakPassword)]
		[RequiredIf("Id == null", ErrorMessage = ValidationMessages.RequiredField)]
		public string? Password { get; set; } = null!;

		[DataType(DataType.Password)]
		[Display(Name = "Confirm Password")]
		[Compare("Password", ErrorMessage = ValidationMessages.ConfirmPasswordNotMatch)]
		[RequiredIf("Id == null", ErrorMessage = ValidationMessages.RequiredField)]
		public string? ConfirmPassword { get; set; } = null!;

		[Display(Name = "Roles")]
		public IList<string> SelectedRoles { get; set; } = new List<string>();

		public IEnumerable<SelectListItem>? Roles { get; set; }


	}
}
