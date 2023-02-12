namespace SaleConferenze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var banana = new ConferenceRoomsHandler();
            banana.SortRooms((p, p1) => 5);
        }
    }
}