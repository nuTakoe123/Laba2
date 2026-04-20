namespace  Quest7;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person[] people = new[]
        {
            new Person("Анна", 5),
            new Person("Борис", 15),
            new Person("Виктор", 30),
            new Person("Галина", 70),
            new Person("Дмитрий", 17)
        };
        
        foreach (var person in people)
        {
            string greeting = person switch
            {
                { Age: < 12 } => $"Привет, малыш {person.Name}!",
                { Age: >= 12 and < 18 } => $"Здорово, подросток {person.Name}!",
                { Age: >= 18 and < 65 } => $"Добрый день, {person.Name}.",
                { Age: >= 65 } => $"Здравствуйте, уважаемый {person.Name}!",
                _ => $"Привет, {person.Name}!"
            };
    
            Console.WriteLine(greeting);
        }
    }
}