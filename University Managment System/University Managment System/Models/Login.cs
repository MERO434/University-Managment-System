using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public class Login
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "User type is required")]
        public UserRole RoleName { get; set; }
    }
