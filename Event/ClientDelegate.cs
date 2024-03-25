using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event;

public class ClientDelegate
{
    public delegate int CalculateDiscount(ClientType clientType);

    public CalculateDiscount CalculateDiscountForClient { get; set; }

    public void CalculateDiscounts(IEnumerable<Client> clients)
    {
        foreach (Client client in clients)
        {
            client.Discount = CalculateDiscountForClient(client.Type);
        }
    }
}