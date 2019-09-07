using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercVOTOS_10._07._19
{
    class Program
    {
        static void Main(string[] args)
        {
            double eleitor;
            double votobranco;
            double votonulo;
            double votovalido;
            double percNulos;
            double percBranco;
            double percValido;

            Console.WriteLine("digite o total de eleitores: ");
            eleitor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o total de votos Brancos: ");
            votobranco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o total de votos Nulos: ");
            votonulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o total de votos validos: ");
            votovalido = Convert.ToDouble(Console.ReadLine());


            //RESULTADO DE PORCENTAGEM DE NULOS
            percNulos = votonulo / eleitor * 100;
            Console.WriteLine(" a % de votos nulos é: " + percNulos + "%");

            Console.WriteLine("-----------------------");

            //RESULTADO DE PORCENTAGEM DE BRANCOS
            percBranco = votobranco / eleitor * 100;
            Console.WriteLine(" a % de votos brancos é: " + percBranco + "%");

            Console.WriteLine("----------------------");
            //RESULTADO DE PORCENTAGEM DE VALIDOS
            percValido = votovalido / eleitor * 100;
            Console.WriteLine(" a % de votos válidos é: " + percValido + "%");

            Console.WriteLine("----------------------------");

            Console.Read();



        }
    }
}
