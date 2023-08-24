using ExercicioDeFixacao_Vetores;

internal class Program
{
    private static void Main(string[] args)
    {
        Estudante[] vect = new Estudante[10];

        Console.WriteLine("----- PENSÃO DONA FLORINDA -----");

        Console.WriteLine();
        Console.Write("Quantos estudantes alugarão os quartos (máximo de 10)? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine();
            Console.WriteLine($"Aluguel #{i}");
            Console.Write("Escreva o nome do estudante: ");
            string nome = Console.ReadLine();
            Console.Write("Escreva o e-mail: ");
            string email = Console.ReadLine();
            Console.Write("Qual quarto será locado? ");
            int quarto = int.Parse(Console.ReadLine());
            vect[quarto] = new Estudante(nome, email);
        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados:");
        for (int i = 0; i < 10; i++) 
        {
            if (vect[i] != null)
            {
                Console.WriteLine(i + ": " + vect[i]);
            }
        }

    }
}