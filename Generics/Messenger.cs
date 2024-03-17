using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Messenger<T> where T : Message
    {
        public void SendMessenger(T message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.Text}");
        }
    }
}
