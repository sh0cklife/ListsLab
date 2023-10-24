List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{
    if (command.StartsWith("Contains"))
    {
        int numberContained = int.Parse(command.Split(" ")[1]);
        if (numbers.Contains(numberContained))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    {
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); // нов ред
    }
    else if (command == "PrintOdd")
    {
        foreach (int number in numbers)
        {
            if (number % 2  != 0)
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine(); // Нов ред
    }
    else if (command == "GetSum")
    {
        Console.WriteLine(numbers.Sum()); // намиране на сумата на елементите в списъка
    }
    else if (command.StartsWith("Filter"))
    {
        // [Filter] [<] [3] - структурата на командата
        string condition = command.Split(" ")[1]; // взимаме  <,>,>=,<=
        int number = int.Parse(command.Split(" ")[2]); // вимаме числото което ще проверяваме
        switch (condition)
        {
            case "<": numbers.RemoveAll(numberInList => numberInList >= number); break;
            case ">": numbers.RemoveAll(numberInList => numberInList <= number); break;
            case "<=": numbers.RemoveAll(numberInList => numberInList > number); break;
            case ">=": numbers.RemoveAll(numberInList => numberInList < number); break;
        }
    }

    command = Console.ReadLine();
}
Console.Write(string.Join(" ", numbers));
