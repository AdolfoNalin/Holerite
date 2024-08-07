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

        #region MessageError
        /// <summary>
        /// Mensagem de erro para Catch
        /// </summary>
        /// <param name="ex"></param>
        public static void MessageError(Exception ex)
        {
            MessageBox.Show($"Acontenceu um erro do tipo {ex.Message} com caminho para {ex.StackTrace}", "ATENÇÃO", MessageBoxButtons.OK);
        }
        #endregion

        #region MessageInsert
        /// <summary>
        /// Mensagem de sucesso de cadastro
        /// </summary>
        /// <param name="objects"></param>
        public static void MessageInsert(string objects, string title = "sucesso")
        {
            MessageBox.Show($"O {objects} foi cadastrado com sucesso", title.ToUpper(), MessageBoxButtons.OK);
        }
        #endregion

        #region MessageInsertOthers
        public static DialogResult MessageInsertOthers(string objects, string title = "atenção")
        {
            DialogResult resp = MessageBox.Show($"Deseja cadastrar outro {objects}?", title.ToUpper(), MessageBoxButtons.YesNo);
            return resp;
        }
        #endregion
    }
}
