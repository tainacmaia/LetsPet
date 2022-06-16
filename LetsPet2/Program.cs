using System.Text.RegularExpressions;

namespace LetsPet2
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataValida;
            string teste;
            Animal pet = new Animal();
            Console.WriteLine("Cadastro do animal");
            do
            {
                Console.WriteLine("Nome:");
                pet.Nome = Console.ReadLine();
            } while (!Validar.BrancoNulo(pet.Nome));
            do
            {
                Textos.ListaEspecie();
                teste = Console.ReadLine();
            } while (!Validar.Opcao(teste)); //verificar se funciona
            pet.Especie = (Especie)int.Parse(teste);
            do
            {
                Console.WriteLine("Raça:");
                pet.Raca = Console.ReadLine();
            } while (!Validar.BrancoNulo(pet.Raca));
            do
            {
                Console.WriteLine("Cor:");
                pet.Cor = Console.ReadLine();
            } while (!Validar.BrancoNulo(pet.Cor));
            do
            {
                Textos.ListaPorte();
                teste = Console.ReadLine();
            } while (!Validar.Opcao(teste)); //aplicar pros outros
            pet.Porte = (Porte)int.Parse(teste);
            do
            {
                Console.WriteLine("Peso:");
                teste = Console.ReadLine();
            } while (!Validar.Peso(teste));
            pet.Peso = int.Parse(teste);
            do
            {
                do
                {
                    Console.WriteLine("Data de Nascimento (dd/mm/aaaa):");
                    dataValida = Console.ReadLine();
                } while (!Validar.Data(dataValida));
                pet.Nascimento = DateTime.Parse(dataValida);
            } while (!Validar.Idade(pet.Nascimento, DateTime.Now));
            do
            {
                Console.WriteLine("Possui deficiências, doenças ou alergias (S/N)?");
                teste =Console.ReadLine();
            } while (!Validar.Resposta(teste));
            pet.Necessidades = Validar.SimNao(teste);
            if (pet.Necessidades)
            {
                do
                {
                    Console.WriteLine("Quais?");
                    pet.AdicionarDoencasAlergias(Console.ReadLine());
                    do
                    {
                        Console.WriteLine("Mais alguma? (S/N)");
                        teste = Console.ReadLine();
                    } while(!Validar.Resposta(teste));
                } while (teste == "S");
            }
            do
            {
                Console.WriteLine("Agressivo (S/N):");
                teste = Console.ReadLine();
            } while (!Validar.Resposta(teste));
            pet.Agressivo = Validar.SimNao(teste);
            do
            {
                Console.WriteLine("Sexo (F/M):");
                teste = Console.ReadLine();
            } while (!Validar.Sexo(teste));
            pet.Sexo = char.Parse(teste);
            do
            {
                Console.WriteLine("Castrado (S/N):");
                teste = Console.ReadLine();
            } while (!Validar.Resposta(teste));
            pet.Castrado = Validar.SimNao(teste);
            pet.ImprimirAnimal();
        }
    }
}
