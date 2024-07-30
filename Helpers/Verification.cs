using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.Helpers
{
    public class Verification
    {
        #region
        public void ToCheck()
        {
            
        }
        #endregion

        #region
        public void Tocheck(Employee obj)
        {

        }
        #endregion

        #region
        public void Tocheck(Client obj)
        {

        }
        #endregion

        #region Varification User and password
        /// <summary>
        /// Verification function if o user_name is user
        /// </summary>
        /// <param name="userName">Name of user</param>
        /// <param name="password">Name of Password</param>
        public static void Login(string userName, string password)
        {
            EmployeeDAO dao = new EmployeeDAO();
            try
            {
                if (dao.Login(userName, password))
                {
                    frmMenu tela = new frmMenu();
                    tela.ShowDialog();
                }
                else
                {
                    Dialog.Message("Usuário não encontrado, tente novamente", "atenção");
                    frmLogin tela = new frmLogin();
                    tela.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caominho para {ex.StackTrace}", "Atenção");
            }
        }
        #endregion
    }
}
