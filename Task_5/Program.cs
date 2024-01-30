List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
Console.WriteLine("The filtered numbers are:");
var evenNumbers = numbers.FindAll(num=>num%2==0);
foreach(int number in evenNumbers)
{
 Console.WriteLine(number);
}