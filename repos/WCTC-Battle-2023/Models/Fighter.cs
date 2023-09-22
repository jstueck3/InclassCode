using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class Fighter : ICombatant
    {
        public string Name { get; set; }
        public IArmor Armor { get; set; }
        public IWeapon Weapon { get; set; }

        public Fighter(string name, IArmor armor, IWeapon weapon)
        {
            Name = name;
            Armor = armor;
            Weapon = weapon;
        }

        public void Attack(ICombatant enemy)
        {
            Console.WriteLine($"{this.Name} attacks {enemy.Name} with {this.Weapon.Name}");
        }
    }
}
