using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    public int? AdministratorId { get; set; } // Nullable, as a department may not have an administrator

    // Navigation property for Administrator
    [ForeignKey("AdministratorId")]
    public Administrator Administrator { get; set; }

    public ICollection<Course> Courses { get; set; } = new List<Course>();

    [Required]
        public int FacultyId { get; set; }

        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }
    }
