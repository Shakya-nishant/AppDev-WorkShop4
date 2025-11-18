
namespace Task_5;
class Program
{
    static void Main(string[] args)
    {
        // DayType Part 

        Console.Write("Enter a day (Example: Sunday): ");
        string day = Console.ReadLine().Trim().ToLower();

        DayType type;

        if (day == "friday" || day == "saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine($"It is: {type}");

        // Book Record Part 

        // First book object
        Book b1 = new Book("The Alchemist", "Paulo Coelho", 999.50);

        // Second object using with expression (change title + price)
        Book b2 = b1 with { title = "Rich Dad Poor Dad", price = 550.75 };

        // Print first object
        Console.WriteLine("\nFirst Book Object:");
        Console.WriteLine($"Title: {b1.title}, Author: {b1.author}, Price: {b1.price}");

        // Deconstruct second object
        var (title, author, price) = b2;

        Console.WriteLine("\nDeconstructed Second Book:");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}
