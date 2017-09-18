using System.ComponentModel.DataAnnotations;

namespace IsusCoreFullNet2017Spa.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [MaxLength(32)]
        public string Theme { get; set; }
    }
}