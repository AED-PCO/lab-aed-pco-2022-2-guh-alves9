            int[] a = new int[5]{ 12, 2, 40, 7, 1 };
            int[] b = new int[5]{ 7, 2, 3, 4, 1 };
            int[] c = new int[5];
            int[] d = new int[5]{ 0, 0, 0, 0, 0 };
            int k = 0;
            int cont = 0;
            int l = 0;
            for(int i=0; i<5; i++){
                cont = 0;
                for(int j=0; j<5; j++){
                    if(a[i] == b[j]){
                        c[k] = a[i];
                        k++;
                    }else{
                        cont++;
                    }
                    if(cont == 5){
                       d[l] = a[i];
                       l++;
                       cont = 0;
                    }


                }
            }
            for(int i=0; i<k; i++){
                Console.WriteLine(c[i]);
        }
        Console.WriteLine("------");
            for(int i=0; i<l; i++){
               Console.WriteLine(d[i]);
            }