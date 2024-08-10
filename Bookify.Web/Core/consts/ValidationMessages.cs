namespace LibraryManagementSystem.Core.consts
{
	public static class ValidationMessages
	{
		// General Field Validation
		public const string RequiredField = "Required field";
		public const string MaxLength = "Length cannot be more than {1} characters";
		public const string MaxMinLength = "The {0} must be at least {2} and at max {1} characters long.";

		// Duplicate and Uniqueness Validation
		public const string Duplicated = "Another record with the same {0} already exists!";
		public const string DuplicatedBook = "A book with the same title and author already exists!";

		// File Validation
		public const string NotAllowedExtension = "Only .png, .jpg, .jpeg files are allowed!";
		public const string MaxSize = "File cannot be more than 2 MB!";
		public const string EmptyImage = "Please select an image.";

		// Date Validation
		public const string NotAllowFutureDates = "Date cannot be in the future!";
		public const string InvalidStartDate = "Invalid start date.";
		public const string InvalidEndDate = "Invalid end date.";
		public const string InvalidRange = "{0} should be between {1} and {2}!";

		// Password and Username Validation
		public const string ConfirmPasswordNotMatch = "The password and confirmation password do not match.";
		public const string WeakPassword = "Password must contain an uppercase character, lowercase character, a digit, and a non-alphanumeric character. Passwords must be at least 8 characters long.";
		public const string InvalidUsername = "Username can only contain letters or digits.";

		// Character Validation
		public const string OnlyEnglishLetters = "Only English letters are allowed.";
		public const string OnlyArabicLetters = "Only Arabic letters are allowed.";
		public const string OnlyNumbersAndLetters = "Only Arabic/English letters or digits are allowed.";
		public const string DenySpecialCharacters = "Special characters are not allowed.";

		// Specific Identifiers Validation
		public const string InvalidMobileNumber = "Invalid mobile number.";
		public const string InvalidNationalId = "Invalid national ID.";
		public const string InvalidSerialNumber = "Invalid serial number.";

		// Rental Validation
		public const string NotAvailableForRental = "This book/copy is not available for rental.";
		public const string CopyIsInRental = "This copy is already rented.";
		public const string RentalNotAllowedForBlacklisted = "Rental cannot be extended for blacklisted subscribers.";
		public const string RentalNotAllowedForInactive = "Rental cannot be extended for this subscriber before renewal.";
		public const string ExtendNotAllowed = "Rental cannot be extended.";
		public const string PenaltyShouldBePaid = "Penalty should be paid.";

		// Subscriber Validation
		public const string BlackListedSubscriber = "This subscriber is blacklisted.";
		public const string InactiveSubscriber = "This subscriber is inactive.";
		public const string MaxCopiesReached = "This subscriber has reached the max number for rentals.";
	}

}
