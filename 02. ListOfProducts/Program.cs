int numberProducts = int.Parse(Console.ReadLine());

List<string> products = new List<string>(); // списъка с продукти, за сега празен

for (int i = 1; i <= numberProducts; i++)
{
    string product = Console.ReadLine();
    products.Add(product); // към списъка на продуктите добави този продукт
}

products.Sort();
int number = 1;
foreach (string product in products)
{
    Console.WriteLine(number + "." + product);
    number++;
}