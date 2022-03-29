using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Parrot:IAnimal
    {
        public string Name { get; private set; }
        public Parrot(string name)
        {
            Name = name;
        }
        public string Fly(int time)
        {
            return $"{Name} летал по вольеру в течении {time} минут";
        }
        public string GetName()
        {
            return Name;
        }
        public string Voice()
        {
            return $"Попугай {Name} повторяет за людьми";
        }
        public string Feed()
        {
            return $"Попугай {Name} поел вкусных семечек";
        }
    }
}
