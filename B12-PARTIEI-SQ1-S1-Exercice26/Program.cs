using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12_PARTIEI_SQ1_S1_Exercice26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //cette version est issue de la branche
            int nombre = -1;
            string heures, minutes, secondes, resultat;
            do
            {
                Console.WriteLine("Veuillez saisir un nombre compris entre 0 et 86400");
                Console.Write("====>");
                nombre = int.Parse(Console.ReadLine());
            } while (nombre < 0 && nombre > 86400);
            heures = (nombre / 3600).ToString();
            nombre %= 3600;
            minutes = (nombre / 60).ToString();
            nombre %= 60;
            secondes = nombre.ToString();
            while (heures.Length < 2)
            {
                heures = heures.Insert(1, "0");
            } 
            while (minutes.Length < 2)
            {
                minutes = minutes.Insert(1, "0");
            } 
            while (secondes.Length < 2)
            {
                secondes = secondes.Insert(1, "0");
            }
            resultat = heures + ":" + minutes + ":" + secondes;
            Console.WriteLine(resultat);
            Console.ReadKey();
        }
    }
}
