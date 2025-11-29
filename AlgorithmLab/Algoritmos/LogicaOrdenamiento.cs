using System;
using System.Collections.Generic;

namespace AlgorithmLab.Algoritmos
{
    public static class LogicaOrdenamiento
    {
        public static long ContadorIntercambios; // Contador global simple

        #region Selection Sort
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
                    {
                        min_idx = j;
                    }
                }
                // Swap
                T temp = array[min_idx];
                array[min_idx] = array[i];
                array[i] = temp;
                ContadorIntercambios++;
            }
        }
        #endregion

        #region Merge Sort
        public static void MergeSort<T>(T[] array) where T : IComparable
        {
            ContadorIntercambios = 0;
            MergeSortRecursivo(array, 0, array.Length - 1);
        }

        private static void MergeSortRecursivo<T>(T[] array, int left, int right) where T : IComparable
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;
                MergeSortRecursivo(array, left, middle);
                MergeSortRecursivo(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        private static void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            T[] L = new T[n1];
            T[] R = new T[n2];

            for (int i = 0; i < n1; i++) L[i] = array[left + i];
            for (int j = 0; j < n2; j++) R[j] = array[middle + 1 + j];

            int k = left;
            int x = 0, y = 0;

            while (x < n1 && y < n2)
            {
                if (L[x].CompareTo(R[y]) <= 0)
                {
                    array[k] = L[x];
                    x++;
                }
                else
                {
                    array[k] = R[y];
                    y++;
                }
                k++;
                ContadorIntercambios++;
            }

            while (x < n1) { array[k] = L[x]; x++; k++; }
            while (y < n2) { array[k] = R[y]; y++; k++; }
        }
        #endregion
    }
}