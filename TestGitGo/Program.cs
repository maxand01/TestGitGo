﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitGo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new Personne();
            p1.Nom = "Ketchum";
            p1.Prenom = "Sacha";
            Console.WriteLine(p1.Nom + " " + p1.Prenom);

            Console.ReadKey();

        }
    }
}
