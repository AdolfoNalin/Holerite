using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.MODEL
{
    public class Budget
    {
        public int Cod { get; set; }
        public int CodEmp { get; set; }
        public int CodClient { get; set; }
        public string Payment { get; set; }
        public float Subtotal { get; set; }
        public float Total { get; set; }
        public string Observation { get; set; }
        public DateTime Date { get; set; }
    }
}
