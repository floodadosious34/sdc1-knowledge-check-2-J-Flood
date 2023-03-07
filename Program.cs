using KnowledgeCheck2;
using System.Collections.Generic;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

List<Records> recordList = new List<Records>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myClass = new Records();

    Console.WriteLine($"Enter the value for Quality {i+1}");
    myClass.Quality = Console.ReadLine();

    Console.WriteLine($"Enter the value for Name {i+1}");
    myClass.Name = Console.ReadLine();

    recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()

foreach (var i in recordList)
{
    Console.WriteLine($"\r\nName: {i.Name}");
    Console.WriteLine($"Quality: {i.Quality}");
}