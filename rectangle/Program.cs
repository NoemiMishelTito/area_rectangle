internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Program that calculates the area of a rectangle");
        Console.WriteLine("Set the base of a rectangle");
        int base1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Set the height of a rectangle");
        int height = Convert.ToInt32(Console.ReadLine());
        int result = base1 * height;
        Console.WriteLine("The result of the area is: " + result);
    }
}