using ProvaEstágio3;
using System;

class Program
{
    static void Main()
    {
       
        Console.WriteLine("Enter with your salary:");
        double salary = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your readjustment:");
        double readjust = double.Parse(Console.ReadLine());

        Readjustment newRead = new Readjustment(salary, readjust);

        newRead.CalculateReadjustment();
        Console.WriteLine("New salary:" + newRead);
    }
}