List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "end")
{

    if (command.StartsWith("Add"))
    {
        int numberToAdd = int.Parse(command.Split(" ")[1]); // сплит в масив и взимаме елемента на първа позиция, [0],[1], парснат в инт
        numbers.Add(numberToAdd); // // дай ми списъка Numbers и накрая добави числото
    }
    else if (command.StartsWith("RemoveAt"))
    {
        int indexToRemove = int.Parse(command.Split(" ")[1]);
        numbers.RemoveAt(indexToRemove);
    }
    else if (command.StartsWith("Remove"))
    {
        int numberToRemove = int.Parse(command.Split(" ")[1]); // сплит в масив и взимаме елемента на първа позиция, (достъпваме до числото) парснат в инт
        numbers.Remove(numberToRemove); // класическо премахване на елемент от листа
    }
    else if (command.StartsWith("Insert"))
    {
        int numberToInsert = int.Parse(command.Split(" ")[1]);
        int indexToInsert = int.Parse(command.Split(" ")[2]);
        numbers.Insert(indexToInsert, numberToInsert);
    }

    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));
