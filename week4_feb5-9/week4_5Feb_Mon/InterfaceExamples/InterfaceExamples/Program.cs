// See https://aka.ms/new-console-template for more information
using InterfaceExamples;

Console.WriteLine("Hello, World!");

SortedSet<Dog> dogs = new SortedSet<Dog>{new Dog(), new Dog()};

foreach (Dog d in dogs) Console.WriteLine(d); //crashes now
