public class Exercicio2
{
    public void Permissao(int idade)
    {
        if (idade < 18)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sem permissão!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Permissão concedida!");
        }
        Console.ResetColor();
    }
}
