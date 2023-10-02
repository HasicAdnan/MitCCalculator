namespace MitCCalculator;

public class Methods
{
    public static int Result(int a, int b, char c)
    {
        switch (c)
        {
            case '+':
                return a + b;
            break;
            case '-' :
                return a - b;
            break;
            case '*' :
                return a * b;
            break;
            case 'x':
                return a * b;
                break;
        }

        return 1;
    }
    

    public static double DoubleResult(int a, int b)
    {
        double result = (a * 1.0) / b;
        return result;
    }

    public static void isEvenOrOdd(int a, int b, int c)
    {
        int[] arrayOddOrEven = { a, b, c };

        foreach (var x in arrayOddOrEven)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine( x + " is even");
            }
            else
            {
                Console.WriteLine( x + " is odd");
                
            }
        }
    }

}