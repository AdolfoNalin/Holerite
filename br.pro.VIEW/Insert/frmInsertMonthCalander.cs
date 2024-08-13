using Holerite.Helpers;
using Org.BouncyCastle.Pqc.Crypto.Crystals.Dilithium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmInsertMonthCalander : Form
    {
        public frmInsertMonthCalander()
        {
            InitializeComponent();
        }

        #region btnGenerate_click
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if(mcControlDay.SelectionStart.Day + 2  <= mcControlDay.SelectionEnd.Day)
            {
                DialogResult resp = MessageBox.Show("Os dias foram selecionatos com sucesso!. Deseja fechar está tela?", "ateção", MessageBoxButtons.YesNo);

                if (resp == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
            else
            {
                Dialog.Message("Certifique-se que há mais de 3 dias selecionado para a folha de ponto ser válida!", "atenção");
            }
        }
        #endregion
    }
}