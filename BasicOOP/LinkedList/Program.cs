// See https://aka.ms/new-console-template for more information
using LinkedList.classes;

Console.WriteLine("Hello, World!");

var list = new SinglyLinkedList<int>();

list.AddToFront(10);
list.AddToFront(20);
list.AddToFront(30);
list.Add(40);
list.Add(50);
list.Remove(20);
list.Remove(30);

var arr = new int[7];

list.CopyTo(arr, 1);

foreach (var item in list)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine(list.Count);

Console.ReadKey(); 

