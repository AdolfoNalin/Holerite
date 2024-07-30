using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
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
using Point = Holerite.br.pro.MODEL.Point;

namespace Holerite.br.pro.VIEW
{
    public partial class frmInsertPoint : Form
    {
        public frmInsertPoint()
        {
            InitializeComponent();
        }

        #region btnInsert_Click
        private void btnInsert_Click(object sender, EventArgs e)
        {
            EmployeeDAO dao = new EmployeeDAO();
            Point point = new Point()
            { 
                CodCompany = 2,
                CodEmp = dao.Search(mtbCPF.Text, txtNameEmployee.Text)
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
            ItemPointDAO dao = new ItemPointDAO();  
            
        }
        #endregion

        private void btnPrntOut_Click(object sender, EventArgs e)
        {
           PrintOut pt = new PrintOut(dgPoint);
           
        }

        private void mtbCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EmployeeDAO dao = new EmployeeDAO();
                Employee obj = dao.GetSearch(mtbCPF.Text);

                txtNameEmployee.Text = obj.Name;
                txtFunction.Text = obj.Function;
                txtAddress.Text = $"{obj.CEP}, {obj.State}, {obj.City}, {obj.Neighborhood}, {obj.Street}, {obj.HomeNumber}";
            }
        }

        #region Load
        private void frmInsertPoint_Load(object sender, EventArgs e)
        {
            //MaskedTextBox date = new MaskedTextBox();
            //MaskedTextBox time = new MaskedTextBox();

            //date.Visible = false;
            //time.Visible = false;

            //date.Mask = "dd/mm/yyyy";
            //time.Mask = "hh:mm";

            //dgPoint.Controls.Add(date);
            //dgPoint.Controls.Add(time);

            //dgPoint.CellBeginEdit += new DataGridViewCellCancelEventHandler(dgPoint_); 
        }
        #endregion
    }
}
