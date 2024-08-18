namespace LibraryManagementSystem.Core.ViewModels
{
    public class BookCopyFormViewModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }

        [Display(Name = "Is Available For Rental ")]
        public bool IsAvailableForRental { get; set; }
		

		[Display(Name = "EditionNumber"), Range(1,1000,ErrorMessage =ValidationMessages.InvalidRange)]
        public int EditionNumber { get; set; }
         public bool ShowRentalInput { get; set; }

    }
}
