namespace SaleConferenze
{
     class ConferenceRoomsHandler
    {
        protected List<ConferenceRoom> ConferenceRooms { get; private set; }

        protected ConferenceRoomsHandler()
        {
            ConferenceRooms = new List<ConferenceRoom>();
        }
        protected void AddConferenceRoom(ConferenceRoom conferanceRoom)
        {
            ConferenceRooms.Add(conferanceRoom);
        }
        protected List<ConferenceRoom> VisualizeData(Predicate<ConferenceRoom> lambda)
        {
            return ConferenceRooms.FindAll(lambda);
        }
        protected void SortRooms(Comparison<ConferenceRoom> lambda)
        {
            ConferenceRooms.Sort(lambda);
        }
        protected void RemoveRooms(Predicate<ConferenceRoom> lamda)
        {
            ConferenceRooms.RemoveAll(lamda);
        }
    }
}
