namespace IntroOOP
{
    public class Circle
    {
        private float _pi = 3.141f; // Variabel för PI
        private int _Radius; // Variabel för Radie

        public Circle (int radie) // Konstruktor med radie som parameter
        {
            _Radius = radie; // Tilldelar radie variabeln värde
        }

        public double GetArea() // Metod för att räkna ut area
        {
            return _Radius * _Radius * _pi; // Beräknar area enligt formel och returnerar svaret
        }
    }
}
