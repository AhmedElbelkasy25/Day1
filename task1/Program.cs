namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int smCarpetPrice = 25;
            int lgCarpetPrice = 35;
            double tax = 1.06;
            Console.Write("Number Of Small Carpet: ");
            int smCarpetNum = int.Parse(Console.ReadLine());
            Console.Write("Number Of Large Carpet: ");
            int lgCarpetNum = int.Parse(Console.ReadLine());
            int cost = (smCarpetNum * smCarpetPrice) + (lgCarpetPrice * lgCarpetNum);
            double totalCost = cost * tax;
            Console.WriteLine($"Total Estimated: {totalCost}$");
            Console.WriteLine("This Estimated Is Valid For 30 Days...");
        }
    }
}
