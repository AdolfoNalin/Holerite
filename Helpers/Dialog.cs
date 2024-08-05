using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.Helpers
{
    public class Dialog
    {
        #region Message
        /// <summary>
        /// MessageBox simples
        /// </summary>
        /// <param name="message">Mensagem que vai ser mostrada</param>
        /// <param name="title">Titulo da Mensagem</param>
        public static void Message(string message, string title)
        {
            MessageBox.Show(message, title.ToUpper(), MessageBoxButtons.OK);
        }
        #endregion
    }
}
