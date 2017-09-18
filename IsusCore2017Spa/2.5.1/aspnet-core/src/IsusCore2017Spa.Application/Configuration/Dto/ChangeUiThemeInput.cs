﻿using System.ComponentModel.DataAnnotations;

namespace IsusCore2017Spa.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [MaxLength(32)]
        public string Theme { get; set; }
    }
}