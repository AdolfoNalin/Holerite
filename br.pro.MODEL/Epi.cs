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
        public DateTime Date { get; set; }
        public int CodEmp { get; set; }
        public int CodProd { get; set; }
        public int Amount { get; set; }
        public string Obs { get; set; }
    }
}
