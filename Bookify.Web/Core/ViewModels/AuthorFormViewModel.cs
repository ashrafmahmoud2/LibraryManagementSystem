using LibraryManagementSystem.Core.consts;
using Microsoft.AspNetCore.Components.Forms;

namespace LibraryManagementSystem.Core.ViewModels
{
	public class AuthorFormViewModel
	{
		public int Id { get; set; }

		[MaxLength(100,ErrorMessage = ValidationMessages.MaxLength)]
		[Remote("AllowItem",null!,AdditionalFields ="Id",ErrorMessage = ValidationMessages.Duplicated)]
		public string Name { get; set; }=null!;

	}
}
