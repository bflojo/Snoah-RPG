using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnoahRpg.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public string Image { get; set; }
        public List<PlayerItem> PlayerItems { get; set; }
        public Location CurrentLocation { get; set; }
    }
}
