using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Saisissez votre nom et prenom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Bonjour Monsieur " + nom+".");
            Console.ReadLine();
        }
    }
}
