public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Practice short exercises on .NET!");
        System.Console.WriteLine("\n");

        FabonnaciSeries();
        System.Console.WriteLine("\n");
        FabonnaciSeriesWithRecursion();
        Factorial();
        Palindrome();
    }

    public static void FabonnaciSeries()
    {
        System.Console.WriteLine("\u001b[1mFabonnaci series \u001b[0m");

        int a = 0; 
        int b = 1;
        int sum = 0;
        System.Console.WriteLine(a);

        while(a<15)
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
        System.Console.WriteLine("Enter the number of terms!");

        // int n = int.Parse(Console.ReadLine());
        int n = 6;
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

    private static int Fact(int n)
    {
        while (n>0) {
            return n*Fact(n-1);
        }
        return 1;
    }

    public static void Factorial()
    {
        System.Console.WriteLine("\u001b[1mFactorial\u001b[0m");
        System.Console.WriteLine("Enter the number!");

        // int n = int.Parse(Console.ReadLine());
        int n = 5;
        
        int fact = Fact(n);
        
        System.Console.WriteLine(fact);
    }

    public static void Palindrome()
    {
        // get string
        System.Console.WriteLine("\u001b[1mPalindrome\u001b[0m");
        System.Console.WriteLine("Enter the string!");

        string str = "dad";
        string reversed = "";

        // reverse the string
        for(int i=str.Length-1; i>=0; i--)
        {
            reversed += str[i];
        }

        if (str == reversed)
        {
            System.Console.WriteLine("The string is a palindrome");
        }
        else
        {
            System.Console.WriteLine("The string is not a palindrome");
        }
    
    }
}

