namespace ExampleOrder;

using System;

public class ExampleOrder
{
    // Constants and static readonly fields
    public const string ClassName = "ExampleOrder";
    private static readonly int MaxItems = 100;

    // Private fields
    private int _privateField;

    // Public, protected, and internal properties
    public int PublicProperty { get; set; }
    protected int ProtectedProperty { get; set; }
    internal int InternalProperty { get; set; }

    // Constructors
    public ExampleOrder()
    {
        _privateField = 0;
    }

    public ExampleOrder(int initialValue)
    {
        _privateField = initialValue;
    }

    // Finalizer (if necessary)
    ~ExampleOrder()
    {
        // Perform cleanup logic here, if needed.
    }

    // Public, protected, and internal methods
    public void PublicMethod()
    {
        Console.WriteLine("Public method called.");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method called.");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal method called.");
    }

    // Private methods
    private void PrivateMethod()
    {
        Console.WriteLine("Private method called.");
    }

    // Events
    public event EventHandler ExampleEvent = null!;

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