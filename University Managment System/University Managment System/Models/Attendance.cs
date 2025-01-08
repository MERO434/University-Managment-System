using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

    public class Attendance
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public int StudentId { get; set; } // Foreign Key for Student

        [ForeignKey("StudentId")]
        public Student Student { get; set; } // Link to Student model

        [Required]
        public int CourseId { get; set; } // Foreign Key for Course

        [ForeignKey("CourseId")]
        public Course Course { get; set; } // Link to Course model

        [Required]
        public DateTime AttendanceDate { get; set; } // Date of attendance

        [Required]
        [MaxLength(50)]
        public string Status { get; set; } // Status (e.g., Present, Absent)
    }
