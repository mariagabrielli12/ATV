namespace ATV5_CJ3022439
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========MENU DO MARQUESITO========");

            Console.WriteLine("Digite 1 para o exercício 1");

            Console.WriteLine("Digite 2 para o exercício 2");

            Console.WriteLine("Digite 3 para o exercício 3");

            Console.WriteLine("Digite 4 para o exercício 4");

            Console.WriteLine("Digite 5 para o exercício 5");

            Console.WriteLine("Digite 6 para o exercício 6");

            Console.WriteLine("Digite 7 para o exercício 7");

            Console.WriteLine("Digite 0 para sair");

            Console.WriteLine("=====================================");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:

                    Console.WriteLine("obrigado por utilizar o programa");
                    break;

                case 1:
                    // Atividade 1

                    Console.WriteLine("executando o exercício 1");
                    int n = 1, i;

                    Console.WriteLine("Digite um número:");
                    i = int.Parse(Console.ReadLine());

                    do
                    {
                        Console.WriteLine(n);
                        n++;
                    } while (n <= i);

                    break;


                case 2:

                    Console.WriteLine("executando o exercício 2");
                    int r = 1, j;

                    Console.WriteLine("Digite um número:");
                    j = int.Parse(Console.ReadLine());

                    do
                    {
                        if (r % 2 == 0)
                        {
                            Console.WriteLine(r);
                        }
                        r++;
                    } while (r <= j);

                    break;


                case 3:
                    // Atividade 3

                    Console.WriteLine("executando o exercício 3");
                    int p, l;

                    Console.WriteLine("Digite um número até 1000:");
                    l = int.Parse(Console.ReadLine());

                    p = l;
                    do
                    {
                        if (p % 2 == 0)
                        {
                            Console.WriteLine(p);
                        }
                        p++;
                    } while (p < 1000);

                    break;


                case 4:
                    // Atividade 4

                    Console.WriteLine("executando o exercício 4");

                    int n1, a1 = 1;
                    int soma = 200;

                    Console.WriteLine("Digite um número:");
                    n1 = int.Parse(Console.ReadLine());

                    if (n1 < 0)
                    {
                        Console.WriteLine("Número inválido");
                    }
                    else
                    {

                        do
                        {
                            Console.WriteLine(a1);
                            a1++;
                        } while (a1 < soma);
                    }

                    break;

                case 5:
                    // Atividade 5
                    Console.WriteLine("executando o exercício 5");

                    int v, p1 = 0;
                    do
                    {
                        Console.WriteLine("Digite um número:");
                        v = int.Parse(Console.ReadLine());

                        p1 = 1;

                        do
                        {
                            if (v % p1 == 0)
                            {
                                Console.WriteLine(p1);
                            }
                            p1++;
                        } while (p1 <= v);

                    } while (v > 0);

                    break;

                case 6:
                    // Atividade 6

                    Console.WriteLine("executando o exercício 6");

                    int j1 = 0, v2;
                    do
                    {
                        Console.WriteLine("Digite um valor:");
                        v2 = int.Parse(Console.ReadLine());

                        if (j1 == 0)
                        {
                        }

                        if (v2 < v2)
                        {
                            Console.WriteLine("O número maior é = {0}", v2);
                        }

                        if (v2 > v2)
                        {
                            Console.WriteLine("O número menor é = {0}", v2);
                        }

                        j1++;
                    } while (j1 < 11);

                    break;

                case 7:
                    // Atividade 7
                    Console.WriteLine("executando o exercício 7");

                    int t = 0, l3;
                    int r1 = 0, p3 = 0;

                    do
                    {
                        Console.WriteLine("Digite um valor:");
                        l3 = int.Parse(Console.ReadLine());

                        if (l3 <= 0)
                            break;

                        if (t % 2 != 0)
                        {
                            r1 = r1 + l3;
                        }

                        if (t % 2 == 0)
                        {
                            p3 = p3 + l3;
                        }

                        Console.WriteLine("Soma dos números ímpares = {0}", r1);
                        Console.WriteLine("Soma dos números pares = {0}", p3);

                        t++;
                    } while (t < 10);

                    break;
            } while (opcao != 0) ;
            while (opcao != 0) ;

        }
    }
}
