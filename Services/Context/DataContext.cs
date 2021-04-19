using Microsoft.EntityFrameworkCore;
using PrometheusAPI.Models;
using System.Collections.Generic;

namespace PrometheusAPI.Services.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Login> UserInfoSql { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            var fixedData = new List<Login>(){
                new Login(){
                    Id=1,
                    Username="Angel",
                    Password="password"
                },
                new Login(){
                    Id=2,
                    Username="Chandler",
                    Password="password"
                },
                new Login(){
                    Id=3,
                    Username="Ken",
                    Password="password"
                }
            };
            builder.Entity<Login>().HasData(fixedData);
        }
    }
}