using Task2;

namespace Task2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Runway runway1 = new Runway();
            Runway runway2 = new Runway();

            RunwayManager runwayManager = new RunwayManager(new List<Runway> { runway1, runway2 });

            CommandCentre commandCentre = new CommandCentre(runwayManager);

            Aircraft aircraft1 = new Aircraft("Airplane 1");
            Aircraft aircraft2 = new Aircraft("Airplane 2");
            Aircraft aircraft3 = new Aircraft("Airplane 3");

            Console.WriteLine("Aircrafts in queue:");
            Console.WriteLine($"{aircraft1.Name}, {aircraft2.Name}, {aircraft3.Name}");

            aircraft1.RequestLanding(commandCentre);
            aircraft2.RequestLanding(commandCentre);
            aircraft3.RequestLanding(commandCentre);
        }
    }
}