using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

    public class Faculty
    {
        public int Id { get; set; } // Primary Key

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; } // First Name

        [Required]
        [StringLength(50)]
        public string LastName { get; set; } // Last Name

        [Required]
        [EmailAddress]
        public string Email { get; set; } // Email Address

        [Required]
        public string PasswordHash { get; set; }

        public ICollection<Department> Departments { get; set; }
        public ICollection<Course> Courses { get; set; }
    [Required]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; } // Navigation Property to Role
}
