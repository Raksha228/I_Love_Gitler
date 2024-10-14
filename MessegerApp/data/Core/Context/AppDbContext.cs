﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data.Models;
using Microsoft.EntityFrameworkCore;



namespace data.Core.Context
{
    public class AppDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(getSqliteConnect());
            optionsBuilder.UseLazyLoadingProxies();
        }
        string getSqliteConnect()
        {
            var dir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.Parent;
            return $@"Data source={dir}\ApplicationData\Core\Database\MessangerDB.db";
        }
        public DbSet<User> Users {get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}