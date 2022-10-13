namespace Exercicio2
{
    class Program
    {
       public static int mult(int A, ref int B)
        {
            int p = 0;
            for(int i = 1; i < B; i++){
                p += A;
            }
            return p + A;        
        }
 
        static void Main(string[] args)
        {
          int A, B;
          Console.WriteLine("Digite um numero para ser multiplicado: ");
          A = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite outro numero: ");
          B = int.Parse(Console.ReadLine());
          Console.WriteLine(mult(A, ref B));

        }
    }
}
