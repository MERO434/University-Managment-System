using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

    
    public class User
    {
        public int Id { get; set; } // Primary Key

    [Required(ErrorMessage = "Full Name is required")]
    [StringLength(100, ErrorMessage = "Full Name cannot exceed 100 characters")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; } // Unique Email

    [Required(ErrorMessage = "Password Hash is required")]
    public string PasswordHash { get; set; } // Hashed Password

    [Required]
        public int RoleId { get; set; } // Foreign Key to Role

        [ForeignKey("RoleId")]
        public Role Role { get; set; } // Navigation Property
    }