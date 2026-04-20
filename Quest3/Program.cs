namespace  Quest3;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        
        string result = (number % 2 == 0) ? "четное" : "нечетное";
        Console.WriteLine($"Число {number} — {result}.");

    }
}