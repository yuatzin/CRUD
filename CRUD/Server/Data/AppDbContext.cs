﻿using CRUD.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUD.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //Referenciamos los modelos que vaya a utilizar Entity Framework. 
        public virtual DbSet<Film> Films { get; set; }
    }
}