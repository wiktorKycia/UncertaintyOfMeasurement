namespace UncertaintyOfMeasurement;
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

        double[] measurementsA = new double[amount];
        double[] measurementsB = new double[amount];

        for (int i = 0; i < amount; i++)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Side A: ");
                Console.WriteLine($"Measurement {i+1}: ");
            } while (!double.TryParse(Console.ReadLine(), out measurementsA[i]));
        }
        for (int i = 0; i < amount; i++)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Side B: ");
                Console.WriteLine($"Measurement {i+1}: ");
            } while (!double.TryParse(Console.ReadLine(), out measurementsB[i]));
        }

        double averageOfA = 0;
        for (int i = 0; i < amount; i++)
        {
            averageOfA += measurementsA[i];
        }
        double averageOfB = 0;
        for (int i = 0; i < amount; i++)
        {
            averageOfB += measurementsB[i];
        }

        double deltaA = measurementsA.Max() - measurementsA.Min();
        double deltaB = measurementsB.Max() - measurementsB.Min();

        double AreaMax = (averageOfA + deltaA) * (averageOfB + deltaB);
        double AreaMin = (averageOfA - deltaA) * (averageOfB - deltaB);
    }
}
