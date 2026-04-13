using Algoritmos.Busca;

class Program
{
    static void Main()
    {
        int[] numeros = { 5, 12, 18, 23, 45, 70, 89 };
        int alvo = 45;

        int resultado = BuscaBinaria.Executar(numeros, alvo);

        Console.WriteLine(resultado != -1
            ? $"Achei no índice {resultado}"
            : "Não achei");
    }
}