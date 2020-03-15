using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { set; get; }
        public DateTime EndDate { set; get; }
        public IList<SamuraiBattle> BattlesFought { get; set; }
    }
}
