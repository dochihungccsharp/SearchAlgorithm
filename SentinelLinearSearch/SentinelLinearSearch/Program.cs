namespace SentinelLinearSearch;

public static class Program{

    public static bool SentinelLinearSearch(this List<int> numbers, int search)
    {
        var length = numbers?.Count;
        if (length == null || length < 1) return false;

        var last = numbers[length.Value - 1];
        numbers[length.Value - 1] = search;

        int i = 0;
        while (numbers?[i] != search)
            i++;

        numbers[length.Value - 1] = last;
        
        if (i < length - 1 || numbers[length.Value - 1] == search) return true;
        return false;
        
    }
    
    public static void Main(string[] args)
    {
        List<int>? nums = null;
        Console.WriteLine(nums?.SentinelLinearSearch(12));
    }
}
