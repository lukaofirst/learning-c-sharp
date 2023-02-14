/* --- Overriding and Overhiding Methods --- */

A a1 = new A();
a1.Print();
Console.WriteLine();

B b1 = new B();
b1.Print();
A a2 = new B();
a2.Print();
Console.WriteLine();

C c1 = new C();
c1.Print();
A a3 = new C();
a3.Print();

class A
{
    public virtual void Print()
    {
        Console.WriteLine("I'm BaseClass");
    }
}

class B : A
{
    public override void Print()
    {
        Console.WriteLine("I'm Derived Class and I overrided the base method");
    }
}

class C : A
{
    public new void Print()
    {
        Console.WriteLine("I'm Derived Class and I overhiding the base method");
    }
}