﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Quote
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int SamuraiId { get; set; }
        public Samurai Samurai { get; set; }
    }
}
