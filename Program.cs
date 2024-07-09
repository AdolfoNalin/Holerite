using Holerite.br.pro.VIEW;
using Holerite.br.pro.VIEW.Consult;
using Holerite.br.pro.VIEW.Insert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConsultComapany());
        }
    }
}
