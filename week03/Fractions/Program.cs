using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");


        Fraction division1 = new Fraction();
        Fraction division2 = new Fraction(6);
        Fraction division3 = new Fraction(6, 7);

        Console.WriteLine(division1.GetFractionString());
        Console.WriteLine(division1.GetDecimalValue());
        
        Console.WriteLine(division2.GetFractionString());
        Console.WriteLine(division2.GetDecimalValue());

        Console.WriteLine(division3.GetFractionString());
        Console.WriteLine(division3.GetDecimalValue());
    }
}