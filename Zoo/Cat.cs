using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Cat : IAnimal
    {
        public string Name { get; private set; }    //Можем узнать имя, но не можем установить имя
        public Cat(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public string Voice()
        {
            return $"Кот {Name} говорит Мяу";
        }
        public string Feed()
        {
            return $"Кот {Name} поел свежей рыбы";
        }
    }
}
