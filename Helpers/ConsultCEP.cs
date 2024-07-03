using Holerite.br.pro.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Holerite.Helpers
{
    public class ConsultCEP
    {
        #region ConsultAddress
        public static Address Consult(string cep)
        {
			try
			{
                string url = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet ds = new DataSet();
                ds.ReadXml(url);

                Address obj = new Address()
                {
                    Street = ds.Tables[0].Rows[0]["logradouro"].ToString(),
                    Neighborhood = ds.Tables[0].Rows[0]["bairro"].ToString(),
                    City = ds.Tables[0].Rows[0]["localidade"].ToString(),
                    Complement = ds.Tables[0].Rows[0]["complemento"].ToString(),
                    State = ds.Tables[0].Rows[0]["uf"].ToString()
                };

                return obj;
            }
			catch (Exception ex)
			{
				Dialog.Message("CEP não encontrado, por favor coloque manualmente", "atenção");
				return null;
			}
        }
        #endregion
    }
}
