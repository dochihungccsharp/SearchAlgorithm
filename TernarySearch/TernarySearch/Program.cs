namespace TernarySearch;

public static class Program
{
    public static int IterativeApproachOfTernarySearch(this List<int> numbers, int search)
    {
        int l = 0;
        int r = numbers.Count - 1;

        while (l <= r)
        {
            int mid1 = l + (r - l) / 3;
            int mid2 = r - (r - l) / 3;

            if (numbers[mid1] == search)
                return mid1;

            if (numbers[mid2] == search)
                return mid2;

            if (numbers[mid1] > search)
                r = mid1 - 1;
            else if(numbers[mid2] < search)
                l = mid2 + 1;
            else
            {
                l = mid1 + 1;
                r = mid2 - 1;
            }
        }
        return -1;
    }

    public static int RecursiveImplementationOfTernarySearch(
        this List<int> numbers,
        int l, 
        int r,
        int search)
    {
        if (l <= r)
        {
            int mid1 = l + (r - l) / 3;
            int mid2 = r - (r - l) / 3;
            
            if (numbers[mid1] == search)
                return mid1;

            if (numbers[mid2] == search)
                return mid2;

            if (numbers[mid1] > search)
                return RecursiveImplementationOfTernarySearch(numbers, l, mid1 - 1, search);
            else if (numbers[mid2] < search)
                return RecursiveImplementationOfTernarySearch(numbers, mid2 + 1, r, search);
            else
                return RecursiveImplementationOfTernarySearch(numbers, mid1 + 1, mid2 - 2, search);
        }
        return -1;
    }
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int l = 0;
        int r = numbers.Count - 1;
        Console.WriteLine(numbers.IterativeApproachOfTernarySearch(10));
        Console.WriteLine(numbers.RecursiveImplementationOfTernarySearch(l, r, 10));
    }
}

