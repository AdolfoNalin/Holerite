using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
using Holerite.Helpers;
using System;
using System.Data;
using System.Net.Http.Formatting;
using System.Windows.Forms;

namespace Holerite.br.pro.VIEW.Insert
{
    public partial class frmInsertEPI : Form
    {
        public frmInsertEPI()
        {
            InitializeComponent();
        }

        DataTable dt = new DataTable();
        private float subtotalEPIs = 0;

        #region Load
        private void frmInsertEPI_Load(object sender, EventArgs e)
        {
            mtbDate.Text = DateTime.Now.ToShortDateString();
            ProductDAO daoP = new ProductDAO();
            EmployeeDAO daoE = new EmployeeDAO();

            if(txtCodEpi.Text == String.Empty)
            {
                cbProduct.DataSource = daoP.Consult();
                cbEmployee.DataSource = daoE.Consult();
            }

            cbProduct.DisplayMember = "Descrição Resumida";
            cbProduct.ValueMember = "Código";

            cbEmployee.DisplayMember = "Nome";
            cbEmployee.ValueMember = "Código";
        }
        #endregion

        #region cbProduct_KeyPress
        private void cbServece_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Product obj = new Product();
                obj = new ProductDAO().GetSearch(cbProduct.Text);

                txtCodProduct.Text = obj.Cod.ToString();
                cbProduct.Text = obj.ShortDescription.ToString();
                txtSpot.Text = obj.SpotPrice.ToString();
                txtTerm.Text = obj.TermPrice.ToString();
            }
        }
        #endregion

        #region rbSpot_CheckedChanged
        private void rbSpot_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbSpot.Checked && dgEPI.Rows.Count > 0)
                {
                    try
                    {
                        ProductDAO dao = new ProductDAO();

                        float subtotal = 0;
                        float total = 0;

                        foreach (DataGridViewRow linha in dgEPI.Rows)
                        {
                            Product pro = new Product();
                            pro.Cod = int.Parse(linha.Cells[0].Value.ToString());
                            pro = dao.Search(pro.Cod);

                            int quantidade = int.Parse(linha.Cells[3].Value.ToString());
                            linha.Cells[2].Value = pro.SpotPrice.ToString();
                            linha.Cells[4].Value = quantidade * pro.SpotPrice;
                            subtotal += float.Parse(linha.Cells[4].Value.ToString());
                        }

                        total = subtotal;

                        txtTotal.Text = total.ToString();
                       
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
            if (rbTerm.Checked && dgEPI.Rows.Count > 0)
            {
                try
                {
                    ProductDAO dao = new ProductDAO();

                    float subtotal = 0;
                    float total = 0;

                    foreach (DataGridViewRow linha in dgEPI.Rows)
                    {
                        Product pro = new Product();
                        pro.Cod = int.Parse(linha.Cells[0].Value.ToString());
                        pro = dao.Search(pro.Cod);

                        int quantidade = int.Parse(linha.Cells[3].Value.ToString());

                        linha.Cells[2].Value = pro.TermPrice.ToString();
                        linha.Cells[4].Value = quantidade * pro.TermPrice;
                        subtotal += float.Parse(linha.Cells[4].Value.ToString());
                    }

                    total = subtotal;

                    txtTotal.Text = total.ToString();
               
                    subtotal = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Conteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}");
                }
            }
        }
        #endregion

        #region btnAdd_click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            subtotalEPIs = txtTotal.Text == String.Empty ? 0 : float.Parse(txtTotal.Text);
            if (rbSpot.Checked == false && rbTerm.Checked == false)
            {
                Dialog.Message("Por favor selecione a forma de pagamento!", "atenção");
            }
            else if (txtAmount.Text == String.Empty)
            {
                Dialog.Message("Por favor, digite a quantidade!", "atenção");
            }
            else if (rbSpot.Checked)
            {
                Product obj = new Product();
                obj.Cod = int.Parse(txtCodProduct.Text);
                obj.ShortDescription = cbProduct.Text;
                obj.SpotPrice = float.Parse(txtSpot.Text);
                int amount = int.Parse(txtAmount.Text);
                float subtotal = float.Parse(txtSpot.Text) * float.Parse(txtAmount.Text);
                float price = obj.SpotPrice;
                float total = 0;


                if (txtCodEpi.Text == String.Empty)
                {
                    if (dgEPI.Columns.Count == 0)
                    {
                        dt.Columns.Add("Código");
                        dt.Columns.Add("Descrição Resumida");
                        dt.Columns.Add("Preço");
                        dt.Columns.Add("Quantidade");
                        dt.Columns.Add("Subtotal");
                    }

                    dt.Rows.Add(obj.Cod, obj.ShortDescription, price, amount, subtotal);
                    subtotalEPIs += subtotal;
                    dgEPI.DataSource = dt;
                }
                else if (txtCodEpi.Text != String.Empty)
                {
                    dt = (DataTable)dgEPI.DataSource;
                    DataRow novaLinha = dt.NewRow();
                    novaLinha["Código"] = obj.Cod;
                    novaLinha["Descrição Resumida"] = cbProduct.Text;
                    novaLinha["Preço"] = obj.SpotPrice;
                    novaLinha["Quantidade"] = txtAmount.Text;
                    novaLinha["SubTotal"] = subtotal;
                    dt.Rows.Add(novaLinha);

                    subtotalEPIs+= float.Parse(novaLinha["SubTotal"].ToString());
                    total = subtotalEPIs;
                }
                txtAmount.Clear();
            }
            else if (rbTerm.Checked)
            {
                Product obj = new Product();
                obj.Cod = int.Parse(txtCodProduct.Text);
                obj.ShortDescription = cbProduct.Text;
                obj.TermPrice = float.Parse(txtTerm.Text);
                int amount = int.Parse(txtAmount.Text);
                float subtotal = obj.TermPrice *  float.Parse(txtAmount.Text);
                float price = obj.TermPrice;
                float total = 0;

                if (txtCodEpi.Text == String.Empty)
                {
                    if (dgEPI.Columns.Count == 0)
                    {
                        dt.Columns.Add("Código");
                        dt.Columns.Add("Descrição Resumida");
                        dt.Columns.Add("Preço");
                        dt.Columns.Add("Quantidade");
                        dt.Columns.Add("Subtotal");
                    }

                    dt.Rows.Add(obj.Cod, obj.ShortDescription, price, amount, subtotal);
                    subtotalEPIs += subtotal;
                    dgEPI.DataSource = dt;
                }
                else if (txtCodEpi.Text != String.Empty)
                {
                    dt = (DataTable)dgEPI.DataSource;
                    DataRow novaLinha = dt.NewRow();
                    novaLinha["Código"] = obj.Cod;
                    novaLinha["Descrição Resumida"] = cbProduct.Text;
                    novaLinha["Preço"] = obj.TermPrice;
                    novaLinha["Quantidade"] = txtAmount.Text;
                    novaLinha["SubTotal"] = subtotal;
                    dt.Rows.Add(novaLinha);

                    subtotalEPIs += float.Parse(novaLinha["SubTotal"].ToString());
                    total = subtotalEPIs;
                }
                txtAmount.Clear();
            }

            txtTotal.Text = subtotalEPIs.ToString();
        }
        #endregion

        #region cbEmployee_KeyPress
        private void cbEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Employee obj = new Employee();
                obj = new EmployeeDAO().GetSearchEmp(cbEmployee.Text);

                txtCodEmp.Text = obj.Cod.ToString();
                cbEmployee.Text = obj.Name;
            }
        }
        #endregion

        #region btnRemove_Click
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                subtotalEPIs = txtTotal.Text == String.Empty ? 0 : float.Parse(txtTotal.Text);
                float total = subtotalEPIs;

                if (dgEPI.Rows.Count == 0)
                {
                    Dialog.Message("Impossivel remover um elemento que não existe!", "atenção");
                }
                else
                {
                    float subProduto = float.Parse(dgEPI.CurrentRow.Cells[4].Value.ToString());
                    int indici = dgEPI.CurrentRow.Index;
                    total -= subProduto;

                    dgEPI.Rows.RemoveAt(indici);

                    if (dgEPI.DataSource != null)
                    {
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        total = 0;
                        txtTotal.Text = total.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion

        #region btnClose_click
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region btnSalve_click
        private void btnSalve_Click(object sender, EventArgs e)
        {
            Epi obj = new Epi()
            {
                CodEmp = int.Parse(cbEmployee.SelectedValue.ToString()),
                Date = DateTime.Parse(mtbDate.Text),
                Subtotal = float.Parse(dgEPI.CurrentRow.Cells[4].Value.ToString()),
                Obs = txtObs.Text,
            };

            EpiDAO dao = new EpiDAO();
            dao.Insert(obj);

            foreach (DataGridViewRow item in dgEPI.Rows)
            {
                ItemEpi epi = new ItemEpi()
                {
                    CodEpi = new EpiDAO().EndCod(),
                    CodProd = int.Parse(item.Cells["Código"].Value.ToString()),
                    Price = float.Parse(item.Cells["Preço"].Value.ToString()),
                    Amount = int.Parse(item.Cells["Quantidade"].Value.ToString()),
                    Subtotal = float.Parse(item.Cells["Subtotal"].Value.ToString())
                };
                new ItemEpiDAO().Insert(epi);
            }

            DialogResult resp = Dialog.MessageInsertOthers("Epi");

            if (resp == DialogResult.Yes)
            {
                Verification.Clean(this);
            }
            else
            {
                this.Hide();
            }
        }
        #endregion

        #region btnDelete_click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txtCodEpi.Text);
            if (cod > 0)
            {
                new EpiDAO().Delete(cod);
            }
            else
            {
                Dialog.MessageError(new ArgumentException("Por favor, o elemento código tem que ser um número"));
            }
        }
        #endregion

        #region btnPrintOut_Click
        private void btnPrintOut_Click(object sender, EventArgs e)
        {
            EmployeeDAO empD = new EmployeeDAO();
            Employee emp = empD.GetSearchEmp(cbEmployee.Text);
            string payment = rbSpot.Checked == true ? "vista" : "prazo";
            int codEpi = txtCodEpi.Text == String.Empty ? 0 : int.Parse(txtCodEpi.Text);
            int codEmp = txtCodEmp.Text != String.Empty ? 0 : emp.Cod;

            Epi obj = new Epi()
            {
                CodEmp = codEmp,
                Payment = payment,
                Date = DateTime.Parse(mtbDate.Text),
                Subtotal = float.Parse(txtTotal.Text),
                Obs = txtObs.Text,
            };

            if(codEpi == 0)
            {
                EpiDAO dao = new EpiDAO();
                dao.Insert(obj);
            }
           
            PrintOut.PrintOutEpi(codEmp, codEpi,dgEPI);

            DialogResult resp = MessageBox.Show("Deseja imprimir outro EPI", "ATENÇÃO", MessageBoxButtons.YesNo);

            if (resp == DialogResult.Yes)
            {
                this.Hide();
                frmConsultEpi tela = new frmConsultEpi();
                tela.ShowDialog();
            }
            else
            {
                this.Hide();
            }

        }
        #endregion
    }
}
