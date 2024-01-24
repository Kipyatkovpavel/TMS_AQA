namespace Classes.Models
{
    public class Phone
    {
        public long number;
        public string model;
        public float weight;
        public string name;

        public Phone()
        {

        }

        public Phone(long number, string modelt)
        {
            this.number = number;
            this.model = model;
        }

        public Phone(long number, string model, float weight)
        {
            this.number = number;
            this.model = model;
            this.weight = weight;
        }
        public void receiveCall(string name)
        {
            Console.WriteLine($"Звонит {name}");
        }
        public long getNumber()
        {
            return number;
        }
        public void sendMessage(params long[] phonenumbers)
        {
            foreach (long p in phonenumbers)
            {
                Console.WriteLine(p);
            }
        }
    }
}
