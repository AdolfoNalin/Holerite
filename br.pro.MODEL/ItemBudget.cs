using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.MODEL
{
    public class ItemBudget
    {
        public int Cod { get; set; }
        public int CodBudget { get; set; }
        public int CodSeverce { get; set; }
        public float Price { get; set; }
        public int Amount { get; set; }
        public float Subtotal { get; set; }
    }
}
