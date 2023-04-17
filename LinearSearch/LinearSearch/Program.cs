namespace LinearSearch;

public static class LinearSearch
{
    public static bool HandleLinearSearch(this List<int> numbers, int search)
    {
        var length = numbers?.Count;
        if(length == null || length < 1) return false;

        for (int i = 0; i < length; i++)
        {
            if (numbers?[i] == search) return true;
        }

        return false;
    }
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        Console.WriteLine(nums.HandleLinearSearch(111));
    }
}

