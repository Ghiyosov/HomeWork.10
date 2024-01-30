List<string> list = new List<string> { "Ismoil", "Ghiyosov" };
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
Console.WriteLine(list.Exists(p => p == "Ghiyosov"));