namespace Exercicio5
{
    class Program
    {
       public static int somaVetor(int []vet,int n){  

        if(n == 1) {
            return vet[0];
        }
        if(vet[n] % 2 == 1){
            return vet[n] + somaVetor(vet, n);
        }
            return vet[n + 1];

       }
        static void Main(string[] args)
        {  
          int []vet = new int [10] {1,2,3,4,5,6,7,8,9,10};
          int resultado = somaVetor(vet, 10);
          System.Console.WriteLine(resultado);
        }
    }
}