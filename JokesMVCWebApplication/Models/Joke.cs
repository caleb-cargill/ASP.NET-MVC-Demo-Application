using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JokesMVCWebApplication.Models
{
    /// <summary>
    /// Joke Model as a POCO to hold domain-specific data and business logic
    /// Used to interact with the DB
    /// DB Table definitions created automatically from this definition
    /// </summary>
    public class Joke
    {
        // Key attribute denote that the property shall be unique (primary key)
        [Key]        
        public int Id { get; set; }

        // Required attribute specifies that a property is required to be filled
        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

        public string Author { get; set; }

    }
}
