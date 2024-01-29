public class Person {
    private int _age;

    public int Age => _age;

    public string Name {get;}

    public Address CurrentAddress { get; set; }
}

//what different ways could _age be initialized? what if _age was public?
    //how to ensure Age is never negative (without a uint?)

//what different ways could Name be initialized?
    //(is there any way to do so without editing the Person class?)

//if we DON'T take steps to initialize, what happens?

//how can we ENSURE that person's address is initialized?

public class Address {
    public uint Number { get; }

    public string Street { get; }

    public string City { get; }

    public string State { get; }

    public Address (uint num, string street, string city, string state) {
        Number = num;
        Street = street;
        City = city;
        State = state;
    }
}