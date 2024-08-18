namespace LibraryManagementSystem.Core.ViewModels
{
    public class AuthorFormViewModel
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = ValidationMessages.MaxLength), Display(Name = "Category")]
        [Remote("AllowItem", null!, AdditionalFields = "Id", ErrorMessage = ValidationMessages.Duplicated)]
        public string Name { get; set; } = null!;

    }
}
