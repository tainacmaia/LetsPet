using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LetsPet2
{
    internal class Validar
    {
        public static bool Opcao(string teste)
        {
            if (teste != "1" && teste != "2")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Peso(string teste)
        {
            decimal peso;
            if (!decimal.TryParse(teste, out peso))
            {
                return false;
            }
            else
                return true;
        }

        public static bool Data(string data)
        {
            //var pattern = @"\b([0-2]{0,1}[1-9]|(3)[0-1])(\/)(((0){0,1}[1-9])|((1)[0-2]))(\/)\d{4}\b";
            //Regex regex = new Regex(pattern);
            DateTime valido;
            if (!DateTime.TryParse(data, out valido) || valido > DateTime.Now)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Idade(DateTime nascimento, DateTime cadastro)
        {
            int tipoIdade;
            if (nascimento.Year == cadastro.Year && ((cadastro.Month - nascimento.Month) < 2))
            {
                tipoIdade = 1;
            }
            else if (cadastro.Year - nascimento.Year > 20)
            {
                tipoIdade = 2;
            }
            else
            {
                tipoIdade = 3;
            }

            string resposta;
            switch (tipoIdade)
            {
                case 1:
                    {
                        do
                        {
                            Console.WriteLine("Esse pet possui menos de 2 meses. Esse valor está correto? (S/N)");
                            resposta = Console.ReadLine();
                        } while (!Resposta(resposta));
                        if (resposta == "S")
                        {
                            Console.WriteLine("O cadastro será feito, mas não será possível realizar nenhum serviço no momento.");
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    }
                case 2:
                    {
                        do
                        {
                            Console.WriteLine("A idade desse pet é muito alta. Esse valor está correto? (S/N)");
                            resposta = Console.ReadLine();
                        } while (!Resposta(resposta));
                        if (resposta == "S")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                        break;
                    }
                default:
                    {
                        return true;
                        break;
                    }
            }
        }

        public static bool Resposta(string resposta)
        {
            if (resposta != "S" && resposta != "N")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool Sexo(string teste)
        {
            if (teste != "M" && teste != "F")
            {
                return false;
            }
            else
                return true;
        }

        public static bool BrancoNulo (string resposta)
        {
            if (string.IsNullOrWhiteSpace(resposta))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool SimNao (string resposta)
        {
                if (resposta == "S")
                {
                    return true;
                }
                else
                {
                    return false;
                }
         }
    }
}
