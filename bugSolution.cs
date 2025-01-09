public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static implicit operator int(MyClass obj)
    {
        return obj.MyProperty;
    }

    public static implicit operator MyClass(int value)
    {
        return new MyClass(value);
    }

    public static MyClass operator +(MyClass obj, int value)
    {
        return new MyClass(obj.MyProperty + value);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        MyClass obj1 = 10; // Implicit conversion from int to MyClass
        int value1 = obj1; // Implicit conversion from MyClass to int

        MyClass obj2 = new MyClass(20);
        int value2 = obj2 + 5; // Now works correctly due to the overloaded + operator
        Console.WriteLine(value2); // Output: 25
    }
}