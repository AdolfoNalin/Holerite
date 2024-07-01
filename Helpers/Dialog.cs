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
        public static void Message(string message, string title)
        {
            title.ToUpper();
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }
        #endregion
    }
}
