namespace SaleConferenze
{
    internal class UI : ConferenceRoomsHandler
    {
        public UI() : base() { }
        public void AddConferenceRoom()
        {
            int id;
            Console.WriteLine("ID:");
            if (int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Il valore inserito è invalido");
                return;
            }
            Console.WriteLine("Nome:");
            string? nome = Console.ReadLine();
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Il valore inserito è invalido");
                return;
            }
            int sedie;
            Console.WriteLine("Sedie:");
            if (int.TryParse(Console.ReadLine(), out sedie))
            {
                Console.WriteLine("Il valore inserito è invalido");
                return;
            }
            Province province = InputProvince();
            Console.WriteLine("Quante volte è stata usata?");
            if (int.TryParse(Console.ReadLine(), out sedie))
            {
                Console.WriteLine("Il valore inserito è invalido");
                return;
            }
            Console.WriteLine("Il proiettore è presente? Y/N");
            char proiettore = Console.ReadLine().ToUpper()[0];
            
            //Non ho voglia di chiedere in input la data
            base.AddConferenceRoom(new ConferenceRoom(id, nome, sedie, province, sedie,proiettore.Equals("Y"),new DateTime()));
        }
        public void ShowAllFromProvince()
        {
            try
            {
                Province e_provincia = InputProvince();
                base.VisualizeData((cr) => cr.Province.Equals(e_provincia)).ForEach(Console.WriteLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Excep
        }
        public void DisplayRoomsByUsage()
        {
            List<ConferenceRoom> rooms = base.ConferenceRooms.ToList(); //Copia la lista ma rendendola indipendente dall'altra
            rooms.Sort((cr1, cr2) => -cr1.NTimesUsed.CompareTo(cr2.NTimesUsed));
            Console.WriteLine(String.Join("\n----------------\n", rooms));
        }
        public void ShowConferenceRoomsByMinSeats()
        {
            Console.WriteLine("Valore minimo:");
            int valoreMinimo;
            if (int.TryParse(Console.ReadLine(), out valoreMinimo))
            {
                Console.WriteLine("Il valore inserito è invalido");
                return;
            }
            base.VisualizeData(cr => cr.Seats >= valoreMinimo).ForEach(Console.WriteLine);
        }
        public void ShowConferenceRoomsWithProjectorInProvince()
        {
            try
            {
                Province e_provincia = InputProvince();
                base.VisualizeData(cr => cr.HasProjector && cr.Province.Equals(e_provincia)).ForEach(Console.WriteLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void FilterConferenceRoomsWithProjector()
        {
            base.RemoveRooms(cr => cr.HasProjector);
            base.ConferenceRooms.ForEach(Console.WriteLine);
        }
        public void ShowConferenceRoomsByLastUsageTime()
        {
            List<ConferenceRoom> rooms = base.ConferenceRooms.ToList(); //Copia la lista ma rendendola indipendente dall'altra
            rooms.Sort((cr1, cr2) => cr1.LastUsed.CompareTo(cr2.LastUsed));
            rooms.ForEach(Console.WriteLine);
        }
        private Province InputProvince()
        {
            Console.WriteLine("Provincia da Ricercare:\n");
            string? provincia_s = Console.ReadLine();
            if (provincia_s == null)
                throw new Exception("Provincia da Ricercare non inserita");
            provincia_s = provincia_s[0].ToString().ToUpper() + provincia_s.Substring(1);
            Province e_provincia;
            if (!Enum.TryParse(provincia_s, out e_provincia))
                throw new Exception("Provincia da ricercare non esistente");
            return e_provincia;
        }
    }
}
