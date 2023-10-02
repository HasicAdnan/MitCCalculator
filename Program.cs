using MitCCalculator;

class Program

{
    public static void Main()
    {
        
        Console.WriteLine("Geben Sie eine Nummer ein : ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Geben Sie zweite Nummer ein : ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Geben Sie operator ein : ");
        char oper = char.Parse(Console.ReadLine());

        if (oper == '/')
        {
            Console.WriteLine("Ergebnis ist : " + x + " " + oper + " " + y + " = " + Methods.DoubleResult(x,y));
        }
        else
        {
            Console.WriteLine("Ergebnis ist : " + x + " " + oper + " " + y + " = " + Methods.Result(x, y, oper));
        }
        
        Methods.isEvenOrOdd(x, y, Methods.Result(x, y, oper));
    }
}