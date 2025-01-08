using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Reflection.Metadata.BlobBuilder;

using University_Managment_System;

    public class BookLoans
    {
        public int Id { get; set; } // Primary Key

    [Required(ErrorMessage = "Student ID is required")]
    public int StudentId { get; set; } // Foreign Key

    [Required(ErrorMessage = "Loan Date is required")]
    [DataType(DataType.Date)]
    public DateTime LoanDate { get; set; } // Date when the book was loaned

    [DataType(DataType.Date)]
    public DateTime? ReturnDate { get; set; } // Optional // Date when the book was returned (nullable)

    [ForeignKey("StudentId")]
        public Student Student { get; set; }

    [Required(ErrorMessage = "Book ID is required")]
    public int BookId { get; set; } // Foreign Key

    [ForeignKey("BookId")]
        public Books Book { get; set; } // Navigation property to Book
    }
