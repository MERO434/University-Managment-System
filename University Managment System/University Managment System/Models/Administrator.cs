using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using University_Managment_System;

    public class Administrator
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }


    [Required]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; } // Navigation Property to Role

    // One-to-Many: An administrator can manage multiple departments
    public ICollection<Department> ManagedDepartments { get; set; } = new List<Department>();

    // Many-to-Many: An administrator can manage multiple courses
    public ICollection<Course> ManagedCourses { get; set; } = new List<Course>();
}
