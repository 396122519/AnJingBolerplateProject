using System.ComponentModel.DataAnnotations;

namespace AnJingBolerplateProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}