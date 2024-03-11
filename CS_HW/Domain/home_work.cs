namespace Domain
{
    public class SortingHelper
    {
        public static void BubbleSort(int[] array, bool ascending)
        {
            int n = array.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 1; i < n; i++)
                {
                    bool shouldSwap = ascending ? array[i - 1] > array[i] : array[i - 1] < array[i];
                    if (shouldSwap)
                    {
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        swapped = true;
                    }
                }

                n--;
            } while (swapped);
        }
    }
}