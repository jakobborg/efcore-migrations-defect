﻿using EFCore.Model;
using EFCore.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EFCore
{
    static class Program
    {
        private static IConfiguration config;

        static void Main(string[] args)
        {
            config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            var context = GetContext();

            context.Database.EnsureDeleted();
            context.Database.Migrate();
        }

        private static DefaultContext GetContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DefaultContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("Db"));

            return new DefaultContext(optionsBuilder.Options);

        }
    }
}
