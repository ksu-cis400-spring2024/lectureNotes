
using InheritanceExamples;

Shirt s = new PoloShirt();
Console.WriteLine(s.Price);
Console.WriteLine(s.Quantity);

//s = new Shirt(); NOOO! Shirt is abstract