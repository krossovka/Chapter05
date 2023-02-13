using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Packt.Shared
{
    public class Person : object
    {
        //поля
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapiens";
        //поля только для чтения
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        //конструкторы
        public Person()
        {
            //установка значений по умолчанию для полей,
            //включая поля только для чтения
            Name = "Unknown";
            Instantiated= DateTime.Now;
        }
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated= DateTime.Now;
        }

    }
}