using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {       
               for(int x = 1000; x <= 9999; x++){

               String primeiraMetade = Convert.ToString(x).Substring(0,2);
               string segundaMetade = Convert.ToString(x).Substring(2);

               int soma = int.Parse(primeiraMetade) + int.Parse(segundaMetade);

                     if(Math.Pow(soma,2)== x){
                     System.Console.WriteLine(x);
                     }      
               }
        }

    }
     
}