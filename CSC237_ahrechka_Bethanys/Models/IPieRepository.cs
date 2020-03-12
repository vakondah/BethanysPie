// CSC237
// Aliaksandra Hrechka
// 02/03/2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_ahrechka_Bethanys.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek{ get; }
        Pie GetPieById(int pieId);
    }
}
