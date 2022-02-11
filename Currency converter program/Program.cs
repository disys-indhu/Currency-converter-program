using System;
abstract class CurrencyConverter
{
    public abstract void Rupee();
}
class RupeeConverter : CurrencyConverter
{
    public override void Rupee()
    {
        Console.WriteLine("Enter Dollars:");

        double dollar = Convert.ToDouble(Console.ReadLine());
        double dollarToRupees = dollar * 74.17;
        Console.WriteLine(dollarToRupees + " Rupees");
        Console.WriteLine("Enter Euro:");

        double euro = Convert.ToDouble(Console.ReadLine());
        double euroToRupees = euro * 84.88;
        Console.WriteLine(euroToRupees + " Rupees");

    }
}
class DollarConverter : RupeeConverter
{
    public void Dollar()
    {
        Console.WriteLine("Enter Rupees");

        double rupee = Convert.ToDouble(Console.ReadLine());
        double rupeeToDollar = rupee * 0.013;
        Console.WriteLine(rupeeToDollar + " Dollars");
        Console.WriteLine("Enter Euro:");

        double euro = Convert.ToDouble(Console.ReadLine());
        double euroToEuro = euro * 1.141;
        Console.WriteLine(euroToEuro + " Dollars");

    }
}
class EuroConverter : DollarConverter
{
    public void Euro()
    {
        Console.WriteLine("Enter Rupees:");

        double rupee = Convert.ToDouble(Console.ReadLine());
        double rupeeToEuro = rupee * 0.012;
        Console.WriteLine(rupeeToEuro + "Euro");
        Console.WriteLine("Enter Dollars:");

        double dollar = Convert.ToDouble(Console.ReadLine());
        double dollarToEuro = dollar * 0.88;
        Console.WriteLine(dollarToEuro + "Euro");
    }
}
class FinalConverter
{
    public static void Main(String[] args)
    {
        EuroConverter obj = new EuroConverter();
        int choice, ch;
        do
        {
            Console.WriteLine("Currency Converter");

            Console.WriteLine("1.Rupee\n2.Dollar\n3.Euro");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    obj.Rupee();
                    break;
                case 2:
                    obj.Dollar();
                    break;
                case 3:
                    obj.Euro();
                    break;
            }
            Console.WriteLine("Enter 0 to quit and 1 to continue:");
            ch = int.Parse(Console.ReadLine());
        } while (ch == 1);
    }
}
