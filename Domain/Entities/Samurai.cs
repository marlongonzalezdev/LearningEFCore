using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Domain.Entities
{
    public class Samurai
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Clan Clan { get; set; }
        public List<Quote> Quotes { get; set; }

        public Samurai()
        {
            Quotes = new List<Quote>();
        }
    }
}
