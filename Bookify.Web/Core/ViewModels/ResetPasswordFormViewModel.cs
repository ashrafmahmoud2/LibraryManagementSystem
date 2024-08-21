namespace LibraryManagementSystem.Core.ViewModels
{
	public class ResetPasswordFormViewModel
	{
		public string Id { get; set; } = null!;
		[DataType(DataType.Password),
			StringLength(100, ErrorMessage = ValidationMessages.MaxMinLength, MinimumLength = 8),
			RegularExpression(RegexPatterns.Password, ErrorMessage = ValidationMessages.WeakPassword)]
		public string Password { get; set; } = null!;

		[DataType(DataType.Password), Display(Name = "Confirm password"),
			Compare("Password", ErrorMessage = ValidationMessages.ConfirmPasswordNotMatch)]
		public string ConfirmPassword { get; set; } = null!;


	}
}
