using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if ((String.IsNullOrWhiteSpace(userName) || String.IsNullOrWhiteSpace(password)) ||
                    (String.IsNullOrWhiteSpace(userName) && String.IsNullOrWhiteSpace(password)))
                {
                    Dialog.Message("Os campos Nome e Senha não podem ser vazios", "Erro");
                }
                else if(dao.Login(userName, password) == false) 
                {
                    Dialog.Message("Usuário não encontrado, tente novamente", "atenção");
                }
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caominho para {ex.StackTrace}", "Atenção");
            }
        }
        #endregion

        #region Verification CPF
        /// <summary>
        /// Consult employee in databese for CPF
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static Employee ToCheck(string cpf)
        {
            EmployeeDAO dao = new EmployeeDAO();
            Employee obj = dao.GetSearch(cpf);

            return obj;
        }
        #endregion

        #region ToCheck
        /// <summary>
        /// Virifica e faz o calculo do subtotal
        /// </summary>
        /// <param name="price"></param>
        /// <param name="um"></param>
        /// <returns></returns>
        public static float ToCheck(float price, string um, int amount)
        {
            float subtotal = 0;

            switch (um.ToUpper())
            {
                case "M3":
                    subtotal = price * amount;
                    break;
                case "M2":
                    subtotal = price * amount;
                    break;
                default:
                    Dialog.Message("Unidade de Medida não foi cadastrada", "atemçao");
                    break;
            }

            return subtotal;
        }
        #endregion

        #region Clean the Screen
        /// <summary>
        /// Limpa os campos txt, cb, mtb e uma tela
        /// </summary>
        /// <param name="tela"></param>
        public static void Clean(Form tela)
        {
            foreach (Control ctrPai in tela.Controls)
            {
                foreach (Control ctr1 in ctrPai.Controls)
                {
                    if (ctr1 is TabPage)
                    {
                        foreach (Control ctr2 in ctr1.Controls)
                        {
                            if (ctr2 is TextBox)
                            {
                                (ctr2 as TextBox).Text = String.Empty;
                            }
                            else if (ctr2 is MaskedTextBox)
                            {
                                (ctr2 as MaskedTextBox).Text = String.Empty;
                            }
                            else if (ctr2 is ComboBox)
                            {
                                (ctr2 as ComboBox).Text = String.Empty;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region VelidatePermissionUser
        public static List<String> VelidatePermissionUser(string name)
        {
            EmployeeDAO dao = new EmployeeDAO();
            try
            {
                Employee emp = dao.GetSearchEmp(name);

                List<String> list = emp.Permissions.Split(',').ToList();

                return list;
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
                return null;
            }
        }
        #endregion

        #region ValidatePermission
        public static void ValidadePermission(List<string> permissions, string permission, Form screen)
        {
            try
            {
                if (permissions.Any(p => p == permission))
                {
                    screen.ShowDialog();
                }
                else
                {
                    Dialog.Message("Usuário não autorizado para acessar essa tela!", "Não autorizado");
                }

            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion
    }
}
