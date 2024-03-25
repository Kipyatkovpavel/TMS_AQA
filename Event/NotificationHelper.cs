using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event;

public class NotificationHelper
{
    public void NotifyByEmail(string email)
    {
        Console.WriteLine($"Notfication was send with message {email}");
    }
}