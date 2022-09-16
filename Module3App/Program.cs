namespace Module3App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.Write("Enter your age: ");
            var age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine($"Your name is {name} and age is {age}");
            Console.Write("Enter your birthdate: ");
            var birthdate = Console.ReadLine();
            Console.WriteLine("Your birthdate is " + birthdate);
            Console.ReadKey();
            /*string myName = "Dan";
            byte age = 27;
            bool hasAPet = true;
            double shoeSize = 44.5;
            Console.WriteLine();
            Console.WriteLine("Привет, {0}!",myName);
            Console.WriteLine("Йоу \x23");
            Console.WriteLine("Мой возраст {0}", age);
            Console.WriteLine("У меня есть питомец? {0}", hasAPet);
            Console.WriteLine("Мой размер ноги  - {0}", shoeSize);
            DayOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your Fav Day is {0}", day);*/
        }
    }
    /*enum DaysOfWeek : byte
    {
    Monday = 1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
    }
    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }*/
}