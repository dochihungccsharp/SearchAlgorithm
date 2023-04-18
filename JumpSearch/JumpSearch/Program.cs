namespace JumpSearch;

public static class Program
{
    public static int JumpSearch(this List<int> numbers, int search)
    {
        int length = numbers.Count;
        int step = (int)Math.Floor(Math.Sqrt(length));

        int prev = 0;
        while (numbers[Math.Min(step, length) - 1] < search)
        {
            prev = step;
            step += (int)Math.Floor(Math.Sqrt(length));
            if (prev >= length)
                return -1;
        }

        while (numbers[prev] < search)
        {
            prev++;
            if (prev == Math.Min(step, length))
                return -1;
        }

        if (numbers[prev] == search)
            return prev;

        return -1;
    }
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(numbers.JumpSearch(1110));
    }
}

