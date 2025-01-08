using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

    public class AcademicGrade
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public int StudentId { get; set; } // Foreign Key

        [ForeignKey("StudentId")]
        public Student Student { get; set; }

        [Required]
        public int CourseId { get; set; } // Foreign Key

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [Required]
        [Range(0, 100)]
        public double Score { get; set; } // Score
    }