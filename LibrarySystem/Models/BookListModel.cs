using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Models
{

    public class BookListModel
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string? Name { get; set; }
        [Required]
        public string? Author { get; set; }
        [Required]
        public string? Publisher { get; set; }
        [Required]
        public string? Genre { get; set; }


    }
}
