using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork_OOP.ThirdTask.TransportPark
{
    public class Bus : Transport
    {
        public Bus()
        { 
        
        }    

        public Bus(string endpoint, int number, DateTime dateTime, int quantityplace)
        {
            this.endpoint = endpoint;
            this.number = number;
            this.dateTime = dateTime;
            this.quantityplace = quantityplace;
        }

        public override string? GetTransportType()
        {
            return "Road - Bus";
        }
    }
}
