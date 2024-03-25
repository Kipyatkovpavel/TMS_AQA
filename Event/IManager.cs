using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event;

public delegate void Notification(string msg);

public interface IManager
{
    event Notification Notified;
}