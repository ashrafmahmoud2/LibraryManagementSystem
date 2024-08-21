using Microsoft.AspNetCore.Mvc.Rendering;
using UoN.ExpressiveAnnotations.NetCore.Attributes;



namespace LibraryManagementSystem.Core.ViewModels
{
	public class BookFormViewModel
	{
		public int Id { get; set; }

		[MaxLength(500, ErrorMessage = ValidationMessages.MaxLength)]
		[Remote("AllowItem", null!, AdditionalFields = "Id,AuthorId", ErrorMessage = ValidationMessages.Duplicated)]
		public string Title { get; set; } = null!;

		[Display(Name = "Author")]
		[Remote("AllowItem", null!, AdditionalFields = "Id,Title", ErrorMessage = ValidationMessages.Duplicated)]
		public int AuthorId { get; set; }

		public IEnumerable<SelectListItem>? Authors { get; set; }

		[MaxLength(200, ErrorMessage = ValidationMessages.MaxLength)]
		public string Publisher { get; set; } = null!;

		[Display(Name = "Publishing Date")]
		[AssertThat("PublishingDate <= Today()", ErrorMessage = "The date must be today or earlier.")]
		public DateTime PublishingDate { get; set; } = DateTime.Now;
		// [Assert that] it's a property by using ExpressiveAnnotations packeg  to check on the server side that PublishingDate <= Today()

		public IFormFile? Image { get; set; }

		public string? ImageUrl { get; set; }
		public string? ImageThumbnailUrl { get; set; }

		[MaxLength(50, ErrorMessage = ValidationMessages.MaxLength)]
		public string Hall { get; set; } = null!;

		[Display(Name = "Is available for rental?")]
		public bool IsAvailableForRental { get; set; }

		public string Description { get; set; } = null!;

		[Display(Name = "Categories")]
		public IList<int> SelectedCategories { get; set; } = new List<int>();

		public IEnumerable<SelectListItem>? Categories { get; set; }
	}
}
