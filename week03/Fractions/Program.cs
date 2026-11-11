using System;

class Program
{
    static void Main(string[] args)
    {
        fraction f1 = new fraction();

        f1.setBottom(3);
        f1.setTop(1);

        Console.WriteLine(f1.getBottom());
        Console.WriteLine(f1.getTop());

        Console.WriteLine(f1.getDecimalValue());
        Console.WriteLine(f1.getFractionString());

        fraction f2 = new fraction(6);

        f2.setBottom(3);

        Console.WriteLine(f2.getBottom());
        Console.WriteLine(f2.getTop());

        Console.WriteLine(f2.getDecimalValue());
        Console.WriteLine(f2.getFractionString());

        fraction f3 = new fraction(6, 8);

        Console.WriteLine(f3.getTop());
        Console.WriteLine(f3.getTop());

        Console.WriteLine(f3.getDecimalValue());
        Console.WriteLine(f3.getFractionString());
    }
}
