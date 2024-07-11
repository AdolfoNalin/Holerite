using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.MODEL
{
    public class Overview
    {
        public int Cod { get; set; }
        public int CodPoint { get; set; }
        public DateTime TimeWork { get; set; }
        public DateTime ExtraTime { get; set; }
        public float MiissingMonth { get; set; }
        public float Subtotal { get; set; }
        public float INSS { get; set; }
        public float OthersDes { get; set; }
        public float WageFam { get; set; }
        public float tri { get; set; }
        public float VisaInspection { get; set; }
    }
}
