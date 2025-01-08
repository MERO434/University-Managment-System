using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

public class LectureClassSchedule
    {
        public int Id { get; set; }

        [Required]
        public int CourseId { get; set; }

        [ForeignKey("CourseId")]
        public Course Course { get; set; } // Link to Course model

        [Required]
        public int SemesterId { get; set; }

        [ForeignKey("SemesterId")]
        public Semester Semester { get; set; }

        [Required]
        public int ProfessorId { get; set; }

        [ForeignKey("ProfessorId")]
        public Professor Professor { get; set; }

        [Required]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        public TimeSpan TimeSlot { get; set; }

        [Required]
        public int LectureClassroomId { get; set; }

        [ForeignKey("LectureClassroomId")]
        public LectureClassroom LectureClassroom { get; set; }
    }
