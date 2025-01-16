public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass(int value)
    {
        MyProperty = value;
    }

    public void MyMethod()
    {
        // Correctly accessing the member after the constructor has finished initializing the object
        int temp = MyProperty; //store a temp variable if needed
        Console.WriteLine(MyProperty);
    }
}