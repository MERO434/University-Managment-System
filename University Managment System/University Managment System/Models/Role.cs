using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public enum UserRole
    {
        Student,
        Admin,
        Professor,
        TeachingAssistant,
        Faculty 
    }

    public class Role
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public string RoleName { get; set; } // Name of the role (e.g., Student, Professor, Admin)

        // Navigation Property
        public ICollection<User> Users { get; set; } = []; // Users associated with this role
    public ICollection<Student> Students { get; set; } = new List<Student>();
    public ICollection<Professor> Professors { get; set; } = new List<Professor>();
    public ICollection<TeachingAssistant> TeachingAssistants { get; set; } = new List<TeachingAssistant>();
    public ICollection<Administrator> Administrators { get; set; } = new List<Administrator>();
    public ICollection<Faculty> Faculties { get; set; } = new List<Faculty>();
}
