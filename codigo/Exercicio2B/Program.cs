            int soma = 0;
            int[] vet = new int[1000];
            Console.WriteLine("Os numeros perfeitos são: "); 

            for(int j = 1; j < 1000; j++){
               soma = 0;
                 for(int i = 1; i < j; i++){
                    if(j %i == 0){
                        vet[i] = i;
                    }
                 }
                 for(int i = 0; i < 1000; i++){
                        soma = soma +vet[i];
                 }
                 for(int i = 0; i < 1000; i++){
                        vet[i] = 0;
                 }
                    if(soma == j){
                        Console.WriteLine(j);
                    }
            }