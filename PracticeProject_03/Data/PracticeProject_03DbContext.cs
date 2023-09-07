using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PracticeProject_03.Data
{
    public class PracticeProject_03DbContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PracticeProject_03DbContext() : base("name=PracticeProject_03DbContext")
        {
        }

        public System.Data.Entity.DbSet<PracticeProject_03.Models.Student> Students { get; set; }
    }
}
