using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsersApi.src.users.DTO
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "Name is required")]
        [MaxLength(60, ErrorMessage = "Name cannot exceed more than 60 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [MaxLength(60, ErrorMessage = "Email cannot exceed more than 60 characters")]
        public string Email{ get; set; }
        [Required(ErrorMessage = "Phone is required")]
        [MaxLength(13, ErrorMessage = "Input format is +998912345678")]
        public string Phone { get; set; }

    }
}
