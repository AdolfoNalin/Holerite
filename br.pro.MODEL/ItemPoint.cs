using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.MODEL
{
    public class ItemPoint
    {
        public int Cod { get; set; }
        public int CodPoint { get; set; }
        public DateTime Date { get; set; }
        public DateTime EntryTime { get; set; }
        public DateTime LunchDeparture { get; set; }
        public DateTime ExitTime { get; set; }
        public DateTime ExtraEntry { get; set; }
        public DateTime ExtraOutput { get; set; }
    }
}
