using System;

namespace AlgorithmLab.Algoritmos
{
    public static class LogicaBusqueda
    {
        public static long PasosRealizados;

        #region Jump Search
        public static int JumpSearch<T>(T[] array, T x) where T : IComparable
        {
            PasosRealizados = 0;
            int n = array.Length;
            int step = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;

            while (array[Math.Min(step, n) - 1].CompareTo(x) < 0)
            {
                PasosRealizados++;
                prev = step;
                step += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n) return -1;
            }

            while (array[prev].CompareTo(x) < 0)
            {
                PasosRealizados++;
                prev++;
                if (prev == Math.Min(step, n)) return -1;
            }

            if (array[prev].CompareTo(x) == 0)
                return prev;

            return -1;
        }
        #endregion

        #region Interpolation Search
        public static int InterpolationSearch(double[] array, double x)
        {
            PasosRealizados = 0;
            int lo = 0, hi = (array.Length - 1);

            while (lo <= hi && x >= array[lo] && x <= array[hi])
            {
                PasosRealizados++;
                if (lo == hi)
                {
                    if (array[lo] == x) return lo;
                    return -1;
                }

                int pos = lo + (int)(((double)(hi - lo) / (array[hi] - array[lo])) * (x - array[lo]));

                if (array[pos] == x) return pos;

                if (array[pos] < x)
                    lo = pos + 1;
                else
                    hi = pos - 1;
            }
            return -1;
        }
        #endregion
    }
}