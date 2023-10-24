List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();
while (command != "end")
{
    string[] commandParts = command.Split(" "); // разделяме елементите с ""
    string commandName = commandParts[0]; // името на командата: "Delete" / "Insert"
    int element = int.Parse(commandParts[1]); // преобразуваме от стринг в инт с парсване

    if (commandName == "Delete")
    {
        numbers.RemoveAll(num => num == element); // ако number 5 = елемент 5, премахваме елемента ако условието е вярно
    }
    else if (commandName == "Insert")
    {
        int position = int.Parse(commandParts[2]);
        numbers.Insert(position, element);
    }


    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));