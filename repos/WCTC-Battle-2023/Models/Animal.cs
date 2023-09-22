using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Owner Owner { get; set; }
        public string Type { get; set; }
    }

    public class Owner
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
