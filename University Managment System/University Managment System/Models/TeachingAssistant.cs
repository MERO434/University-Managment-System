using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public class TeachingAssistant
    {
        public int TeachingAssistantId { get; set; } // Primary Key

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public ICollection<Course> Courses { get; set; } = []; // Courses assisted by the TA

        [Required]
        public string OfficeHours { get; set; } // Office hours schedule

        [Required]
        public TeachingAssistantRole RoleDescription { get; set; } // Description of duties
    [Required]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; } // Navigation Property to Role
}

    public enum TeachingAssistantRole
    {
        Grader,
        Tutor,
        LabAssistant
    }
