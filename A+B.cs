using System;
 
class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string[] spi = s.Split();
 
        int[] nums = new int[spi.Length];
 
        for (int i = 0; i < spi.Length; i++)
        {
            nums[i] = int.Parse(spi[i]);
        }
 
        Console.Write(nums[0] + nums[1]);
    }
}