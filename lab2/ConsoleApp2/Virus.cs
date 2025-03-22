using System;
using System.Collections.Generic;

public class Virus : ICloneable
{
    public string Name { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; }

    public Virus(string name, string species, double weight, int age)
    {
        Name = name;
        Species = species;
        Weight = weight;
        Age = age;
        Children = new List<Virus>();
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public object Clone()
    {
        Virus clonedVirus = (Virus)this.MemberwiseClone();

        clonedVirus.Children = new List<Virus>();
        foreach (var child in this.Children)
        {
            clonedVirus.Children.Add((Virus)child.Clone());
        }

        return clonedVirus;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Virus: {Name}, Species: {Species}, Weight: {Weight}, Age: {Age}");
        Console.WriteLine("Children:");
        foreach (var child in Children)
        {
            child.DisplayInfo();
        }
    }
}
