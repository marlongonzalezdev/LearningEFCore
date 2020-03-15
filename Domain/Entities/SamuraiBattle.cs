using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class SamuraiBattle
    {
        public int SamuraiId { get; set; }
        public int BattleId { get; set; }

        //navigation properties are optional
        public Samurai Samurai { get; set; }
        public Battle Battle { get; set; }
    }
}
