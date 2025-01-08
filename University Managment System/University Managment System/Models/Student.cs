using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public class Student
    {
        public int Id { get; set; }

    [Required(ErrorMessage = "First Name is required")]
    [StringLength(50, ErrorMessage = "First Name cannot exceed 50 characters")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Last Name is required")]
    [StringLength(50, ErrorMessage = "Last Name cannot exceed 50 characters")]
    public string LastName { get; set; }


    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Date of Birth is required")]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    [Required(ErrorMessage = "Department ID is required")]
    public int DepartmentId { get; set; }

    [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

    [Required(ErrorMessage = "Phone Number is required")]
    [Phone(ErrorMessage = "Invalid Phone Number")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Password Hash is required")]
    public string PasswordHash { get; set; }
    [Required]
    public int RoleId { get; set; }

    [ForeignKey("RoleId")]
    public Role Role { get; set; } // Navigation Property to Role
    public AcademicRecord AcademicRecord { get; set; } // One-to-one relationship with AcademicRecord
    public ICollection<EnrollStudentInCourse> EnrollStudentInCourses { get; set; } = [];
        public ICollection<FinalGrade> FinalGrades { get; set; } = [];
        public ICollection<Finance> Finances { get; set; } = [];
        public ICollection<AcademicGrade> AcademicGrades { get; set; } = [];
        public ICollection<BookLoans> BookLoans { get; set; } = [];
    }
