﻿namespace Identity.Models
{
    public class RegisterConfirmationModel
    {
        public string? Email { get; set; }
        public bool DisplayConfirmAccountLink { get; set; }
        public string? EmailConfirmationUrl { get; set; }
    }
}
