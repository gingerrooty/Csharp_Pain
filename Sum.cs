using System;
 
class Program
{
    static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
 
        if (a > 0)
        {
            for (int i = 1; i <= a; i++)
                    {
                        sum += i;
                    }
        } else if (a <= 0)
        {
            for (int i = 1; i >= a; i--)
            {
                sum += i;
            }
        }
         
 
        Console.WriteLine(sum);
    }
}