namespace BinarySearch;

public static class Program
{
    public static int IterativeBinarySearchAlgorithm(this List<int> numbers, int search)
    {
        int l = 0;
        int r = numbers.Count - 1;

        while (l <= r)
        {
            int m = l + (r - l) / 2;

            if (numbers[m] == search)
                return m;

            if (numbers[m] < search)
                l = m + 1;

            else if (numbers[m] > search)
                r = m - 1;
        }

        return -1;
    }

    public static int RecursiveBinarySearchAlgorithm(this List<int> numbers,
        int l, 
        int r,
        int search)
    {
        if (l <= r)
        {
            int mid = l + (r - l) / 2;

            if (numbers[mid] == search)
                return mid;

            if (numbers[mid] < search)
                return RecursiveBinarySearchAlgorithm(numbers, mid + 1, r, search);
            
            return RecursiveBinarySearchAlgorithm(numbers, l, mid - 1, search);
        }

        return -1;
    }
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int l = 0;
        int r = numbers.Count - 1;
        Console.WriteLine(numbers.IterativeBinarySearchAlgorithm(1));
        Console.WriteLine(numbers.RecursiveBinarySearchAlgorithm(l, r, 1));
    }
}

