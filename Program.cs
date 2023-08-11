/*
1 - Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.

2 – Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário, se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.

3 – Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.

*/

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----- Exercício 1 -----");

        Exercicio1 exercicio1 = new Exercicio1();
        exercicio1.Saudacao("Rodrigo");

        Console.WriteLine("----- Exercício 2 -----");

        Exercicio2 exercicio2 = new Exercicio2();
        exercicio2.Permissao(17);
        exercicio2.Permissao(22);

        Console.WriteLine("----- Exercício 3 -----");

        Exercicio3 exercicio3 = new Exercicio3();
        if (exercicio3.EhPar(4))
        {
            Console.WriteLine("É par!");
        }
        else
        {
            Console.WriteLine("É ímpar!");
        }

        Console.ReadKey();
    }
}
