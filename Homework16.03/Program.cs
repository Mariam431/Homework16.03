namespace AbstractCLasses
{
    internal class Program
    {
        abstract class A
        {
            abstract public void Print();
            public void Print1()
            {
                Console.WriteLine("Bye");
            }
        }
        class B : A
        {
            public override void Print()
            {
                Console.WriteLine("Hello");
            }
        }
        static void Main(string[] args)
        {
            A a = new B();
            a.Print();
            a.Print1();
        }
    }
}
