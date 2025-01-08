using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

public class LectureClassroom
    {
        public int Id { get; set; } // Primary Key

        [Required]
        [StringLength(10)]
        public string RoomNumber { get; set; } // Room number

        [Required]
        public string Building { get; set; } // Name of the building

        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive number.")]
        public int Capacity { get; set; } // Maximum capacity of the classroom

        [Required]
        public int SemesterId { get; set; }

        [ForeignKey("SemesterId")]
        public Semester Semester { get; set; } // e.g., "Fall", "Spring"
    }
