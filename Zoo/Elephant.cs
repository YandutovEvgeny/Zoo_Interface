using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Elephant : IAnimal
    {
        public string Name { get; private set; }    
        public Elephant(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public string Voice()
        {
            return $"Слон {Name} говорит УУУУууУу";
        }
        public string Feed()
        {
            return $"Слон {Name} поел свежей травки";
        }
    }
}
