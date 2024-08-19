
using Bookify.Web.Core.Consts;

namespace LibraryManagementSystem.Core.ViewModels
{
    public class CategoryFormViewModel
    {
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = ValidationMessages.MaxLength), Display(Name = "Author")]
        [Remote("AllowItem", null!, AdditionalFields = "Id", ErrorMessage = ValidationMessages.Duplicated)]
        [RegularExpression(RegexPatterns.CharactersOnly_Eng, ErrorMessage = ValidationMessages.OnlyEnglishLetters)]

        public string Name { get; set; } = null!;
    }
}