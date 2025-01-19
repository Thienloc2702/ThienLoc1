class Program
{
    static void Main()
    {
        int result = Algorithm(new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 });
        Console.WriteLine(result);  
    }

    public static int Algorithm(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }  
        return 0;
    }
   
}


