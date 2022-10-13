namespace Exercicio3
{
    class Program
    {
       public static int pot(int A, int B) {
        if (B == 0){
            return 1;
        } 
        return pot(A, B - 1) * A;
       }
 
        static void Main(string[] args)
        {
          int A, B;
          Console.WriteLine("Digite a base: ");
          A = int.Parse(Console.ReadLine());
          Console.WriteLine("Digite o expoente: ");
          B = int.Parse(Console.ReadLine());
          Console.WriteLine(pot(A, B));

        }
    }
}