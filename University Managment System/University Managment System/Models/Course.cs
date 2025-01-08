using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;
using University_Managment_System;

public class Course
    {
        public int Id { get; set; }

    [Required(ErrorMessage = "Course Name is required")]
    [StringLength(100, ErrorMessage = "Course Name cannot exceed 100 characters")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Credits are required")]
    [Range(1, 10, ErrorMessage = "Credits must be between 1 and 10")]
    public int Credits { get; set; }

    
    [Required(ErrorMessage = "Department ID is required")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }

         [Required(ErrorMessage = "Semester ID is required")]
         public int SemesterId { get; set; }

        [ForeignKey("SemesterId")]
        public Semester Semester { get; set; }

        public ICollection<EnrollStudentInCourse> EnrollStudentInCourses { get; set; } = [];
        public ICollection<AcademicRecord> AcademicRecords { get; set; } = [];
        public ICollection<TeachingAssistant> TeachingAssistants { get; set; } = [];
        public ICollection<FinalGrade> FinalResults { get; set; } = [];
        public ICollection<AcademicGrade> AcademicGrades { get; set; } = [];
        public ICollection<Professor> Professors { get; set; } = [];
    public ICollection<Administrator> Administrators { get; set; } = new List<Administrator>();
}
