using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPet2
{
    public class Animal
    {
        private DateTime DataAtual = DateTime.Now;
        private Guid Codigo = Guid.NewGuid();
        public string Nome { get; set; }
        public Especie Especie { get; set; }
        public string Raca { get; set; }
        public string Cor { get; set; }
        public Porte Porte { get; set; }
        public decimal Peso { get; set; }
        public DateTime Nascimento { get; set; }
        public int Idade { get { return CalculaIdade(); } }
        public List<string> DoencasAlergias { get; set; } = new();
        public bool Necessidades { get; set; }
        public bool Agressivo { get; set; }
        public char Sexo { get; set; }
        public bool Castrado { get; set; }
        private DateTime DataCadastrado { get { return DataAtual; } }

        public List<string> ObterNecessidadesEspeciais()
        {
            return DoencasAlergias;
        }

        public bool NecessidadesEspeciais()
        {
            return Necessidades;
        }

        private int CalculaIdade()
        {
            if (Nascimento.DayOfYear <= DateTime.Now.DayOfYear)
            {
                return DateTime.Now.Year - Nascimento.Year;
            }
            else
            {
                return DateTime.Now.Year - Nascimento.Year - 1;
            }
        }

        public void RegistrarNascimento(int ano, int mes, int dia = 1)
        {
            Nascimento = new DateTime(ano, mes, dia);
        }
        public void AdicionarDoencasAlergias(string doencaAlergia)
        {
            DoencasAlergias.Add(doencaAlergia);
        }

        public void ImprimirAnimal()
        {
            Console.WriteLine("\nDados do cadastro");
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Espécie: " + Especie);
            Console.WriteLine("Raça: " + Raca);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Porte: " + Porte);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Nascimento: " + Nascimento.ToShortDateString());
            Console.WriteLine("Idade: " + Idade);
            Console.WriteLine("Possui doenças ou alergias: " + Necessidades);
            if (NecessidadesEspeciais())
            {
                Console.WriteLine("Doenças e Alergias:");
                foreach (string doencaalergia in DoencasAlergias)
                {
                    Console.WriteLine(doencaalergia);
                }
            }
            Console.WriteLine("Agressivo: " + Agressivo);
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Castrado: " + Castrado);
            Console.WriteLine("Data de Cadastro: " + DataCadastrado);
        }
    }
}
