using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Presentation
{
    class Program
    {
        private static EFDataContext _context = new EFDataContext();

        static void Main(string[] args)
        {
            //AddSamurai();
            InsertVariousTypes();
            //GetSamurais("Samurais:");
            QueryFilters();
            Console.ReadKey();
        }

        private static void AddSamurai()
        {
            _context.Samurais.Add(new Samurai()
            {
                Name = "Toyotomi Hideyoshi"
            });

            _context.SaveChanges();
        }

        private static void InsertVariousTypes()
        {
            var samurai = new Samurai { Name = "Date Masamune" };

            var clan = new Clan { Name = "Soul Rebels" };

            _context.AddRange(samurai, clan);
            _context.SaveChanges();
        }

        private static async void QueryFilters()
        {
            var name = "Date";
            var filter = "%e";
            var samurais =  await _context.Samurais.Where(s => EF.Functions.Like(s.Name, filter)).ToListAsync();
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }

        private static void GetSamurais(string text)
        {
            Console.WriteLine(text);
            var samurais = _context.Samurais.ToList();
            foreach (var samurai in samurais)
            {
                Console.WriteLine(samurai.Name);
            }
        }
    }
}
