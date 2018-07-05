using System.ComponentModel.DataAnnotations;

namespace Reminder_desktop_application
{
    public class UserSettingsModel
    {
        [Key]
        public int Id { get; set; }
        public string mailUserName { get; set; }
        public string vkToken { get; set; }
        public string vkUser { get; set; }
        [Required]
        public bool mailMessageFlag { get; set; }
        [Required]
        public bool vkMessageFlag { get; set; }
        [Required]
        public int fontSize { get; set; }

        [Required]
        public string login { get; set; }

        [Required]
        public string password { get; set; }

        public string secretWord { get; set; }

    }
}
