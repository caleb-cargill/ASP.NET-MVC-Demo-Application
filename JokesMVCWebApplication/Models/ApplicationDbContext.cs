using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesMVCWebApplication.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// Used to perform CRUD operations on the Joke table in the DB
        /// Including this property specifies to EFCore to generate the table if it does not already exist
        /// See more on Code-First approach with EFCore -> https://www.entityframeworktutorial.net/code-first/simple-code-first-example.aspx
        /// </summary>
        public DbSet<Joke> Jokes { get; set; }
    }
}
