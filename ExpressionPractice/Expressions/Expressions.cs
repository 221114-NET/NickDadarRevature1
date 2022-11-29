namespace ExpressionsName;
class Expressions
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Cat test = new Cat("Fluffy");
        Console.WriteLine(test[0]);
        test[0] = "Cyan";
        Console.WriteLine(test[0]);

        Console.WriteLine($"Name: {test.catName}   Color: {test[0]}");
    }
}

public class Cat {
    public string catName;
    private string[] color = {"Red","Blue","Green","Orange","Black"};
    public Cat(string name) => catName = getCatName();

    public string this[int i] {
        get => color[i];
        set => color[i] = value;
    }


    public string getCatName() {
        Console.WriteLine("Enter a cat name: ");
        String ?result = Console.ReadLine();
        if (result.Equals("")) return "a"; 
        return result;
    }

}
