namespace Exercicio6
{
    class Program
    {
       public static double Potencia(int x, ref int y)
        {
            double p = 0;
            p = Math.Pow(x, y);
            return p;        
        }
 
        static void Main(string[] args)
        {
          int x, y;
          Console.WriteLine("Digite um numero: ");
          x = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite outro numero: ");
          y = int.Parse(Console.ReadLine());
          Console.WriteLine(Potencia(x, ref y));

        }
    }
}