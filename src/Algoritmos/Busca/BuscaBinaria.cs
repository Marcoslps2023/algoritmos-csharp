namespace Algoritmos.Busca
{
    public static class BuscaBinaria
    {
        public static int Executar(int[] arr, int alvo)
        {
            int baixo = 0;
            int alto = arr.Length - 1;

            while (baixo <= alto)
            {
                int meio = (baixo + alto) / 2;

                if (arr[meio] == alvo)
                    return meio;

                if (arr[meio] < alvo)
                    baixo = meio + 1;
                else
                    alto = meio - 1;
            }

            return -1;
        }
    }
}