using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
using Holerite.br.pro.VIEW.Insert;
using Holerite.Helpers;
using iTextSharp.text.xml.simpleparser;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using ZstdSharp;
using Point = Holerite.br.pro.MODEL.Point;

namespace Holerite.br.pro.VIEW
{
    public partial class frmInsertPoint : Form
    {
        public DateTime Data { get; private set; } = DateTime.Now;
        private int _codCompany;

        public frmInsertPoint(int codCompany)
        {
            _codCompany = codCompany;
            InitializeComponent();
        }

        #region Load
        private void frmInsertPoint_Load(object sender, EventArgs e)
        {
            mtbDate.Text = Data.ToString();
            txtCodCompany.Text = _codCompany.ToString();
        }
        #endregion

        #region SearchEmp_Click
        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            frmConsultEmpGeneratePoint screen = new frmConsultEmpGeneratePoint(2);
            this.Visible = false;
            screen.ShowDialog();
            DataGridView dg = screen.dgGeneratePoint ?? throw new NullReferenceException("Escolha o Funcionário");

            txtCodEmployee.Text = dg.CurrentRow.Cells[0].Value.ToString();
            txtNameEmployee.Text = dg.CurrentRow.Cells[2].Value.ToString();
            mtbCPF.Text = dg.CurrentRow.Cells[7].Value.ToString();
            txtFunction.Text = dg.CurrentRow.Cells[18].Value.ToString();

            Address address = new Address()
            {
                State = dg.CurrentRow.Cells[12].Value.ToString(),
                City = dg.CurrentRow.Cells[13].Value.ToString(),
                Neighborhood = dg.CurrentRow.Cells[14].Value.ToString(),
                Street = dg.CurrentRow.Cells[15].Value.ToString(),
                HomeNumber = dg.CurrentRow.Cells[16].Value.ToString(),
                Complement = dg.CurrentRow.Cells[17].Value.ToString()
            };

            txtAddress.Text = $"{address.State}, {address.City}, {address.Neighborhood}, {address.Street}, {address.HomeNumber}, {address.Complement}";

            List<string> date = screen.date;
            DateTimePicker dateTime = screen.dtpStart;

            string time = "  :  ";
            
            for (int i = 0; i < date.Count; i++)
            {
                dgPoint.Rows.Add(date[i], time, time, time, time, time, time);
            }
                
            dgPoint.Refresh();
            
            dgPoint.Rows[0].Frozen = true;
            screen.Hide();
            this.Visible = true;
        }
        #endregion

        #region btnSave_Click
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCod.Text))
                {
                    Point point = new Point()
                    {
                        CodCompany = int.Parse(txtCodCompany.Text),
                        CodEmp = int.Parse(txtCodEmployee.Text),
                        Month = Data
                    };

                    PointDAO pointDao = new PointDAO();
                    pointDao.Insert(point);
                    DataTable dt = (DataTable) dgPoint.DataSource;

                    foreach(DataGridViewRow item in dgPoint.Rows)
                    {
                        ItemPoint ip = new ItemPoint();

                        ip.CodPoint = pointDao.EndPoint();
                        ip.Date = item.Cells[0].Value.ToString();
                        ip.EntryTime = item.Cells[1].Value.ToString();
                        ip.LunchDeparture = item.Cells[2].Value.ToString();
                        ip.LunchEntrance = item.Cells[3].Value.ToString();
                        ip.ExitTime = item.Cells[4].Value.ToString();
                        ip.ExtraEntry = item.Cells[5].Value.ToString();
                        ip.ExtraOutput = item.Cells[6].Value.ToString();

                        ItemPointDAO itemDao = new ItemPointDAO();
                        itemDao.Insert(ip);
                    }

                    Dialog.MessageInsert("Ponto");
                    txtCod.Text = new PointDAO().EndPoint().ToString();
                }
                else
                {
                    Dialog.Message("Você não pode cadastrar o mesmo pointo duas vezes", "atenção");
                }

            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion

        #region btnDeletePoint_click
        private void btnDeletePoint_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(txtCod.Text, out int cod);
                new PointDAO().Delete(cod);
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion

        #region btnGenarete_click
        private void btnGenarete_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new EmployeeDAO().GetSearch(mtbCPF.Text) ?? throw new NullReferenceException("Funciário não encontrado!");
                Company com = new CompanyDAO().Search(int.Parse(txtCodCompany.Text)) ?? throw new NullReferenceException("Empresa não encontrada!");

                PrintOut.PrintOutPoint(com, emp, dgPoint);
                Dialog.MessageInsertOthers("ponto");
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion

        #region btnPrintout_click
        private void btnPrintout_Click(object sender, EventArgs e)
        {
            Employee emp = new EmployeeDAO().GetSearchEmp(txtNameEmployee.Text) ?? throw new Exception("Funcionário não encontrado!");
            Company com = new CompanyDAO().Search(int.Parse(txtCodCompany.Text)) ?? throw new NullReferenceException("Empresa não encontrada");
            PrintOut.PrintOutPoint(com, emp, dgPoint);
        }
        #endregion
    }
}