﻿namespace UncertaintyOfMeasurement;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("We will be calculating the area of a page of paper");
        int amount;
        do
        {
            Console.Clear();
            Console.WriteLine("How many measurements are we going to do?");
        } while (!int.TryParse(Console.ReadLine(), out amount));

        double[] measurements = new double[amount];
    }
}
