using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using University_Managment_System;

    public class Grievance
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public int UserId { get; set; } // Foreign Key to the User (Student or Professor)

        [ForeignKey("UserId")]
        public User User { get; set; } // Navigation property to User

        [Required]
        [StringLength(100)]
        public string GrievanceType { get; set; } // Grievance Type (e.g., Complaint, Suggestion)

        [Required]
        public string Description { get; set; } // Grievance description

        public GrievanceStatus Status { get; set; } = GrievanceStatus.Pending; // e.g., Pending, Resolved

        public DateTime CreatedAt { get; set; } = DateTime.Now; // Timestamp of grievance creation

        public DateTime? ResolvedAt { get; set; } // Timestamp of grievance resolution
    }

    public enum GrievanceStatus
    {
        Pending,
        Resolved
    }
