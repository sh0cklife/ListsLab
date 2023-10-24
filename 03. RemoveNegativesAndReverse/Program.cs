List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

numbers.RemoveAll(number => number < 0); // remove lal negative numbers from the list
numbers.Reverse(); // обръща елементите в обратен ред

if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", numbers)); // принти елементите в листа, разделени с ""
}
