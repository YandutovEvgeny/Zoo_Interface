using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    interface IAnimal
    {
        //Интерфейс - Частный случай абстрактного класса, это общее название какой-то группы, общие биологические признаки
        //Интерфейс = все абстрактные методы
        //Интерфейс позволяет объеденить множество разных классов, в одну коллекцию
        string GetName();
        string Voice();
        string Feed();
    }
}
