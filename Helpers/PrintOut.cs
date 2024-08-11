using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Holerite.br.pro.DAO;
using Holerite.br.pro.MODEL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.EntityFrameworkCore.Internal;

namespace Holerite.Helpers
{
    public class PrintOut
    {
        #region Overview
        private static Overview GetOverview(DataGridView dg, float daily)
        {
            Overview obj = new Overview();

            float entry = 0;
            float lunchOutput = 0;
            float lunchEntry = 0;
            float exit = 0;
            float extraExit = 0;
            float extraEntry= 0;

            float morning = 0;
            float afternoon = 0;
            float extra = 0;

            for (int i = 0; i < dg.Rows.Count; i++)
            {
                entry = float.Parse(dg.CurrentRow.Cells[1].Value.ToString());
                lunchOutput = float.Parse(dg.CurrentRow.Cells[2].Value.ToString());
                lunchEntry = float.Parse(dg.CurrentRow.Cells[3].Value.ToString());
                exit = float.Parse(dg.CurrentRow.Cells[4].Value.ToString());
                extraEntry = float.Parse(dg.CurrentRow.Cells[5].Value.ToString());
                extraExit = float.Parse(dg.CurrentRow.Cells[6].Value.ToString());

                morning += entry - lunchOutput;
                afternoon += lunchEntry - exit;
                extra += extraExit - extraEntry;
            }

            float monthHours = (morning + afternoon);
            float dayMonth = (morning + afternoon) / 10;
            float wage = (monthHours + extra) * daily;

            obj.TimeWork = DateTime.Parse(monthHours.ToString());
            obj.ExtraTime = DateTime.Parse(extra.ToString());

            
            return obj;
        }
        #endregion

        #region PrintOutPoint
        //public static void PrintOutPoint(/*bool logo, string type, Company com, Employee emp, DataGridView dg*/)
        //{
        //    bool logo = false;
        //    string issuanceDate = DateTime.Now.ToShortDateString();
        //    float time = 00.00f;
        //    float extraTime = 0f;
        //    float timeRest = 0f;
        //    DataGridView dg = new DataGridView();

        //    Company com = new Company()
        //    {
        //        Name = "Adolfo Nalin Junior",
        //        FantasyName = "ANJ Company",
        //        CNPJ = "80.562.058/0001-20",
        //        State = "SP",
        //        City = "Águas de Santa Barbara",
        //        Neighborhood = "CDHU 3",
        //        Street = "Rua Três",
        //        HomeNumber = 95,
        //        CEP = "18770-000"
        //    };

        //    Employee emp = new Employee()
        //    {
        //        Name = "Gilsemar Santos",
        //        Function = "Ajudante Geral",
        //        Daily = 90,
        //        CTPS = ""
        //    };

        //    string address = $"{com.CEP}, {com.State}, {com.City}, {com.Neighborhood}, {com.Street}, {com.HomeNumber}";
        //    try
        //    {
        //        string nameFile = "";

        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.Filter = "txt file (*.pdf)|*.txt|All file (*.*)|*.*";
        //        sfd.FilterIndex = 2;
        //        sfd.DefaultExt = "pdf";
        //        sfd.RestoreDirectory = true;
        //        sfd.AddExtension = false;
        //        sfd.Title = "Escolha um local para savar o arquivo";

        //        if(sfd.ShowDialog() != DialogResult.OK)
        //        {
        //            if (sfd.FileName == String.Empty)
        //            {
        //                DialogResult resp = MessageBox.Show("Não quer savar o arquio?", "ATENÇÃO", MessageBoxButtons.YesNo);
        //                if (resp == DialogResult.Yes)
        //                {
        //                    sfd.ShowDialog();
        //                }
        //            }

        //            string filePath = sfd.FileName;
        //            nameFile = $"{filePath}_Ponto";
        //        }

        //        if(logo)
        //        {
        //            Image image = Image.GetInstance("Caminho");
        //            image.ScaleToFit(150, 300);
        //            image.SetAbsolutePosition(430f, 650f);
        //        }
               
