namespace Exercicio4
{
    class Program
    {
       public static int Func(string F, char L){
        int cont = 0;
        for(int i=0; i <= F.Length-1; i++){
            if(F[i] == L){
                cont++;
            }                  
        }
        return cont;   
       }
 
        static void Main(string[] args)
        {
          string F;
          char L;
          Console.WriteLine("Digite a frase: ");
          F = Console.ReadLine();
          Console.WriteLine("Digite a letra: ");
          L = Console.ReadKey().KeyChar;
          Console.WriteLine("\nQuantidade de repetições desta letra na frase: "+ Func(F, L));
        }
    }
}