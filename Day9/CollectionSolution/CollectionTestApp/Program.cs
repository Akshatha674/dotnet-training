using System;
using CRM;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
string name = "CollectionTestApp";
int age = 31;

Console.WriteLine($"Hello, {name}. You are {age} years old.");

int[] numbers = { 21, 12, 73, 24, 35 };
Console.WriteLine($"Before Sorting: {numbers}");
string[] fruits = { "Apple", "Banana", "Cherry" };

foreach (var number in numbers)
{
    Console.WriteLine($"Number: {number}");
}
foreach (var fruit in fruits)
{
    Console.WriteLine($"Fruit: {fruit}");
}

Customer customer1 = new Customer(1, "Alice");
Customer customer2 = new Customer(2, "Gob");

Customer[] customers = new Customer[] { customer1, customer2 };
foreach (var customer in customers)
{
    Console.WriteLine(customer);
}

List<Customer> customerList = new()
{
    new Customer(3, "Charlie"),
    new Customer(4, "Diana"),
    customer1,
    customer2
};

foreach (var customer in customerList)
{
    Console.WriteLine(customer);
}

Array.Sort(numbers);
Console.WriteLine($"After Sorting: {numbers}");

foreach (var number in numbers)
{
    Console.WriteLine($"Number: {number}");
}
Array.Sort(fruits);
Console.WriteLine($"After Sorting: {fruits}");
foreach (var fruit in fruits)
{
    Console.WriteLine($"Fruit: {fruit}");
}
customerList.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));
Console.WriteLine($"After Sorting: {customerList}");
foreach (var customer in customerList)
{
    Console.WriteLine($"Customer: {customer}");
}

Dictionary<string, Customer> customerDirectory = new Dictionary<string, Customer>();
customerDirectory.Add("54455465", new Customer(1, "Alice"));
customerDirectory.Add("6768768", new Customer(1, "Bob"));
customerDirectory.Add("14324324", new Customer(3, "Charlie"));
customerDirectory.Add("7576878", new Customer(4, "Diana"));
foreach (var kvp in customerDirectory)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// Customer customerSerialized = new Customer(1, "Akshatha");
string serializedData = JsonSerializer.Serialize(customerList);
Console.WriteLine($"Serialized Customer: {serializedData}");
File.WriteAllText("customers.json", serializedData);

string deserializedData = File.ReadAllText("customers.json");
List<Customer>? deserializedCustomers = JsonSerializer.Deserialize<List<Customer>>(deserializedData);
if (deserializedCustomers != null)
{
    foreach (var customer in deserializedCustomers)
    {
        Console.WriteLine($"Deserialized Customer: {customer}");
    }
}
