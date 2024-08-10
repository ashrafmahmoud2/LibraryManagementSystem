using LibraryManagementSystem.Core.consts;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace Bookify.Web.Core.ViewModels
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = ValidationMessages.MaxLength)]
        [Remote("AllowItem", null!, AdditionalFields = "Id", ErrorMessage = ValidationMessages.Duplicated)] 
		public string Name { get; set; } = null!;
    }
}