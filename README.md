# DeclaringOrderExample

[Class example](#class-example)

In a C# class, you can declare various elements such as fields, properties, constructors, methods, events, indexers, operators, and nested types.
While there's no strict order enforced by the C# language, it's common to follow a certain convention for readability and maintainability.

A typical order for declaring elements in a C# class is as follows:

1. Constants and static readonly fields
2. Private fields
3. Public, protected, and internal properties
4. Constructors
5. Finalizers (if necessary)
6. Public, protected, and internal methods
7. Private methods
8. Events
9. Indexers
10. Operators
11. Nested types (e.g., enums, structs, classes, and interfaces)

It's worth noting that these conventions may vary between different development teams and projects, so it's essential to be consistent with the style guide or convention followed by your team or organization.
Additionally, many developers prefer to group elements by their accessibility (public, protected, internal, and private) before grouping them by their type.

## Class Example

```csharp
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
    public event EventHandler ExampleEvent;

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
```
