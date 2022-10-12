using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static string numeros = "1234567890";
        private static string letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPRRSTUVWXYZ";

        private static int linha;
        private static int coluna;

        static void Main(string[] args)
        {
            recebeValores();
            Console.ReadKey();
        }

        private static void recebeValores()
        {
            Console.WriteLine("Escreva o valor de linhas: ");
            linha = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o valor de colunas: ");
            coluna = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];
            int index = 1;

            for (int i = 0; i < coluna; i++)
            {
                for (int j = 0; j < linha; j++)
                {
                    Console.Write($"| {index.ToString().PadLeft(2, '0')}");
                    index++;
                }
            }
        }


        private static void inserePlaca()
        {
            String placaStr;

            Console.WriteLine("Escreva uma placa: ");
            placaStr = Console.ReadLine();

            validarPlaca(placaStr);
        }

        private static void validarPlaca(String placa)
        {
            if (placa.Length <= 7)
            {
                validarCaracteresPlaca(placa);
             
            } else
            {
                Console.WriteLine("Placa Inválida");
                Console.ReadKey();

            }

        }

        private static void validarCaracteresPlaca(String placa)
        {
            for (int i = 0; i < placa.Length; i++)
            {
                if (validaPlacaCarroIndice(i, placa[i]))
                {

                }
                
              
            }
        }

        private static bool validaPlacaCarroIndice(int index, char conteudo)
        {
            switch(index)
            {
                case 0: 
                case 1: 
                case 2:
                    return letras.Contains(conteudo);
                case 3:
                    return letras.Contains(conteudo) || numeros.Contains(conteudo);
                case 4: 
                case 5: 
                case 6:
                    return numeros.Contains(conteudo);
                default:
                    return false;
            }
        } 
    }
}
