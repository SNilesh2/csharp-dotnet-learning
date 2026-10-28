
using System;

class Program
{
    static void Main(string[] args)
    {
        // Box that stores an integer
        Console.WriteLine("Generic Box Example");
        Box<int> intBox = new Box<int>(123);
        Console.WriteLine($"Integer Value: {intBox.GetValue()}");

        intBox.SetValue(456);
        Console.WriteLine($"Integer Value: {intBox.GetValue()}");

        // Box that stores a string
        Box<string> stringBox = new Box<string>("Hello, Generics!");
        Console.WriteLine($"String Value: {stringBox.GetValue()}");

        stringBox.SetValue("Generics are powerful!");
        Console.WriteLine($"String Value: {stringBox.GetValue()}");


        // Generic method example
        Console.WriteLine();
        Console.WriteLine("Generic Method Example");

        static void print<T>(T value)
        {
            Console.WriteLine($"Value: {value}");
        }

        print(20);
        print("Generic Method");
        print(3.14);


        static T Max<T>(T a,T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        Console.WriteLine($"Maximum of 10 and 20: {Max(10, 20)}");
        Console.WriteLine($"Maximum of 'apple' and 'banana': {Max("apple", "banana")}");


        // Generic Repository example
        Console.WriteLine();
        Console.WriteLine("Generic Repository Example");
        Repository<Product> productRepository = new Repository<Product>();
        productRepository.Add(new Product(1, "Laptop"));
        productRepository.Add(new Product(2, "Mouse"));
        productRepository.Add(new Product(3, "Keyboard"));

        var product = productRepository.GetById(2);
        if (product != null)
        {
            Console.WriteLine($"Found Product: {product.Name}");
        }
    }
}


class Product
{
    public string Name { get; set; }
    public int Id { get; set; }
    public Product(int id ,string name)
    {
        Id = id;
        Name = name;
    }
}


class Repository<T> where T : class
{
    private readonly List<T> _items = new List<T>();    

    public void Add(T item)
    {
        _items.Add(item);
    }


    public T? GetById(int id)
    {
        foreach (var item in _items)
        {
            if (item is Product product && product.Id == id)
            {
                return item;
            }
        }
        return null;
    }
}

class Box<T>
{
    private T _value;

    public Box(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }

    public void SetValue(T value)
    {
        _value = value;
    }
}
