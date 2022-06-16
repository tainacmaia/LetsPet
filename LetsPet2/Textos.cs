using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet2
{
    public class Textos
    {
        public static void ListaEspecie()
        {
            int count = 1;
            Console.WriteLine("Qual a espécie? Confira as opções:");
            foreach (Especie especie in Enum.GetValues(typeof(Especie)))
            {
                Console.WriteLine($"{count} - {especie}");
                count++;
            }
        }

        public static void ListaPorte()
        {
            int count = 1;
            Console.WriteLine("Qual o porte? Confira as opções:");
            foreach (Porte porte in Enum.GetValues(typeof(Porte)))
            {
                Console.WriteLine($"{count} - {porte}");
                count++;
            }
        }
    }
}
