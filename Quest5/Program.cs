object[] testData = { 42, "Hello, World!", 3.14, true, null, new DateTime(2025, 2, 23) };

foreach (var data in testData)
{
    ProcessInput(data);
}

void ProcessInput(object? input)
{
    // TODO: Реализуйте проверку типа с использованием input is Type variable
    // 1. Если int - вывести квадрат числа
    // 2. Если string - вывести длину строки и её первый символ
    // 3. Если double - вывести число с двумя знаками после запятой
    // 4. Если bool - вывести "Истина" или "Ложь" на русском
    // 5. Если null - вывести "Получен null"
    // 6. Для остальных типов - вывести "Неизвестный тип: " + имя типа
    
    if (input is int intValue)
    {
        Console.WriteLine($"Получено целое число: {intValue}, квадрат = {intValue * intValue}");
    }
    else if (input is string strValue)
    {
        Console.WriteLine($"Получена строка: {strValue}, длина: {strValue.Length}, первый символ: {strValue[0]}");
    }
    else if (input is double doubleValue)
    {
        Console.WriteLine($"Получено вещественное число: {doubleValue}, два занака после запятой: {doubleValue:F2}");
    } else if (input is bool boolValue)
    {
        Console.WriteLine(boolValue ? "истина" : "лож");
    }else if (input == null)
    {
        Console.WriteLine("получен null");
    }
    else
    {
        Console.WriteLine($"Неизвестный тип: {input.GetType().Name ?? "null"}");
    }
}
