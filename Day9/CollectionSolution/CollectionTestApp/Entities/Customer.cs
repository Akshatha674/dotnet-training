
using System;
using System.Collections.Generic;
using CRM;

namespace CRM;

public class Customer : IComparable<Customer>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Customer(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public override string ToString()
    {
        return $"Customer ID: {Id}, Name: {Name}";
    }
     public int CompareTo(Customer? other)
    {
        if (other is null) return 1;
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }
}