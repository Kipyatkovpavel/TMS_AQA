using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

﻿namespace Event;

public class CalculateHelper
{
    public int CalcDiscount(ClientType clientType)
    {
        if (clientType == ClientType.Corporate) return 10;

        return 20;
    }
}
