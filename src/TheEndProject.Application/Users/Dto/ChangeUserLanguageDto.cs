using System.ComponentModel.DataAnnotations;

namespace TheEndProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}