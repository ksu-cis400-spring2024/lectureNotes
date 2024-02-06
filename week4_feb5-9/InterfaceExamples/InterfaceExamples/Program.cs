// See https://aka.ms/new-console-template for more information
using InterfaceExamples;

/*
List<IAnimal> list = new();
list.Add(new Chicken());
list.Add(new Dog());

//no! can't create object of an interface type
//IAnimal a = new IAnimal();

foreach(IAnimal o in list)
{
    Console.WriteLine(o.Sound());
}
*/

Dog? d = null;
d?.Print();
