using System;
using System.Globalization;

namespace pessoas
{
    class Program
    {

        static void Main(string[] args)
        {
            //Declaraçao da variavel da classe pessoa
            pessoa a;

            //Declaraçao da variavel da classe pessoa
            pessoa b;

            //instaciar a variavel
            a = new pessoa();
            //instaciar a variavel
            b = new pessoa();


            //informaçao para o meu usuario
            Console.WriteLine("Qual é o nome do Usuário?");
            a.nome = Console.ReadLine();
            Console.WriteLine("Qual é a idade do usuário?");
            a.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);




            //informaçao para o meu usuario
            Console.WriteLine("Qual é o nome do segundo usuário?");
            b.nome = Console.ReadLine();
            Console.WriteLine("Qual é a idade do segundo usuário?");
            b.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);






            //comparação para ver quem é mais velho
            if (a.idade > b.idade)
            {
                Console.WriteLine(a.nome + " é a pessoa mais velha!!");
            }
            else if (b.idade > a.idade)
            {
                Console.WriteLine(b.nome + " é a pessoa mais velha!!");
            }
            else 
            {
                Console.WriteLine("os 2 tem a mesma idade");
            }






        }
    }
}
