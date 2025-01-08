using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public class RegistrationGenerator
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public string RegistrationNumber { get; set; } // Unique registration number

        [Required]
        public int StudentId { get; set; } // Foreign Key to Student

        [ForeignKey("StudentId")]
        public Student Student { get; set; } // Navigation Property

        // Method to generate a new registration number
        public static string GenerateRegistrationNumber()
        {
            return $"REG{DateTime.Now.Year}{Guid.NewGuid().ToString().Substring(0, 4).ToUpper()}";
        }
    }
