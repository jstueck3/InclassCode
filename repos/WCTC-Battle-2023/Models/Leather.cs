using Class05.Interfaces;
using System;

namespace Class05.Models
{
    public class Leather : IArmor
    {
        public string Name { get; set; }
        public int Defense { get; set; }

        // default constructor
        public Leather()
        {
            Name = "Leather Armor";
            Defense = 11;
        }
        // constructor
        public Leather(string name, int defense)
        {
            Name = name;
            Defense = defense;
        }

        // method
        public void MyMethod()
        {

        }
    }

}
