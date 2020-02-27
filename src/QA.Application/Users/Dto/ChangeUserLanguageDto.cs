using System.ComponentModel.DataAnnotations;

namespace QA.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}