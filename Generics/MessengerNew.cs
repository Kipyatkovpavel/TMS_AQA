using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MessengerNew<T> where T : new()
    {
        private T message;

        public MessengerNew()
        {
            //Создаём новый экземпляр типа Т с использованием конструктора без параметров
            message = new T();
        }
        public void SendMesseng(T message)
        {
            Console.WriteLine($"Отправляется сообщение: {message.ToString()}");
        }
    }
}
