using System;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Method0();
        Method1();
        Console.ReadKey();
    }

    public static async Task Method0()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" Method 0");
                // Do something
                Task.Delay(100).Wait();
            }
        });
    }

// Currently in 'branch1'. Need to check whether thesechanges reflect in main or not.
// It didn't reflect in into main unless merged
    public static void Method1()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(" Method 1");
            // Do something
           Task.Delay(100).Wait();
        }
    }
}
