using System.ComponentModel.DataAnnotations;

using University_Managment_System;

    public class Day
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
