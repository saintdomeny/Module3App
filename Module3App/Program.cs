namespace Module3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = "Dan";
            byte age = 27;
            bool hasAPet = true;
            double shoeSize = 44.5;
            Console.WriteLine();
            Console.WriteLine("Привет, {0}!",myName);
            Console.WriteLine("Йоу \x23");
            Console.WriteLine("Мой возраст {0}", age);
            Console.WriteLine("У меня есть питомец? {0}", hasAPet);
            Console.WriteLine("Мой размер ноги  - {0}", shoeSize);
            Console.ReadKey();
        }
    }
}