using System.Linq;

namespace Domain
{
    public static class Filter
    {
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            return originalArray.Where(num => !filterArray.Contains(num)).ToArray();
        }
    }
}