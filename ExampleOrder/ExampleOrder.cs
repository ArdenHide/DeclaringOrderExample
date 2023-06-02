namespace ExampleOrder;

using System;

public class ExampleOrder
{
    // Events
    public event EventHandler ExampleEvent = null!;

    // Finalizer (if necessary)
    ~ExampleOrder()
    {
        // Perform cleanup logic here, if needed.
    }

    // Constructors
    public ExampleOrder()
    {
        _privateField = 0;
    }

    public ExampleOrder(int initialValue)
    {
        _privateField = initialValue;
    }

    // Constants and static readonly fields
    public const string ClassName = "ExampleOrder";
    private static readonly int MaxItems = 100;

    // Private fields
    private int _privateField;

    // Public, protected, and internal properties
    public int PublicProperty { get; set; }
    protected int ProtectedProperty { get; set; }
    internal int InternalProperty { get; set; }

    // Private methods
    private void PrivateMethod()
    {
        Console.WriteLine("Private method called.");
    }

    // Public, protected, and internal methods
    internal void InternalMethod()
    {
        Console.WriteLine("Internal method called.");
    }

    public void PublicMethod()
    {
        Console.WriteLine("Public method called.");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method called.");
    }

    // Indexers
    public int this[int index]
    {
        get { return _privateField; }
        set { _privateField = value; }
    }

    // Operators
    public static ExampleOrder operator +(ExampleOrder a, ExampleOrder b)
    {
        return new ExampleOrder(a._privateField + b._privateField);
    }

    // Nested types
    public enum ExampleEnum
    {
        FirstValue,
        SecondValue
    }

    public struct ExampleStruct
    {
        public int Field;

        public ExampleStruct(int field)
        {
            Field = field;
        }
    }

    public class NestedClass
    {
        public int Field;

        public NestedClass(int field)
        {
            Field = field;
        }
    }

    public interface INestedInterface
    {
        void InterfaceMethod();
    }
}
