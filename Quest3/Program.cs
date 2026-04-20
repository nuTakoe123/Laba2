namespace  Quest3;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int message = int.Parse(Console.ReadLine());
        
        string result = (message < 0) ? "Холодно, надень куртку." : "Тепло, можно гулять."; 
        Console.WriteLine(result);
    }
}