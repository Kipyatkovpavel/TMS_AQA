using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_OOP.ThirdTask.TransportPark
{
    public class Tram : Transport
    {
        public Tram() 
        {

        }

        public Tram(string endpoint, int number, DateTime dateTime, int quantityplace)
        {
            this.endpoint = endpoint;
            this.number = number;
            this.dateTime = dateTime;
            this.quantityplace = quantityplace;
        }

        public override string? GetTransportType()
        {
            return "Rail - Tram";
        }
    }
}
