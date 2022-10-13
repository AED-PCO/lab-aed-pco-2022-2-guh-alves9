namespace Exercicio6
{
    class Program
    {
       public static string Func(string F,string a,string e,string i,string o,string u){
        for(int j=0; j <= F.Length-1; j++){
            if(F[j] == a || e || i || o || u){
                F.Length-1;                               
            }                  
        }
        return F;   
       }
 
        static void Main(string[] args)
        {
          string F;
          string a, e, i, o, u;
          a = "a";
          e = "e";
          i = "i";
          o = "o";
          u = "u";
          Console.WriteLine("Digite a frase: ");
          F = Console.ReadLine();
          Console.WriteLine("\nQuantidade de repetições desta letra na frase: "+ Func(F));
        }
    }