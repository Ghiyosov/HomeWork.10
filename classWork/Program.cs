


List <string> list = new List<string>();  //1
list.AddRange(new[] {"apple", "banana", "orange"});//2
System.Console.WriteLine(list.Count);//3
foreach (var item in list)
{
    System.Console.WriteLine(item);//4
}
System.Console.WriteLine("-------------------------------------1");
list.Remove("banana");//5
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");

System.Console.WriteLine(list.Contains("apple"));//6
System.Console.WriteLine("-------------------------------------");

list.Clear();//7
foreach (var item in list)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");

List<string> list2;
list2 = new List<string>{"apple", "banana", "orange"};//8
list2.Insert(0,"grape");//9
foreach (var item in list2)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");

var b = list2[2];
list2.RemoveAt(2);
System.Console.WriteLine(b);  //10
if (list2.Count < 1) System.Console.WriteLine("pustoy");
else System.Console.WriteLine("Kol list :" + list2.Count);  // 11
System.Console.WriteLine("-------------------------------------");

list2.Sort();//12
foreach (var item in list2)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");

list2.Reverse();//13
foreach (var item in list2)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");

List<string> list3 = new List<string>();
list3.Add("kivi");
list3.AddRange(list2); //14
foreach (var item in list3)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");

for (int i = 0; i < list3.Count; i++)//15
{
    if (list3[i] == "apple") System.Console.WriteLine(i);    
}
System.Console.WriteLine("-------------------------------------");
list3.RemoveAll(p=>p.Length==5);//16
foreach (var item in list3)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");
int a=0;
foreach (var item in list3)//17
{
    if(item[0] == 'a') a++;
}
System.Console.WriteLine(a);
System.Console.WriteLine("-------------------------------------");
list3.Reverse();
foreach (var item in list3)
{
    System.Console.WriteLine(item);
}
System.Console.WriteLine("-------------------------------------");
string rr = string.Join(',' ,list3);
System.Console.WriteLine(rr);





