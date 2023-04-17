﻿using System.ComponentModel.DataAnnotations;

namespace PractiFly.WebApi.Dto.Admin.UserView
{
    public class UserProfileForAdminCreateDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(128)]
        public string Surname { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MaxLength(128)]
        public string Email { get; set; } = null!;

        [Required]
        [Phone]
        [MaxLength(32)]
        public string Phone { get; set; } = null!;

        [Required]
        [Url]
        [MaxLength(2048)]
        public string FilePhoto { get; set; } = null!;

        [Required]
        [MaxLength(64)]
        public string Role { get; set; } = null!;
    }
}
