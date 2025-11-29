using System;

namespace AlgorithmLab.Algoritmos
{
    public static class LogicaOrdenamiento
    {
        public static long ContadorIntercambios;

        // --- SELECTION SORT (Sin cambios, solo asegúrate que esté así) ---
        public static void SelectionSort<T>(T[] array) where T : IComparable
        {
            ContadorIntercambios = 0;
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j].CompareTo(array[min_idx]) < 0)
                        min_idx = j;
                }

                if (min_idx != i) // Pequeña optimización: solo intercambiar si es necesario
                {
                    T temp = array[min_idx];
                    array[min_idx] = array[i];
                    array[i] = temp;
                    ContadorIntercambios++;
                }
            }
        }

        // --- MERGE SORT OPTIMIZADO (Adiós Crasheos) ---
        public static void MergeSort<T>(T[] array) where T : IComparable
        {
            ContadorIntercambios = 0;
            if (array.Length <= 1) return;

            // Creamos el array auxiliar UNA SOLA VEZ aquí fuera
            T[] auxiliar = new T[array.Length];
            MergeSortRecursivo(array, auxiliar, 0, array.Length - 1);
        }

        private static void MergeSortRecursivo<T>(T[] array, T[] auxiliar, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortRecursivo(array, auxiliar, left, mid);
                MergeSortRecursivo(array, auxiliar, mid + 1, right);
                Merge(array, auxiliar, left, mid, right);
            }
        }

        private static void Merge<T>(T[] array, T[] auxiliar, int left, int mid, int right) where T : IComparable
        {
            // Copiamos a auxiliar solo el segmento necesario
            for (int i = left; i <= right; i++)
            {
                auxiliar[i] = array[i];
            }

            int i_left = left;
            int i_right = mid + 1;
            int current = left;

            while (i_left <= mid && i_right <= right)
            {
                ContadorIntercambios++;
                // Comparamos desde el auxiliar, escribimos en el original
                if (auxiliar[i_left].CompareTo(auxiliar[i_right]) <= 0)
                {
                    array[current] = auxiliar[i_left];
                    i_left++;
                }
                else
                {
                    array[current] = auxiliar[i_right];
                    i_right++;
                }
                current++;
            }

            // Copiar el resto del lado izquierdo (el derecho ya está en su sitio)
            int remaining = mid - i_left;
            for (int i = 0; i <= remaining; i++)
            {
                array[current + i] = auxiliar[i_left + i];
            }
        }
    }
}