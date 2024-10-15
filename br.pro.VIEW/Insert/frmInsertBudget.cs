using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
using Holerite.Helpers;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmInsertBudget : Form
    {
        DataTable dt = new DataTable();
        private float subtotalBudget;
        public frmInsertBudget()
        {
            InitializeComponent();
        }

        #region Load
        private void frmInsertBudget_Load(object sender, EventArgs e)
        {
            mtbDate.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        #region btnAdd_click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            subtotalBudget = txtSubtotal.Text == String.Empty ?  0 : float.Parse(txtSubtotal.Text);
            if (rbSpot.Checked == false && rbTerm.Checked == false)
            {
                Dialog.Message("Por favor selecione a forma de pagamento!", "atenção");
            }
            else if (txtAmount.Text == String.Empty)
            {
                Dialog.Message("Por favor, digite a quantidade!", "atenção");
            }
            else if(rbSpot.Checked)
            {
                Severce ser = new Severce();
                ser.Cod = int.Parse(txtCodService.Text);
                ser.ShortDescription = txtService.Text;
                ser.SpotPrice = float.Parse(txtSpot.Text);
                int amount = int.Parse(txtAmount.Text);
                float subtotal = Verification.ToCheck(float.Parse(txtSpot.Text), txtUM.Text, int.Parse(txtAmount.Text));
                float price = ser.SpotPrice;
                float total = 0;


                if (txtCodBudget.Text == String.Empty)
                {
                    if (dgBudget.Rows.Count == 0)
                    {
                        dt.Columns.Add("Código");
                        dt.Columns.Add("Descrição Resumida");
                        dt.Columns.Add("Preço");
                        dt.Columns.Add("Quantidade");
                        dt.Columns.Add("Subtotal");
                    }

                    dt.Rows.Add(ser.Cod, ser.ShortDescription, price, amount, subtotal);
                    subtotalBudget += subtotal;
                    dgBudget.DataSource = dt;
                }
                else if (txtCodBudget.Text != String.Empty)
                {
                    dt = (DataTable)dgBudget.DataSource;
                    DataRow novaLinha = dt.NewRow();
                    novaLinha["Código"] = ser.Cod;
                    novaLinha["Descrição Resumida"] = txtService.Text;
                    novaLinha["Preço"] = ser.SpotPrice;
                    novaLinha["Quantidade"] = txtAmount.Text;
                    novaLinha["SubTotal"] = subtotal;
                    dt.Rows.Add(novaLinha);

                    subtotalBudget += float.Parse(novaLinha["SubTotal"].ToString());
                    total = subtotalBudget;
                }
                txtAmount.Clear();
            }
            else if(rbTerm.Checked)
            {
                Severce ser = new Severce();
                ser.Cod = int.Parse(txtCodService.Text);
                ser.ShortDescription = txtService.Text;
                ser.TermPrice = float.Parse(txtTerm.Text);
                int amount = int.Parse(txtAmount.Text);
                float subtotal = Verification.ToCheck(ser.TermPrice, txtUM.Text, int.Parse(txtAmount.Text));
                float price = ser.TermPrice;
                float total = 0;

                if (txtCodBudget.Text == String.Empty)
                {
                    if (dgBudget.Rows.Count == 0)
                    {
                        dt.Columns.Add("Código");
                        dt.Columns.Add("Descrição Resumida");
                        dt.Columns.Add("Preço");
                        dt.Columns.Add("Quantidade");
                        dt.Columns.Add("Subtotal");
                    }

                    dt.Rows.Add(ser.Cod, ser.ShortDescription, price, amount, subtotal);
                    subtotalBudget += subtotal;
                    dgBudget.DataSource = dt;
                }
                else if (txtCodBudget.Text != String.Empty)
                {
                    dt = (DataTable)dgBudget.DataSource;
                    DataRow novaLinha = dt.NewRow();
                    novaLinha["Código"] = ser.Cod;
                    novaLinha["Descrição Resumida"] = txtService.Text;
                    novaLinha["Preço"] = ser.TermPrice;
                    novaLinha["Quantidade"] = txtAmount.Text;
                    novaLinha["SubTotal"] = subtotal;
                    dt.Rows.Add(novaLinha);

                    subtotalBudget += float.Parse(novaLinha["SubTotal"].ToString());
                    total = subtotalBudget;
                }
                txtAmount.Clear();
            }

            txtSubtotal.Text = subtotalBudget.ToString();
            txtTotal.Text = subtotalBudget.ToString();
        }
        #endregion

        #region btnSearch
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmConsultarClient tela = new frmConsultarClient();
            tela.ShowDialog();
        }
        #endregion

        #region btnExit_click
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmConsultBudget tela = new frmConsultBudget();
            this.Hide();
            tela.ShowDialog();
        }
        #endregion

        #region btnInsert_click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string payment = rbSpot.Checked ? "Vista" : "Prazo";

            Employee emp = new EmployeeDAO().GetSearch(txtEmployee.Text);
            DataTable client = new ClientDAO().Search(txtClient.Text);

            Budget bud = new Budget()
            {
                CodEmp = int.Parse(emp.Cod.ToString()),
                CodClient = int.Parse(client.Columns["Código"].ToString()),
                Payment = payment,
                Subtotal = float.Parse(txtSubtotal.Text),
                Total = float.Parse(txtTotal.Text),
                Observation = txtObs.Text,
                Date = DateTime.Parse(mtbDate.Text)
            };

            PrintOut.ToRecord(dgBudget, bud);

            DialogResult resp = Dialog.MessageInsertOthers("Orçamento");

            if (resp == DialogResult.Yes)
            {
                Verification.Clean(this);
                //dgBudget.Rows.Clear(); 
            }
            else
            {
                this.Hide();
                frmConsultBudget tela = new frmConsultBudget();
                tela.ShowDialog();
            }
        }
        #endregion

        #region rbSpot_CheckedChanged
        private void rbSpot_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbSpot.Checked && dgBudget.Rows.Count > 0)
                {
                    try
                    {
                        ServiceDAO dao = new ServiceDAO();

                        float subtotal = 0;
                        float total = 0;

                        foreach (DataGridViewRow linha in dgBudget.Rows)
                        {
                            Severce ser = new Severce();
                            ser.Cod = int.Parse(linha.Cells[0].Value.ToString());
                            ser = dao.Search(ser.Cod);

                            int quantidade = int.Parse(linha.Cells[3].Value.ToString());
                            linha.Cells[2].Value = ser.SpotPrice.ToString();
                            linha.Cells[4].Value = quantidade * ser.SpotPrice;
                            subtotal += float.Parse(linha.Cells[4].Value.ToString());
                        }

                        total = subtotal;

                        txtTotal.Text = total.ToString();
                        txtSubtotal.Text = total.ToString();
                        subtotal = 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Conteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                    }
                }
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro {ex.Message} com caminho para {ex.StackTrace}", "atenção");
            }
        }
        #endregion

        #region rbTerm_CheckedChanged
        private void rbTerm_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTerm.Checked && dgBudget.Rows.Count > 0)
            {
                try
                {

                    ServiceDAO dao = new ServiceDAO();

                    float subtotal = 0;
                    float total = 0;

                    foreach (DataGridViewRow linha in dgBudget.Rows)
                    {
                        Severce ser = new Severce();
                        ser.Cod = int.Parse(linha.Cells[0].Value.ToString());
                        ser = dao.Search(ser.Cod);

                        int quantidade = int.Parse(linha.Cells[3].Value.ToString());

                        linha.Cells[2].Value = ser.TermPrice.ToString();
                        linha.Cells[4].Value = quantidade * ser.TermPrice;
                        subtotal += float.Parse(linha.Cells[4].Value.ToString());
                    }

                    total = subtotal;

                    txtTotal.Text = total.ToString();
                    txtSubtotal.Text = total.ToString();
                    subtotal = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Conteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                }
            }
        }
        #endregion

        #region btnRemove_click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            subtotalBudget = txtSubtotal.Text == String.Empty ? 0 : float.Parse(txtSubtotal.Text);
            float total = subtotalBudget;
                
            try
            {
                if (dgBudget.Rows.Count == 0)
                {
                    Dialog.Message("Impossivel remover um elemento que não existe!", "atenção");
                }
                else
                {
                    float subProduto = float.Parse(dgBudget.CurrentRow.Cells[4].Value.ToString());
                    int indici = dgBudget.CurrentRow.Index;
                    total -= subProduto;

                    dgBudget.Rows.RemoveAt(indici);

                    if (dgBudget.DataSource != null)
                    {
                        txtSubtotal.Text = total.ToString();
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        total = 0;
                        txtTotal.Text = total.ToString();
                        txtSubtotal.Text = total.ToString();
                    }
                }
                
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
        }
        #endregion

        #region btnDelete_click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtCodBudget.Text == String.Empty)
            {
                Dialog.Message($"Não é possivel deletar um orçamento que não foi cadastrado!", "atenção");
            }
            else
            {
                int cod = int.Parse(txtCodBudget.Text);
                BudgetDAO bud = new BudgetDAO();
                ItemBudgetDAO item = new ItemBudgetDAO();
                bud.Delete(cod);

                this.Hide();
                frmConsultBudget tela = new frmConsultBudget();
                tela.ShowDialog();
            }
        }
        #endregion

        #region btnPrintOut_Click
        private void btnPrintOut_Click(object sender, EventArgs e)
        {
            string res = "";
            if (rbSpot.Checked)
            {
                res = "Vista";
            }
            else if(rbTerm.Checked)
            {
                res = "Prazo";
            }

            Employee emp = new EmployeeDAO().GetSearch(txtEmployee.Text);
            DataTable client = new ClientDAO().Search(txtClient.Text);

            Budget obj = new Budget()
            {
                CodEmp = int.Parse(emp.Cod.ToString()),
                CodClient = int.Parse(client.Columns["Código"].ToString()),
                Payment = res,
                Subtotal = float.Parse(txtSubtotal.Text),
                Total = float.Parse(txtTotal.Text),
                Observation = txtObs.Text,
                Date = DateTime.Parse(mtbDate.Text)
            };

            new BudgetDAO().Insert(obj);
            
            PrintOut.PrintOutBudget(dgBudget,txtClient.Text,DateTime.Parse(mtbDate.Text), txtObs.Text);

            PrintOut.ToRecord(dgBudget, obj);

            DialogResult resp = MessageBox.Show("Deseja Imprimir outro orçamento?", "Sucesso", MessageBoxButtons.YesNo);
            if(resp == DialogResult.Yes)
            {
                Verification.Clean(this);
                dgBudget.Rows.Clear();
            }
            else
            {
                this.Hide();
                frmConsultBudget tela = new frmConsultBudget();
                tela.ShowDialog();
            }
        }
        #endregion

        #region bntClean_click
        private void btnClean_Click(object sender, EventArgs e)
        {
            Verification.Clean(this);
        }
        #endregion

        #region btnConsultEmployee_click
        private void btnConsultEmployee_Click(object sender, EventArgs e)
        {
            frmConsultEmployee screen = new frmConsultEmployee();
            screen.ShowDialog();

            string nameEmployee = screen.dgEmployee.CurrentRow.Cells[2].Value.ToString();

            txtEmployee.Text = nameEmployee;
        }
        #endregion

        #region btnConsultClient_Click
        private void btnConsultClient_Click(object sender, EventArgs e)
        {
            frmConsultarClient screen = new frmConsultarClient();
            screen.ShowDialog();

            string nameClient = screen.dgClient.CurrentRow.Cells[1].Value.ToString();
            txtClient.Text = nameClient;
            screen.Close();
        }
        #endregion

        #region btnConsultService_Click
        private void btnConsultService_Click(object sender, EventArgs e)
        {
            frmConsultService screen = new frmConsultService();
            screen.ShowDialog();
            DataGridView dt = screen.dgSeverce;
            txtCodService.Text = dt.CurrentRow.Cells[0].Value.ToString();
            txtService.Text = dt.CurrentRow.Cells[2].Value.ToString();
            txtUM.Text = dt.CurrentRow.Cells[4].Value.ToString();
            txtSpot.Text = dt.CurrentRow.Cells[5].Value.ToString();
            txtTerm.Text = dt.CurrentRow.Cells[6].Value.ToString();
            txtAmount.Focus();
            screen.Close();
        }
        #endregion
    }
}