using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.MODEL
{
    public class Epi
    {
        public int Cod { get; set; }
        public int CodEmp { get; set; }
        public DateTime Date { get; set; }
        public string Payment { get; set; }
        public float Subtotal { get; set; }
        public string Obs { get; set; }
    }
}
