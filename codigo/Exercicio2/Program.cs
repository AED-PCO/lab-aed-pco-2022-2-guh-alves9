      
      int n, cont = 0;

      System.Console.WriteLine("Digite um numero: ");
      n = int.Parse(Console.ReadLine());

      for(int i = 1; i <= n; i++){
          if(n % i == 0){
            cont++;
          }
      }
          if(cont == 2){
            System.Console.WriteLine("O numero é primo");
          }
          else{
            System.Console.WriteLine("O numero não é primo");
          }

        