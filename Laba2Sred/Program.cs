// Задание 1

using System; // Где-то читал, что уже не надо прописовать базовые юзинги

Console.Write("Вводи температуру: ");
string tempa = Console.ReadLine() ?? "";

if (int.Parse(tempa) < 0)
{
    Console.WriteLine("Холодно, надень куртку.");
}
else
{
    Console.WriteLine("Тепло, можно гулять.");
}
// Ответ на котрольный вопрос: Будет ошибка. Можно использовать try/TryParse чтоб отловить ее
