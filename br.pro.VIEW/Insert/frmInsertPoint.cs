using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using Holerite.br.pro.VIEW.Consult;
using Holerite.br.pro.VIEW.Insert;
using Holerite.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp;
using Point = Holerite.br.pro.MODEL.Point;

namespace Holerite.br.pro.VIEW
{
    public partial class frmInsertPoint : Form
    {
        public DateTime Data { get; private set; }

        #region ConsultrotorEmpyt
        public frmInsertPoint()
        {
            InitializeComponent();
        }
        #endregion

        #region ConstrutorWithDate
        public frmInsertPoint(DateTime data)
        {
            InitializeComponent();
            this.Data = data;
        }
        #endregion

        #region btnInsert_Click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            Point point = new Point()
            {
                CodCompany = 2,
                CodEmp = dao.Search(mtbCPF.Text, txtNameEmployee.Text),
                Month = DateTime.Parse(mtbDate.Text),
            };

            PointDAO Pdao = new PointDAO();
            Pdao.Insert(point);

            foreach (DataGridViewRow dgPoint in dgPoint.Rows)
            {
                ItemPoint item = new ItemPoint()
                {
                    CodPoint = Pdao.EndPoint(),
                    Date = DateTime.Parse(dgPoint.Cells[0].Value.ToString()),
                    EntryTime = DateTime.Parse(dgPoint.Cells[1].Value.ToString()),
                    LunchDeparture = DateTime.Parse(dgPoint.Cells[2].Value.ToString()),
                    LunchEntrance = DateTime.Parse(dgPoint.Cells[3].Value.ToString()),
                    ExitTime = DateTime.Parse(dgPoint.Cells[4].Value.ToString()),
                    ExtraEntry = DateTime.Parse(dgPoint.Cells[5].Value.ToString()),
                    ExtraOutput = DateTime.Parse(dgPoint.Cells[6].Value.ToString())
                };

                ItemPointDAO Idao = new ItemPointDAO();
                Idao.Insert(item);
            }

        }
        #endregion

