namespace prjIndexesIceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create object
            CarService wroem = new CarService(10000, "BMW", "225/65/18", "Black", "minor");
            new CarService(11000, "GWM", "235/75/17", "Gray", "major");

            //output all values using int index and string index
            Console.WriteLine(wroem[0]);
            Console.WriteLine(wroem[1]);

            Console.WriteLine("ServiceInterval: " + wroem["serviceInterval"]);
            Console.WriteLine("CarName: " + wroem["carName"]);
            Console.WriteLine("TyreSize: " + wroem["tyreSize"]);
            Console.WriteLine("Colour: " + wroem["colour"]);
            Console.WriteLine("TypeOfService: " + wroem["typeOfService"]);
        }
    }
}
