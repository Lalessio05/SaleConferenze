namespace SaleConferenze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var UI = new UI();
            while (true)
            {
                switch (int.Parse(Console.ReadLine() ?? ""))
                {
                    case 0:
                        UI.AddConferenceRoom();
                        break;
                    case 1:
                        UI.ShowAllFromProvince();
                        break;
                    case 2:
                        UI.DisplayRoomsByUsage();
                        break;
                    case 3:
                        UI.ShowConferenceRoomsByMinSeats();
                        break;
                    case 4:
                        UI.ShowConferenceRoomsWithProjectorInProvince();
                        break;
                    case 5:
                        UI.FilterConferenceRoomsWithProjector();
                        break;
                    case 6:
                        UI.ShowConferenceRoomsByLastUsageTime();
                        break;
                    default:
                        break;

                }
            }
        }
    }
}