        //        FileStream fs = new FileStream(nameFile, FileMode.Create);
        //        Document doc = new Document(PageSize.A4);
        //        PdfWriter pdf = PdfWriter.GetInstance(doc, fs);

        //        string dado = "";
                
        //        Paragraph empregador = new Paragraph(dado, new Font(Font.NORMAL,20,(int)System.Drawing.FontStyle.Bold));
        //        empregador.Alignment = Element.ALIGN_LEFT;
        //        empregador.Add($"Empregador/ Nome: {com.Name} | CNPJ: {com.CNPJ} \n Endereço: {address}");

        //        Paragraph empregado = new Paragraph(dado, new Font(Font.NORMAL, 20, (int) System.Drawing.FontStyle.Bold));
        //        empregado.Alignment = Element.ALIGN_LEFT;
        //        empregado.Add($@"Empregado(a): {emp.Name} | CTPS: {emp.CTPS} | Data Emissão: {issuanceDate} \nFunção: {emp.Function} | 
        //        Horário de trabalho de SEG a SEX feira: {time}\nHorário aos Sábados: {extraTime} | Descanso Semanal: {timeRest}");

        //        PdfPTable pt = new PdfPTable(7);

        //        pt.AddCell("Data");
        //        pt.AddCell("Hora Entrada");
        //        pt.AddCell("Saida Almoço");
        //        pt.AddCell("Entrada Almoço");
        //        pt.AddCell("Hora Saida");
        //        pt.AddCell("Entrada Extra");
        //        pt.AddCell("Saida Extra");

        //        foreach(DataGridViewRow dgvr in dg.Rows)
        //        {
        //            ItemPoint ip = new ItemPoint()
        //            {
        //                Date = DateTime.Parse(dg.CurrentRow.Cells[0].Value.ToString()),
        //                EntryTime = DateTime.Parse(dg.CurrentRow.Cells[0].Value.ToString()),
        //                LunchEntrance = DateTime.Parse(dg.CurrentRow.Cells[0].Value.ToString()),
        //                LunchDeparture = DateTime.Parse(dg.CurrentRow.Cells[0].Value.ToString()),
        //                ExitTime = DateTime.Parse(dg.CurrentRow.Cells[0].Value.ToString()),
        //                ExtraEntry = DateTime.Parse(dg.CurrentRow.Cells[0].Value.ToString()),
        //                ExtraOutput = DateTime.Parse(dg.CurrentRow.Cells[0].Value.ToString())
        //            };

        //            pt.AddCell(ip.Date.ToString());
        //            pt.AddCell(ip.EntryTime.ToString());
        //            pt.AddCell(ip.LunchEntrance.ToString());
        //            pt.AddCell(ip.LunchDeparture.ToString());
        //            pt.AddCell(ip.ExitTime.ToString());
        //            pt.AddCell(ip.ExtraEntry.ToString());
        //            pt.AddCell(ip.ExtraOutput.ToString());
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
        //    }
        //}
        #endregion

