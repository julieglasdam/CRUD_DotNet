using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace Project02.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TestObject> Table01 { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlite("Filename=./Database.db");
        } 
        
    }

    public class TestObject {
        public int TestObjectId{get; set;}
        public string Field01{get; set;}
    }
    
}