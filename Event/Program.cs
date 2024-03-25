// See https://aka.ms/new-console-template for more information
using Event;

class Program
{
    public delegate void Handler(string alpha, string beta);

    //public static event Handler Onstuck;
    public static Handler Onstuck;
    static void Main()
    {
        /*        Onstuck += ShowMessage;
                Onstuck("Alex", "Trostyanko");*/

        ClientDelegateProgram clientDelegateProgram = new ClientDelegateProgram();
        clientDelegateProgram.Run();

        ClientEventProgram clientEventProgram = new ClientEventProgram();
        clientEventProgram.Run();
    }
    private static void ShowMessage(string firstname, string lastname)
    {
        Console.WriteLine($"{firstname} {lastname} Have fun!!!");
    }
}