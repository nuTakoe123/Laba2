namespace Quest2
{
    class Quest2
    {
        static void Main()
        {
            Console.Write("Вводи температуру: ");
            string tempa = Console.ReadLine() ?? "";

            if (int.Parse(tempa) < -20)
            {
                Console.WriteLine("Экстремально холодно, останься дома");
            }
            else if((int.Parse(tempa) < 0) && (int.Parse(tempa) > -20))
            {
                Console.WriteLine("Холодно");
            }
            else if((int.Parse(tempa) > 1) && (int.Parse(tempa) < 15))
            {
                Console.WriteLine("Прохладно");
            }
            else if ((int.Parse(tempa) > 16) && (int.Parse(tempa) < 25))
            {
                Console.WriteLine("Тепло");
            } 
            else if (int.Parse(tempa) > 25)
            {
                Console.WriteLine("Жарко");
            }
// Ответ на котрольный вопрос: Будет ошибка. Можно использовать try/TryParse чтоб отловить ее

        }
    }
}

