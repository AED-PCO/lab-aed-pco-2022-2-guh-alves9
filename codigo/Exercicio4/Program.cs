     int[,] mat = new int[5,3] { { 1, 2 ,3 }, { 3, 4 ,5}, { 5, 6 ,5 }, { 7, 8 ,6}, { 9, 10 ,8}};
     int somal = 0, somac = 0;

      System.Console.WriteLine("Soma das linhas: ");
         for(int l = 0; l < 5; l++){  
            for(int c = 0; c < 3; c++){
               somal = somal + mat[l,c];
            }
               System.Console.WriteLine(somal);
                 somal = 0;
               System.Console.WriteLine();
         }

      System.Console.WriteLine("Soma das colunas: ");
          for(int c = 0; c < 3; c++){  
             for(int l = 0; l < 5; l++){
                somac = somac + mat[l,c];
             }
                System.Console.WriteLine(somac);
                  somac = 0;
                System.Console.WriteLine();
          }

     

