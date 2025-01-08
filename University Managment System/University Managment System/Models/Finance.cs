using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

public class Finance
    {
        public int Id { get; set; } // Primary Key

    [Required(ErrorMessage = "Student ID is required")]
    public int StudentId { get; set; } // Foreign Key to Student

    [ForeignKey("StudentId")]
        public Student Student { get; set; } // Navigation property to Student

    [Required(ErrorMessage = "Amount Due is required")]
    [Range(0, 200000, ErrorMessage = "Amount Due must be between 0 and 200,000")]
    public decimal AmountDue { get; set; } // Amount due

    [Required(ErrorMessage = "Semester ID is required")]
    public int SemesterId { get; set; }


    [ForeignKey("SemesterId")]
        public Semester Semester { get; set; }

        public bool IsPaid { get; set; } // Payment status
    }
