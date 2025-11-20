public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("\bPractice short exercises on .NET!");
        System.Console.WriteLine("\n");

        FabonnaciSeries();
    }

    public static void FabonnaciSeries()
    {
        System.Console.WriteLine("\u001b[1mFabonnaci series \u001b[0m");

        var a = 0; 
        var b = 1;
        var sum = 0;
        System.Console.WriteLine(a);

        while(a<100)
        {
            sum=a+b;
            a=b;
            b=sum;

            System.Console.WriteLine(a);
        }
    }
}

