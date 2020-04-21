using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_ahrechka_Bethanys.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
