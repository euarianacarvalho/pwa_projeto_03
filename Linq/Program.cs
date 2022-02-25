using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var idades = new int[] { 20, 21, 22, 25, 30, 40, 55 };
            //Func<int, bool> funcao = EhAbaixo30;
            //var soma = idades.Sum();

            //var qtdeAbaixo30 = 0;

            //foreach (var item in idades)
            //{
            //    if (item < 30)
            //    {
            //        qtdeAbaixo30++;
            //    }
            //}

            //var qtdeAbaixo30 = idades.Count(EhAbaixo30);

            //var qtdeAbaixo30 = idades.Count(funcao);

            //var qtdeAbaixo30 = idades.Count(x => x < 30);

            //var somaPares = idades.Sum(x => x % 2 == 0 ? x : 0);

            //var idadeMaioresQue30 = idades.Where(x => x > 30);

            //foreach (var item in idadeMaioresQue30)
            //{
            //    Console.WriteLine(item);
            //}

            /*
            var dobroDeCadaidadeMaiorQue30 = idades.Where(x => x > 30).Select(x => x * 2);

            foreach (var item in dobroDeCadaidadeMaiorQue30)
            {
                Console.WriteLine(item);
            }
            */

            //Console.WriteLine(qtdeAbaixo30);

            var idadesAbaixo30 = from x in idades where x < 30 select x;

            foreach (var item in idadesAbaixo30)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();


        }

        //static bool EhMaiorQue30(int x) => x < 30;

        //static bool EhAbaixo30(int x)
        //{
        //    return x < 30;
        //}
    }
}
