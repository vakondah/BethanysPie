// CSC237
// Aliaksandra Hrechka
// 02/03/2020
using CSC237_ahrechka_Bethanys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC237_ahrechka_Bethanys.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
        
    }
}
