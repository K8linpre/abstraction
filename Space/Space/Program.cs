﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceStation Lasersound = new Deathstar("Pew Pew");
            Console.WriteLine(Lasersound.Firelaser);
            Console.ReadLine();
        }

    }
}
