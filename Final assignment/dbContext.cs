using System;
using System.Data.Entity;

namespace EFCodeFirstExample
{
    public class SchoolContext : DbContext
    {
        // This DbSet represents the Students table in the database
        public DbSet<Student> Students { get; set; }

        // Constructor specifies the database connection string (name "SchoolDB")
        public SchoolContext() : base("SchoolDB")
        {
        }
    }
}