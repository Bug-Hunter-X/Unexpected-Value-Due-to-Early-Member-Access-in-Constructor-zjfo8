public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Accessing a member before the object is fully initialized
        Console.WriteLine(MyProperty); // This line might cause an unexpected value or exception
        MyProperty = 10;
    }
}