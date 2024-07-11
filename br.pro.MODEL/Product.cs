using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.MODEL
{
    public class Product : Severce
    {
        public int CodSupplier { get; set; }
        public int Amount { get; set; }
        public string CA { get; set; }
        public string Obs { get; set; }
    }
}
