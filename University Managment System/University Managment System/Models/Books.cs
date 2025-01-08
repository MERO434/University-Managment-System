using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public class Books
    {
        public int Id { get; set; } // Primary Key

        [Required]
        public string BookTitle { get; set; } // Title of the book

        [Required]
        public string Author { get; set; } // Author of the book

        [Required]
        public string ISBN { get; set; } // ISBN number of the book

        public int CopiesAvailable { get; set; } // Number of copies available in the library

        public ICollection<BookLoans> BookLoans { get; set; } = []; // Collection of book loans related to this book
    
}