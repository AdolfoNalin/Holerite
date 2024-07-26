using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.br.pro.MODEL
{
    public class Employee : Client
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Function { get; set; }
        public float Wage { get; set; }
        public List<string> Permissions { get; set; }
        public string CTPS { get; set; }
    }
}
