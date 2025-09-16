namespace ConsoleApp7
{
    internal class Auto
    {
        public string Marke { get; set; }
        public string Model { get; set; }
        public int Ps { get; set; }

        public void Starten()
        {
            Console.WriteLine($"Marke: {Marke} Model: {Model} Ps: {Ps}");
        }
    }
}
