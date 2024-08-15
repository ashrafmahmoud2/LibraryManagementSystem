
namespace LibraryManagementSystem.Core.ViewModels
{
	public class CategoryFormViewModel
	{
		public int Id { get; set; }

		[MaxLength(100, ErrorMessage = ValidationMessages.MaxLength), Display(Name = "Author")]
		[Remote("AllowItem", null!, AdditionalFields = "Id", ErrorMessage = ValidationMessages.Duplicated)]
		public string Name { get; set; } = null!;
	}
}