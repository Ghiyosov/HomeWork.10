List<string> list = new List<string>{"Ismoil","Ghiyosov"};
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
list.Remove("Ghiyosov");
foreach (var item in list)
{
    System.Console.WriteLine(item);
}