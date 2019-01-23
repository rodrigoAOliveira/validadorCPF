using System;

namespace validadorCPF
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um CPF: ");
            String cpf = Console.ReadLine();
            int somaPrimeiraParte = 0;
            int somaSegundaParte = 0;
            int[] validadorParte1 = new int[10];
           

            int x = 0;
            for (int i = 10; i > 1; i--)
            {


                if (x < 10)
                {
                    validadorParte1[x] = i;


                    somaPrimeiraParte = somaPrimeiraParte +
                     (validadorParte1[x] * int.Parse(cpf.Substring(x, 1)));

                    x++;
                }

            }
            if (11 - somaPrimeiraParte % 11 == int.Parse(cpf.Substring(9, 1)))
            {


                int y = 0;
                for (int i = 11; i > 1; i--)
                {


                    if (y < 11)
                    {
                        validadorParte1[y] = i;


                        somaSegundaParte = somaSegundaParte +
                         (validadorParte1[y] * int.Parse(cpf.Substring(y, 1)));

                        y++;

                       
                    }

                }

                if(11 - somaSegundaParte%11 == int.Parse(cpf.Substring(10, 1)))
                {
                    Console.WriteLine("CPF Valido");

                }
                else {
                    Console.WriteLine("CPF invalido");

                }



            }


            else
            {
                Console.WriteLine("CPF invalido");
            }


        }
    }


}
