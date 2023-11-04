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
        averageOfA /= amount;
        
        double averageOfB = 0;
        for (int i = 0; i < amount; i++)
        {
            averageOfB += measurementsB[i];
        }
        averageOfB /= amount;

        double deltaA = measurementsA.Max() - measurementsA.Min();
        double deltaB = measurementsB.Max() - measurementsB.Min();

        double areaMax = (averageOfA + deltaA) * (averageOfB + deltaB);
        double areaMin = (averageOfA - deltaA) * (averageOfB - deltaB);

        double deltaArea = (areaMax - areaMin) / 2;

        int numberOfDigits = 0;
        string stringDeltaArea = deltaArea.ToString();
        if (stringDeltaArea.Contains('.'))
        {
            int len = stringDeltaArea.Length;
            for(int i = 0; i<len; i++)
            {
                if (stringDeltaArea[i] == '.')
                {
                    numberOfDigits = len - i - 1;
                }
            }
        }
        else if (stringDeltaArea.Contains(','))
        {
            int len = stringDeltaArea.Length;
            for(int i = 0; i<len; i++)
            {
                if (stringDeltaArea[i] == ',')
                {
                    numberOfDigits = len - i - 1;
                }
            }
        }

        double averageOfArea = Math.Round(averageOfA * averageOfB, numberOfDigits);

        double finalResult = Math.Ceiling(averageOfArea);


        double help = averageOfArea * Math.Pow(10, numberOfDigits);
        help -= help % Math.Pow(10, numberOfDigits - 1);
        help /= Math.Pow(10, numberOfDigits);
        if (numberOfDigits > 1){ help += 0.1;}
        
        Console.WriteLine(help);
        Console.WriteLine(finalResult + " (+/-)" +Math.Ceiling(deltaArea));
    }
}
