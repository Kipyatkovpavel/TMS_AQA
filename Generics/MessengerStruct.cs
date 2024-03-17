using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MessengerStruct<T> where T : struct
    {
        public void SendMesseng(T message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.ToString()}");
        }
    }
}
