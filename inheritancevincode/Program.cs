namespace inheritancevincode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");// vaidame et otsime selle VIN koodi 4Y1-SL658-4-8-Z-41-1439
            Console.WriteLine("Sisesta VIN kood");
            string e = Console.ReadLine();
            Cars car = new Cars();
            Console.WriteLine("----------------------");
            if (e == car.car1)
            {
                Console.WriteLine("Edukalt sisestatud VIN kood: {0}", e);
                Console.WriteLine("See auto on {0}.", car.model);
            }
            else
            {
                Console.WriteLine("See VIN kood ei eksisteeri!");
            }

        }
    }
    class Cars : Machine
    {
        public string model = "E28";
    }
    class Machine
    {
       public string car1 = "4Y1-SL658-4-8-Z-41-1439";
    }
}
