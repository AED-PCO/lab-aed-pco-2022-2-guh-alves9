namespace Exercicio1
{
    class Program
    {
       public static int fatorial(int x)
        {
           if(x == 0 || x == 1){
            return 1;
           }
           else{
            return x * fatorial(x - 1);
           }
        }
 
        static void Main(string[] args)
        {
           int x;

           System.Console.WriteLine("Digite um valor para o calculo do fatorial: ");
           x = int.Parse(Console.ReadLine());

           System.Console.WriteLine("O Fatorial de "+ x + " é: "+ fatorial(x));
        } 
    }
}