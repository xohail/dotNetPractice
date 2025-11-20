public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\bPractice short exercises on .NET!");
        System.Console.WriteLine("\n");

        FabonnaciSeries();
        System.Console.WriteLine("\n");
        FabonnaciSeriesWithRecursion();
    }

    public static void FabonnaciSeries()
    {
        System.Console.WriteLine("\u001b[1mFabonnaci series \u001b[0m");

        int a = 0; 
        int b = 1;
        int sum = 0;
        System.Console.WriteLine(a);

        while(a<100)
        {
            sum=a+b;
            a=b;
            b=sum;

            System.Console.WriteLine(a);
        }
    }

    public static void FabonnaciSeriesWithRecursion()
    {
        System.Console.WriteLine("\u001b[1mFabonnaci series with recursion\u001b[0m");

        int n = 10; // Number of terms to display
        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine(Fib(i));
        }
    }

    private static int Fib(int n)
    {
        if (n <= 1)
            return n;
        return Fib(n - 1) + Fib(n - 2);
    }
}

