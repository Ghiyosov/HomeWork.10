# Home Task 1 

## Task 1
Create a list of integers and display the sum of all the elements in the list.           
Создайте список целых чисел и отобразите сумму всех элементов в списке.                

```csharp
List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
int sum;
Console.WriteLine("The sum of all the elements in the list is: " + sum);
```
## Task 2
Create a list of strings and concatenate all the strings into a single string.                 
Создайте список строк и объедините все строки в одну строку.                      
```csharp
List<string> words = new List<string>{ "hello", "world", "!" };
string concat;
Console.WriteLine("The concatenated string is: " + concat);
```
 
## Task 3 
 Create a list of dates and sort them in ascending order.                  
 Создайте список дат и отсортируйте их по возрастанию.                

```csharp
List<DateTime> dates = new List<DateTime>
{
new DateTime(2020, 10, 1),
new DateTime(2022, 8, 15),
new DateTime(2021, 4, 28)
};
Console.WriteLine("The sorted dates are:");
foreach(DateTime date in dates)
{
 Console.WriteLine(date.ToShortDateString());
}
```
## Task 4
Create a list of doubles and find the average value of all the elements in the list.                
Создайте список двойников и найдите среднее значение всех элементов в списке.                     

```csharp
List<double> numbers = new List<double>{ 3.5, 2.7, 6.9, 1.2 };
Console.WriteLine("The average value of all the elements in the list is: " + average);
```
## Task 5
Create a list of integers and print all elements that are even. (use `FindAll` method).                
Создайте список целых чисел и выведите все четные элементы. (используйте метод `FindAll`)                   

```csharp
List<int> numbers = new List<int>{ 1, 2, 3, 4, 5 };
Console.WriteLine("The filtered numbers are:");
foreach(int number in evenNumbers)
{
 Console.WriteLine(number);
}
```
## Task 6
Create a list of booleans and check if all the elements in the list are true. (use `All` method).                         
Создайте список логических значений и проверьте, все ли элементы в списке верны. (используйте метод `All`)                         

```csharp 
List<bool> values = new List<bool>{ true, true, true };
Console.WriteLine("Are all the values in the list true? " + allTrue);
```
## Task 7
Removing an element from a list.             
Удаление элемента из списка.                     
    
## Task 8
Searching for an element in a list.                  
Поиск элемента в списке.               

## Task 9
Adding items to a list and displaying them.                       
Добавление элементов в список и их отображение.                          

## Task 10
Create a list and fill it with random numbers. Print all the numbers                 
Создайте список и заполните его случайными числами. Распечатайте все числа.                     





