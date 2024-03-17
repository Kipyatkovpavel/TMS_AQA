using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MessengerClass<T> where T : class
    {
        public void SendMesseng(T message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.ToString()}");
        }
    }
}
