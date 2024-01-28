namespace Abstraction
{
    public class Corporate : Client //класс Corporate (дочерний) наследуется от Client (родитель)
    {
        public string INN;
        public string UNP;

        public Corporate(int id) : base(id)
        {

        }
    }
}
