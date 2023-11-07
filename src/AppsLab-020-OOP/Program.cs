﻿using AppsLab_020_OOP;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mojmag = new Mage();
            mojmag.name = "Ferenci";
            mojmag.Health = 250;
            mojmag.Attack = 80;
            Warrior mojwar = new Warrior();
            mojwar.name = "Darius";
            mojmag.Health = 300;
            mojmag.Attack = 65;
            Tank mojtan = new Tank();
            mojtan.name = "Sion";
            mojtan.Health = 500;
            mojtan.Attack = 35;
        }
    }
}
