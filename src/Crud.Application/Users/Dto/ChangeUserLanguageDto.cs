using System.ComponentModel.DataAnnotations;

namespace Crud.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}