public class Person {
    private int _age;

    public int Age => _age;

    public string Name {get;}
}

//what different ways could _age be initialized? what if _age was public?
    //how to ensure Age is never negative (without a uint?)

//what different ways could Name be initialized?
    //(is there any way to do so without editing the Person class?)

//if we DON'T take steps to initialize, what happens?