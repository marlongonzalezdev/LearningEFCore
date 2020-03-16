﻿using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class EFDataContext: DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LearningEFCore";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>().HasKey(s => new { s.SamuraiId, s.BattleId});
            modelBuilder.Entity<Horse>().ToTable("Horses");
        }
    }
}
