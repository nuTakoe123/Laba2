namespace  Quest4
{
	class Program
	{
		static void Main()
		{
			Console.Write("Введите номер дня недели (1-7): ");
			int dayNumber = int.Parse(Console.ReadLine());

			string dayName;

			switch (dayNumber)
			{
				case 1:
					dayName = "Понедельник";
					break;
				case 2:
					dayName = "Вторник";
					break;
				case 3:
					dayName = "Среда";
					break;
				case 4:
					dayName = "Четверг";
					break;
				case 5:
					dayName = "Пятница";
					break;
				case 6:
					dayName = "Суббота";
					break;
				case 7:
					dayName = "Воскресенье";
					break;
				default:
					dayName = "Неизвестный день";
					break;
			}

			Console.WriteLine(dayName);
		}
	}
}