        #region PrintOutHolerite
        public void PrintOutHolerite(/**/)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "Atenção");
            }
            finally
            {
            }
        }
        #endregion

        #region PrintOutBudget
        /// <summary>
        /// Transforma o orçamento em PDF
        /// </summary>
        /// <param name="dg"></param>
        /// <param name="cliente"></param>
        /// <param name="date"></param>
        /// <param name="obs"></param>
        public static void PrintOutBudget(DataGridView dg, string cliente, DateTime date, string obs)
        {
            float subtotal = 0;
            try
            {
                string nameFile = "";

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt file (*.pdf)|*.txt|All file (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.DefaultExt = "pdf";
                sfd.RestoreDirectory = true;
                sfd.AddExtension = false;
                sfd.Title = "Escolha um local para savar o arquivo";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    if (sfd.FileName == String.Empty)
                    {
                        DialogResult resp = MessageBox.Show("Não quer savar o arquio?", "ATENÇÃO", MessageBoxButtons.YesNo);
                        if (resp == DialogResult.Yes)
                        {
                            sfd.ShowDialog();
                        }
                    }
                }

                string filePath = sfd.FileName;
                nameFile = $"{filePath}_Orçamento";

                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Program Files (x86)\Sistema de Vendas\Logo.jpeg");
                //logo.ScaleToFit(150, 300);
                //logo.SetAbsolutePosition(430f, 650f);

                FileStream fs = new FileStream(nameFile, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter pdf = PdfWriter.GetInstance(doc, fs);

                string dado = "";

                Paragraph cabecario = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                cabecario.Alignment = Element.ALIGN_LEFT;
                cabecario.Add($"Contrutora Realiza | CNPJ: 40.405.345/0001-20 \nEndereço: \n| Data:{date}");

                Paragraph client = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14, (int)System.Drawing.FontStyle.Bold));
                cabecario.Alignment = Element.ALIGN_LEFT;
                cabecario.Add($"Nome: {client}");

                PdfPTable pt = new PdfPTable(5);

                pt.AddCell("Código");
                pt.AddCell("Descrição do Serviço");
                pt.AddCell("Preço");
                pt.AddCell("Qauntidade");
                pt.AddCell("Subtotal");

                foreach (DataGridViewRow dgvr in dg.Rows)
                {
                    pt.AddCell(dgvr.Cells[0].Value.ToString());
                    pt.AddCell(dgvr.Cells[1].Value.ToString());
                    pt.AddCell(dgvr.Cells[2].Value.ToString());
                    pt.AddCell(dgvr.Cells[3].Value.ToString());
                    pt.AddCell(dgvr.Cells[4].Value.ToString());

                    subtotal += float.Parse(dgvr.Cells[4].Value.ToString());

                    ItemBudget ib = new ItemBudget()
                    {
                        CodBudget = new BudgetDAO().EndBudget(),
                        CodSeverce = int.Parse(dgvr.Cells[0].Value.ToString()),
                        Price = float.Parse(dgvr.Cells[2].Value.ToString()),
                        Amount = int.Parse(dgvr.Cells[3].Value.ToString()),
                        Subtotal = float.Parse(dgvr.Cells[4].Value.ToString()),
                    };

                    new ItemBudgetDAO().Insert(ib);
                }

                pt.HorizontalAlignment = Element.ALIGN_LEFT;

                Paragraph dadosFinais = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                dadosFinais.Alignment = Element.ALIGN_LEFT;
                dadosFinais.Add($"\nSubTotal: R${subtotal} \nTotal: R${subtotal}");

                Paragraph observation = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                observation.Alignment = Element.ALIGN_LEFT;
                observation.Add($"\nObeservação: \n{obs}");

                doc.Open();
                //doc.Add(logo);
                doc.Add(cabecario);
                doc.Add(client);
                doc.Add(pt);
                doc.Add(dadosFinais);
                doc.Add(observation);
                doc.Close();

                BudgetDAO budgetDAO = new BudgetDAO();

            }
            catch (Exception ex)
            {
                Dialog.Message($"Aconteceu um erro do tipo {ex.Message} com o caminho para {ex.StackTrace}", "atenção");
            }
        }
        #endregion

        #region ToRecord
        /// <summary>
        /// Cadastra os dados no banco de dados
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="codEmployeem"></param>
        /// <param name="codClient"></param>
        public static void ToRecord(DataGridView dg, Budget obj)
        {
            try
            {
                BudgetDAO dao = new BudgetDAO();
                dao.Insert(obj);

                foreach (DataGridViewRow line in dg.Rows)
                {
                    ItemBudget ib = new ItemBudget()
                    {
                        CodBudget = dao.EndBudget(),
                        CodSeverce = int.Parse(line.Cells[0].Value.ToString()),
                        Price = float.Parse(line.Cells[2].Value.ToString()),
                        Amount = int.Parse(line.Cells[3].Value.ToString()),
                        Subtotal = float.Parse(line.Cells[4].Value.ToString()),
                    };

                    ItemBudgetDAO itemDao = new ItemBudgetDAO();
                    itemDao.Insert(ib);
                }
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion

        #region PrintOut
        public static void PrintOutPoint(Employee emp, List<string> date)
        {
            try
            {

                string address = $"{emp.CEP}, {emp.State}, {emp.City}, {emp.Neighborhood}, {emp.Street}, {emp.HomeNumber}";
                string nameFile = "";

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt file (*.pdf)|*.txt|All file (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.DefaultExt = "pdf";
                sfd.RestoreDirectory = true;
                sfd.AddExtension = false;
                sfd.Title = "Escolha um local para savar o arquivo";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    if (sfd.FileName == String.Empty)
                    {
                        DialogResult resp = MessageBox.Show("Não quer savar o arquio?", "ATENÇÃO", MessageBoxButtons.YesNo);
                        if (resp == DialogResult.Yes)
                        {
                            sfd.ShowDialog();
                        }
                    }
                }

                string filePath = sfd.FileName;
                nameFile = $"{filePath}_Ponto";

                FileStream fs = new FileStream(nameFile, FileMode.Create);
                Document doc = new Document(PageSize.A4);
                PdfWriter pdf = PdfWriter.GetInstance(doc, fs);

                string dado = "";

                Paragraph empregador = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                empregador.Alignment = Element.ALIGN_LEFT;
                empregador.Add($"|Empregador/ Nome: Construtora Realiza | CNPJ: 25.400.345/0001-20| \n|Endereço: 18772-226, Ágaus de Santaq Barbara, Três Marias, 40|");

                Paragraph empregado = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                empregado.Alignment = Element.ALIGN_RIGHT;
                empregado.Add($"Empregado(a): {emp.Name} | CTPS: {emp.CTPS} | Data Emissão: {DateTime.Now.ToShortDateString()} \nFunção: {emp.Function} |" +
                "Horário de trabalho de SEG a SEX feira:       \nHorário aos Sábados:     | Descanso Semanal:     \n\n");

                PdfPTable pt = new PdfPTable(8);
                pt.HorizontalAlignment = Element.ALIGN_CENTER;
                pt.WidthPercentage = 110f;

                pt.AddCell("Data");
                pt.AddCell("Hora Entrada");
                pt.AddCell("Saida Almoço");
                pt.AddCell("Entrada Almoço");
                pt.AddCell("Hora Saida");
                pt.AddCell("Entrada Extra");
                pt.AddCell("Saida Extra");
                pt.AddCell("Assinatura");

                string time = "";
                for(int i = 0; i < date.Count; i++)
                {
                    pt.AddCell(date[i]);
                    pt.AddCell(time);
                    pt.AddCell(time);
                    pt.AddCell(time);
                    pt.AddCell(time);
                    pt.AddCell(time);
                    pt.AddCell(time);
                    pt.AddCell("_______");
                }


                PdfPTable ptOverview = new PdfPTable(3);

                Paragraph overview = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Regular));
                overview.Alignment = Element.ALIGN_LEFT;

                overview.Add($"Dias/ Horas Normais     R$|___________________|   VISTO DA FISCALIZAÇÃO  ");
                overview.Add($"H. Extras Adicionais    R$|___________________|                          ");
                overview.Add($"Falta Mês               R$|___________________|                          ");
                overview.Add($"Sub total / Base Cal    R$|___________________|                          ");
                overview.Add($"Outro Desconto(Verso)   R$|___________________|                          ");
                overview.Add($"Salário Familia         R$|___________________|                          ");
                overview.Add($"Total Liquido a Receber R$|___________________|                          ");

                doc.Open();
                doc.Add(empregador);
                doc.Add(empregado);
                doc.Add(pt);
                doc.Add(overview);
                doc.Close();
              
            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion

        #region PrintOut
        public static void PrintOutEpi(int codEmp, int codEpi,DataGridView dg, string observation)
        {
            EmployeeDAO empD = new EmployeeDAO();
            Employee emp = empD.Search(codEmp);
            string address = $"{emp.CEP}, {emp.State}, {emp.City}, {emp.Neighborhood}, {emp.Street}, {emp.HomeNumber}";
            try
            {
                string nameFile = "";
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt file (*.pdf)|*.txt|All file (*.*)|*.*";
                sfd.FilterIndex = 2;
                sfd.DefaultExt = "pdf";
                sfd.RestoreDirectory = true;
                sfd.AddExtension = false;
                sfd.Title = "Escolha um local para savar o arquivo";

                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    if (sfd.FileName == String.Empty)
                    {
                        DialogResult resp = MessageBox.Show("Não quer savar o arquio?", "ATENÇÃO", MessageBoxButtons.YesNo);
                        if (resp == DialogResult.Yes)
                        {
                            sfd.ShowDialog();
                        }
                    }
                }
                 
                string filePath = sfd.FileName;
                nameFile = $"{filePath}_EPI";

                FileStream fs = new FileStream(nameFile, FileMode.Create);
                Document doc = new Document(PageSize.A5);
                PdfWriter pdf = PdfWriter.GetInstance(doc, fs);

                string dado = "";

                Paragraph empregador = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                empregador.Alignment = Element.ALIGN_LEFT;
                empregador.Add($"|Empregador/ Nome: Construtora Realiza |\n|CNPJ: 25.400.345/0001-20|\n|Endereço: 18772-226, Ágaus de Santaq Barbara, Três Marias, 40|");

                Paragraph empregado = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                empregado.Alignment = Element.ALIGN_LEFT;
                empregado.Add($"Empregado(a): {emp.Name} | Data Emissão: {DateTime.Now.ToShortDateString()} \nEmdereço: {address}| \n\n");

                PdfPTable pt = new PdfPTable(3);
                pt.HorizontalAlignment = Element.ALIGN_CENTER;
                pt.WidthPercentage = 90f;

                pt.AddCell("Código");
                pt.AddCell("Descrição Resumida");
                pt.AddCell("Quantidade");

                for (int i = 0; i < dg.Rows.Count; i++)
                {
                    ItemEpi ie = new ItemEpi()
                    {
                        CodEpi = new EpiDAO().EndCod(),
                        CodProd = int.Parse(dg.CurrentRow.Cells[0].Value.ToString()),
                        Price = float.Parse(dg.CurrentRow.Cells[2].Value.ToString()),
                        Amount = int.Parse(dg.CurrentRow.Cells[3].Value.ToString()),
                        Subtotal = float.Parse(dg.CurrentRow.Cells[4].Value.ToString()),
                    };

                    Product obj = new ProductDAO().Search(ie.CodProd);
                  
                    if (codEpi == 0)
                    {
                        ItemEpiDAO dao = new ItemEpiDAO();
                        dao.Insert(ie);
                    }

                    pt.AddCell(ie.CodProd.ToString());
                    pt.AddCell(obj.ShortDescription);
                    pt.AddCell(ie.Amount.ToString());
                }

                Paragraph obs = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                obs.Alignment = Element.ALIGN_LEFT;

                obs.Add($"\n\n{observation}");

                Paragraph assinatura = new Paragraph(dado, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
                assinatura.Alignment = Element.ALIGN_LEFT;

                assinatura.Add($"\n\n{emp.Name}:____________________________________| ");

                doc.Open();
                doc.Add(empregador);
                doc.Add(empregado);
                doc.Add(pt);
                doc.Add(assinatura);
                doc.Close();
            }
            catch (Exception ex)
            {
                Dialog.MessageError (ex);
            }
        }
        #endregion

        #region PrintOut
        public void PrintOutEpi()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Dialog.MessageError(ex);
            }
        }
        #endregion
    }
}
