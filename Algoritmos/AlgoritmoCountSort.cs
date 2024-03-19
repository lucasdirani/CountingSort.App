namespace CountingSort.App.Algoritmos
{
    public static class AlgoritmoCountSort
    {
        public static void CountSort(int[] arr, int n)
        {
            int[] saida = new int[n];
            int intervalo = arr[0];
            for (int i = 1; i < n; i++)
            {
                intervalo = Math.Max(intervalo, arr[i]);
            }
            int[] count = new int[intervalo + 1];
            for (int i = 0; i < n; i++)
            {
                ++count[arr[i]];
            }
            for (int i = 1; i <= intervalo; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = 0; i < n; i++)
            {
                saida[count[arr[i]] - 1] = arr[i];
                --count[arr[i]];
            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = saida[i];
            }
        }
    }
}