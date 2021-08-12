using System;

namespace First.Models
{
    public class Character
    {
        public int Id { get; set; }
        public String Name { get; set; } = "Chandu-default name";
        public RpgName.Rpg Class { get; set; } = RpgName.Rpg.Knite;
    }
}