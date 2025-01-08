using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using University_Managment_System;

public class SectionClassSchedule
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public int CourseId { get; set; } // Foreign Key

        [ForeignKey("CourseId")]
        public Course Course { get; set; }

        [Required]
        public int RoomId { get; set; } // Foreign Key

        [ForeignKey("RoomId")]
        public SectionRoom Room { get; set; }

        [Required]
        public int TeachingAssistantId { get; set; }

        [ForeignKey("TeachingAssistantId")]
        public TeachingAssistant TeachingAssistant { get; set; }

        [Required]
        public int SemesterId { get; set; }

        [ForeignKey("SemesterId")]
        public Semester Semester { get; set; } // e.g., "Fall", "Spring"

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public DayOfWeek Day { get; set; } // Day of the week
    }
