Console.Write("Ход игрока 1 (камень, ножницы, бумага): ");
string player1 = Console.ReadLine();
Console.Write("Ход игрока 2 (камень, ножницы, бумага): ");
string player2 = Console.ReadLine();

// Приводим к нижнему регистру для надежности
player1 = player1?.ToLower() ?? "";
player2 = player2?.ToLower() ?? "";

string gameResult = (player1, player2) switch
{
    ("камень", "ножницы") => "Победил игрок 1",
    ("камень", "бумага") => "Победил игрок 2",
    ("ножницы", "бумага") => "Победил игрок 1",
    ("ножницы", "камень") => "Победил игрок 2",
    ("бумага", "камень") => "Победил игрок 1",
    ("бумага", "ножницы") => "Победил игрок 2",
    (var a, var b) when a == b => "Ничья",
    _ => "Некорректный ввод"
};

Console.WriteLine(gameResult);