namespace SaleConferenze
{
    public enum Province { Varese, Como, Lecco, Milano }
    internal class ConferenceRoomsHandler
    {
        private List<ConferenceRoom> conferenceRooms;

        public ConferenceRoomsHandler()
        {
            conferenceRooms = new List<ConferenceRoom>();
        }
        public void AddConferenceRoom(ConferenceRoom conferanceRoom)
        {
            conferenceRooms.Add(conferanceRoom);
        }
        public void VisualizeData(Predicate<ConferenceRoom> lambda)
        {
            conferenceRooms.FindAll(lambda).ForEach(Console.WriteLine);
        }
        public void SortRooms(Comparison<ConferenceRoom> lambda)
        {
            conferenceRooms.Sort(lambda);
        }
    }
}
