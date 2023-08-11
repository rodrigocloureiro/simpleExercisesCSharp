/*
1 - Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

2 – Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário, se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.

3 – Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.

*/

class Program
{
    public static void Main(string[] args)
    {
        String opcao;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("( 1 ) - Exercício 1");
            Console.WriteLine("( 2 ) - Exercício 2");
            Console.WriteLine("( 3 ) - Exercício 3");
            Console.WriteLine("( X ) - Sair do programa");
            Console.Write("\nEscolha uma opção: ");
            opcao = Console.ReadLine().ToUpper();

            switch (opcao)
            {
                case "X":
                    Console.Write("Obrigado por utilizar o programa!");
                    Console.ReadKey();
                    return;
                case "1":
                    Exercicio1 exercicio1 = new Exercicio1();
                    exercicio1.Saudacao("Rodrigo");
                    Console.ReadKey();
                    break;
                case "2":
                    Exercicio2 exercicio2 = new Exercicio2();
                    exercicio2.Permissao(17);
                    exercicio2.Permissao(22);
                    Console.ReadKey();
                    break;
                case "3":
                    Exercicio3 exercicio3 = new Exercicio3();
                    exercicio3.EhPar(4);
                    exercicio3.EhPar(3);
                    Console.ReadKey();
                    break;
            }
        }
    }
}
