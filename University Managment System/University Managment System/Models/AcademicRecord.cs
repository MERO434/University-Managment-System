using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;


public class AcademicRecord
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public int StudentId { get; set; } // Foreign Key to Student

        [ForeignKey("StudentId")]
        public Student Student { get; set; } // Navigation property to Student

        [Required]
        public int CourseId { get; set; } // Foreign Key to Course

        [ForeignKey("CourseId")]
        public Course Course { get; set; } // Navigation property to Course

        [Required]
        [Range(0, 100)]
        public double Grade { get; set; } // Grade achieved by the student in the course

        [Required]
        public string AcademicYear { get; set; } // e.g., "2023-2024"

        [Required]
        public int SemesterId { get; set; }

        [ForeignKey("SemesterId")]
        public Semester Semester { get; set; } // e.g., "Fall", "Spring"

        public DateTime DateRecorded { get; set; } = DateTime.Now; // Date the record was created
    }