using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnoahRpg.Model
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public string Image { get; set; }
        public List<Item> Items { get; set; }
    }
}
