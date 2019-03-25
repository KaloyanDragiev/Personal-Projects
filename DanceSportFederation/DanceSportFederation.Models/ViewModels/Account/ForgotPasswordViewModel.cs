﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DanceSportFederation.Models.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}