namespace NickHelloWorld;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Nick!");
        Console.WriteLine(incNum(5));
    }
        static int incNum(int x) {
            return ++x;
            }
}
