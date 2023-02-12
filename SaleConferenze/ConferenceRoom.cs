namespace SaleConferenze
{
    internal class ConferenceRoom
    {
        private int _seats;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Seats {
            get { return _seats; }
            private set {
                if (value >= 20 && value <= 200) _seats = value;
                else throw new ArgumentException("Value must be between 20 and 200");
            }
        }
        public Province Province { get; private set; }
        public int nTimesUsed { get; private set; }
        public bool HasProjector { get; private set; }
        public DateTime LastUsed { get; private set; }
        public override string ToString()
        {
            return $"Room name: {Name}\n" +
                $"Room ID: {Id}\n" +
                $"Number of seats: {Seats}\n" +
                $"Province: {Province} \n" +
                $"Used {nTimesUsed} times \n" +
                ((HasProjector)?"Has projector": "Doesn't have projector") + "\n" +
                $"Last use: {LastUsed.ToShortDateString()}";

        }
    }
}
