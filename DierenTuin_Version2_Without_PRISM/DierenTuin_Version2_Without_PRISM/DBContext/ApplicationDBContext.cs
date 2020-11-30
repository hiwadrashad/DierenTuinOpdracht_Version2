using DierenTuin_Version2_Without_PRISM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DierenTuin_Version2_Without_PRISM.DBContext
{
    class ApplicationDBContext
    {
        public class ApplicationDbContext
        {
            private static ApplicationDbContext _dbContext;
            public ApplicationDbContext()
            {
            }

            public static ApplicationDbContext GetDbcontext()
            {
                if (_dbContext != null)
                {
                    _dbContext = new ApplicationDbContext();
                }
                return _dbContext;
            }

            public DbSet<ApeModel> bestellingModels { get; set; }

            public DbSet<LionModel> customerModels { get; set; }

            public DbSet<ElephantModel> employeeModels { get; set; }

            public static ApplicationDbContext Create()
            {
                return new ApplicationDbContext();
            }
        }
    }
}
