namespace IntroOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); // Skapar cirkel med radie 5
            double area1 = circle1.GetArea(); // Beräknar area för cirkeln
            Console.WriteLine("Cirkeln med radie 5 har en area på: " + area1); // Skriver ut i konsolen

            Circle circle2 = new Circle(6); // Skapar cirkel med radie 6
            double area2 = circle2.GetArea(); // Beräknar area för cirklen
            Console.WriteLine("Cirkeln med radie 6 har en area på: " + area2); //Skriver ut i konsolen
        }
    }
}
