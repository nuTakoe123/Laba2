object ?data = null;

string description = data switch
{
    int i when i > 100 => $"Большое число {i}",
    int i => $"Обычное число {i}, квадрат = {i * i}",
    string s => $"Текст длиной {s.Length}: \"{s}\"",
    double d => $"Вещественное число: {d:F2}",
    bool b => b ? "Истина" : "Ложь",
    null => "Пусто (null)",
    DateTime dt => $"Дата и время: {dt:dd.MM.yyyy HH:mm}",
    _ => $"Неизвестный тип: {data.GetType().Name}"
};

Console.WriteLine(description);