        #region btnEdit_Click
        private void btnEdit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgPoint in dgPoint.Rows)
            {
                ItemPoint item = new ItemPoint()
                {
                    Date = DateTime.Parse(dgPoint.Cells[0].Value.ToString()),
                    EntryTime = DateTime.Parse(dgPoint.Cells[1].Value.ToString()),
                    LunchDeparture = DateTime.Parse(dgPoint.Cells[2].Value.ToString()),
                    LunchEntrance = DateTime.Parse(dgPoint.Cells[3].Value.ToString()),
                    ExitTime = DateTime.Parse(dgPoint.Cells[4].Value.ToString()),
                    ExtraEntry = DateTime.Parse(dgPoint.Cells[5].Value.ToString()),
                    ExtraOutput = DateTime.Parse(dgPoint.Cells[6].Value.ToString())
                };

                ItemPointDAO Idao = new ItemPointDAO();
                Idao.Update(item);
            }
        }
        #endregion

        #region btnDelete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ItemPointDAO iPoint = new ItemPointDAO();
            PointDAO point = new PointDAO();

            int cod = int.Parse(txtCod.Text);

            iPoint.Delete(cod);
            point.Delete(cod);
        }
        #endregion

        #region btnPrintOut_click
        private void btnPrntOut_Click(object sender, EventArgs e)
        {
            //PrintOut pt = new PrintOut(dgPoint);

        }
        #endregion

        #region mtbCPF_keypress
        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Employee obj = Verification.ToCheck(mtbCPF.Text);

                txtNameEmployee.Text = obj.Name;
                txtFunction.Text = obj.Function;
                txtAddress.Text = $"{obj.CEP}, {obj.State}, {obj.City}, {obj.Neighborhood}, {obj.Street}, {obj.HomeNumber}";
            }
        }
        #endregion

        #region Load
        private void frmInsertPoint_Load(object sender, EventArgs e)
        {
            mtbDate.Text = DateTime.Now.ToShortDateString();
        }
        #endregion

        #region btnSearchEmp_Click
        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                frmConsultEmpGeneratePoint screen = new frmConsultEmpGeneratePoint(2);
                screen.ShowDialog();
                this.Visible = true;
                MonthCalendar mc = screen.Calender;
                List<string> date = new List<string>();

                if (mc.SelectionRange.Start.Month == mc.SelectionRange.End.Month)
                {
                    for (int i = mc.SelectionStart.Day; i <= mc.SelectionEnd.Day; i++)
                    {
                        date.Add($"{i}/{mc.SelectionStart.Month}/{mc.SelectionStart.Year}");
                    }

                    for (int i = 0; i < date.Count; i++)
                    {
                        dgPoint.Rows.Add(date[i], "  :  ", "  :  ", "  :  ", "  :  ", "  :  ", "  :  ");
                    }

                    DataGridView dv = new DataGridView();
                    dv = screen.dgGeneratePoint;

                    Employee emp = new Employee();
                    emp.Cod = int.Parse(dv.CurrentRow.Cells[0].Value.ToString());
                    emp.Name = dv.CurrentRow.Cells[1].Value.ToString();
                    emp.CPF = dv.CurrentRow.Cells[6].Value.ToString();
                    emp.CEP = dv.CurrentRow.Cells[10].Value.ToString();
                    emp.State = dv.CurrentRow.Cells[11].Value.ToString();
                    emp.City = dv.CurrentRow.Cells[12].Value.ToString();
                    emp.Neighborhood = dv.CurrentRow.Cells[13].Value.ToString();
                    emp.Street = dv.CurrentRow.Cells[14].Value.ToString();
                    emp.HomeNumber = int.Parse(dv.CurrentRow.Cells[15].Value.ToString());
                    emp.Function = dv.CurrentRow.Cells[17].Value.ToString();

                    txtCodCompany.Text = "1";
                    txtCodEmployee.Text = emp.Cod.ToString();
                    txtNameEmployee.Text = emp.Name;
                    mtbCPF.Text = emp.CPF;
                    txtFunction.Text = emp.Function;

                    string address = $"{emp.CEP}, {emp.State}, {emp.City}, {emp.Neighborhood}, {emp.HomeNumber}";
                    txtAddress.Text = address;
                }
                else
                {
                    Dialog.Message("A folha de ponto representa somente um mês!", "atencão");
                }   
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
           
        }
        #endregion

        #region btnSave
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == String.Empty)
            {
                Point point = new Point()
                {
                    CodCompany = int.Parse(txtCodCompany.Text),
                    CodEmp = int.Parse(txtCodEmployee.Text),
                    Month = DateTime.Parse(mtbDate.Text)

                };

                new PointDAO().Insert(point);

                for (int i = 0; i < dgPoint.Rows.Count; i++)    
                {
                    ItemPoint ip = new ItemPoint()
                    {
                        CodPoint = new PointDAO().EndPoint(),
                        Date = DateTime.Parse(dgPoint.CurrentRow.Cells[0].Value.ToString()),
                        EntryTime = DateTime.Parse(dgPoint.CurrentRow.Cells[1].Value.ToString()),
                        LunchDeparture = DateTime.Parse(dgPoint.CurrentRow.Cells[2].Value.ToString()),
                        LunchEntrance = DateTime.Parse(dgPoint.CurrentRow.Cells[3].Value.ToString()),
                        ExitTime = DateTime.Parse(dgPoint.CurrentRow.Cells[4].Value.ToString()),
                        ExtraEntry = DateTime.Parse(dgPoint.CurrentRow.Cells[5].Value.ToString()),
                        ExtraOutput = DateTime.Parse(dgPoint.CurrentRow.Cells[6].Value.ToString())
                    };

                    new ItemPointDAO().Insert(ip);
                }
                Dialog.MessageInsert("Ponto", title: "Sucesso");
            }
            else
            {
                Dialog.MessageError(new ArgumentException("Esse ponto não pode ser cadastrado novamente!"));
            }
        }
        #endregion

        #region btnUpdate_click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCod.Text, out int cod);

            try
            {
                for (int i = 0; i < dgPoint.Rows.Count; i++)
                {
                    ItemPoint ip = new ItemPoint()
                    {
                        CodPoint = new PointDAO().EndPoint(),
                        Date = DateTime.Parse(dgPoint.CurrentRow.Cells[0].Value.ToString()),
                        EntryTime = DateTime.Parse(dgPoint.CurrentRow.Cells[1].Value.ToString()),
                        LunchDeparture = DateTime.Parse(dgPoint.CurrentRow.Cells[2].Value.ToString()),
                        LunchEntrance = DateTime.Parse(dgPoint.CurrentRow.Cells[3].Value.ToString()),
                        ExitTime = DateTime.Parse(dgPoint.CurrentRow.Cells[4].Value.ToString()),
                        ExtraEntry = DateTime.Parse(dgPoint.CurrentRow.Cells[5].Value.ToString()),
                        ExtraOutput = DateTime.Parse(dgPoint.CurrentRow.Cells[6].Value.ToString())
                    };

                    new ItemPointDAO().Insert(ip);
                }
                Dialog.MessageInsert("Ponto", title: "Sucesso");
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
                ItemPointDAO dao = new ItemPointDAO();
                int.TryParse(txtCod.Text, out int cod);
                dao.Delete(cod);
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion

        #region btnGenerate_click
        private void btnGenarete_Click(object sender, EventArgs e)
        {
            Employee emp = new EmployeeDAO().GetSearchEmp(txtNameEmployee.Text);
            Company com = new Company() { 
                Cod = 1
            };
            PrintOut.PrintOutPoint(com, emp, dgPoint);
        }
        #endregion
    }
}