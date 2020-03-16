using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Presentation
{
    class Program
    {
        private static EFDataContext _context = new EFDataContext();
        
        static void Main(string[] args)
        {
            AddSamurai();
            GetSamurais("Samurais:");
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
