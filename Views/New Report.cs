using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Serialization;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using Ranking_Reporter.Models;
using static Microsoft.IO.RecyclableMemoryStreamManager;
using static OfficeOpenXml.ExcelErrorValue;

namespace Ranking_Reporter.Views
{
    public partial class New_Report : Form
    {
        string filePath = @"Temporary.xlsx";
        List<Agents_Results> Agents_Summary = new List<Agents_Results>();

        private bool IsAnyCellEmpty(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        return true; // Found an empty cell
                    }
                }
            }
            return false; // No empty cells found
        }

        private int CalculateMaxCRU(int maxCRU)
        {
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Get Maximum CRU value//
                var cellValue = row.Cells[1].Value;
                int intValue = Convert.ToInt32(row.Cells[1].Value);
                if (intValue > maxCRU)
                {
                    maxCRU = intValue;
                }
            }
            return maxCRU;
        }
        private int CalculateMaxOnsite(int maxOnsite)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Get Maximum On-site value//
                var cellValue1 = row.Cells[2].Value;
                int intValue1 = Convert.ToInt32(row.Cells[2].Value);
                if (intValue1 > maxOnsite)
                {
                    maxOnsite = intValue1;
                }
            }
            return maxOnsite;
        }
        private float CalculateMin7DRRR(float min7DRRR)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                float floatValue;
                //Get Maximum CRU value//
                if(row.Cells[4].Value != null)
                {
                    floatValue = float.Parse((string)row.Cells[4].Value);
                    if (floatValue < min7DRRR)
                    {
                        min7DRRR = floatValue;
                    }
                }
            }
            //MessageBox.Show("Highest 7 days RRR: " + min7DRRR);
            return min7DRRR;
        }
        private float CalculateMin30DRRR(float min30DRRR)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                float floatValue;
                //Get Maximum CRU value//
                if (row.Cells[3].Value != null)
                {
                    floatValue = float.Parse((string)row.Cells[3].Value);
                    if (floatValue < min30DRRR)
                    {
                        min30DRRR = floatValue;
                    }
                }
            }
            return min30DRRR;
        }
        private float CalculateMinPPSNR(float minPPSNR)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                float floatValue;
                //Get Maximum CRU value//
                if (row.Cells[5].Value != null)
                {
                    floatValue = float.Parse((string)row.Cells[5].Value);
                    if (floatValue < minPPSNR)
                    {
                        minPPSNR = floatValue;
                    }
                }
            }
            return minPPSNR;
        }
        private int CalculateMaxOSATNO(int maxOSATNo)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Get Maximum On-site value//
                var cellValue1 = row.Cells[6].Value;
                int intValue1 = Convert.ToInt32(row.Cells[6].Value);
                if (intValue1 > maxOSATNo)
                {
                    maxOSATNo = intValue1;
                }
            }
            //MessageBox.Show("Max OSAT No: " + maxOSATNo);
            return maxOSATNo;
        }
        private float CalculateMaxOSATScore(float maxOSATScore)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                float floatValue;
                //Get Maximum CRU value//
                if (row.Cells[7].Value != null)
                {
                    floatValue = float.Parse((string)row.Cells[7].Value);
                    if (floatValue > maxOSATScore)
                    {
                        maxOSATScore = floatValue;
                    }
                }
            }
            //MessageBox.Show("Max OSAT Score: " + maxOSATScore);
            return maxOSATScore;
        }
        private float CalculateProductivity(float maxProd)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                float floatValue;
                //Get Maximum CRU value//
                if (row.Cells[8].Value != null)
                {
                    floatValue = float.Parse((string)row.Cells[8].Value);
                    if (floatValue > maxProd)
                    {
                        maxProd = floatValue;
                    }
                }
            }
            return maxProd;
        }

        public float calculateAvgerage(float total, int count)
        {
            float average = total / count;
            return average;
        }

        public void colorCells(float avg,string colName,float maxOrMin,int flag)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[colName].Value != null &&
                    float.TryParse(row.Cells[colName].Value.ToString(), out float num))
                {
                    if(flag == 1)
                    {
                        if (num > avg) // Example condition
                        {
                            row.Cells[colName].Style.BackColor = Color.Lime;
                            row.Cells[colName].Style.ForeColor = Color.Black;
                        }
                        else
                        {
                            row.Cells[colName].Style.BackColor = Color.Red;
                            row.Cells[colName].Style.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (num < avg) // Example condition
                        {
                            row.Cells[colName].Style.BackColor = Color.Lime;
                            row.Cells[colName].Style.ForeColor = Color.Black;
                        }
                        else
                        {
                            row.Cells[colName].Style.BackColor = Color.Red;
                            row.Cells[colName].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }
        private void ColorCellsBasedOnWeight(float weight, string KPI,int flag,float avg)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[KPI].Value != null &&
                    float.TryParse(row.Cells[KPI].Value.ToString(), out float num))
                {
                    if (flag == 2) //(30DRRR,7DRRR,PPSNR)
                    {
                        if (num > weight) 
                        {
                            row.Cells[KPI].Style.BackColor = Color.Red;
                            row.Cells[KPI].Style.ForeColor = Color.Black;
                        }
                        if(num < weight && num >avg)
                        {
                            row.Cells[KPI].Style.BackColor = Color.Lime;
                            row.Cells[KPI].Style.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (num < weight) //(OSAT Score, Productivity)
                        {
                            row.Cells[KPI].Style.BackColor = Color.Red;
                            row.Cells[KPI].Style.ForeColor = Color.Black;
                        }
                        if(num > weight && num < avg)
                        {
                            row.Cells[KPI].Style.BackColor = Color.Lime;
                            row.Cells[KPI].Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        private void Set_Results_Score_in_DataGridView(List<Agents_Results> agents)
        {
            int i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (i < Agents_Summary.Count - 1)
                {
                    row.Cells[9].Value = agents[i].get_Agent_Total_Performance();
                    if (agents[i].get_Agent_Rank() == 1)
                    {
                        row.Cells[9].Style.BackColor = Color.DeepSkyBlue;
                        row.Cells[9].Style.ForeColor= Color.Black;
                        row.Cells[9].Value = agents[i].get_Agent_Rank();
                    }
                    else
                    {
                        row.Cells[9].Value = agents[i].get_Agent_Rank();
                    }
                    i++;
                }
            }
        }


        private void LoadExcelData(string filePath)
        {
            // Enable the use of Excel in non-commercial contexts
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Get the first worksheet
                var dataTable = new DataTable();

                // Add columns from the header row
                for (int col = 2; col <= worksheet.Dimension.End.Column; col++)
                {
                    dataTable.Columns.Add(worksheet.Cells[1, col].Text);
                }

                // Add rows from the Excel data
                for (int row = 2; row <= worksheet.Dimension.End.Row; row++) // Start from row 2 to skip headers
                {
                    var newRow = dataTable.NewRow();
                    for (int col = 2; col <= worksheet.Dimension.End.Column; col++)
                    {
                        newRow[col - 2] = worksheet.Cells[row, col].Text;
                    }
                    dataTable.Rows.Add(newRow);
                }

                // Bind DataTable to DataGridView
                dataGridView1.DataSource = dataTable;
            }
        }

        private void ExportDataGridViewToExcel(DataGridView dataGridView, string filePath)
        {
            try
            {
                // Create a new Excel package
                using (ExcelPackage package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Data");

                    Color Border = Color.Yellow;

                    // Color Left border
                    for (int row = 0; row < dataGridView.Rows.Count + 2; row++)
                    {
                        worksheet.Cells[row + 1, 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row + 1, 1].Style.Fill.BackgroundColor.SetColor(Border);
                    }

                    // Color right border
                    for (int row = 0; row < dataGridView.Rows.Count + 2; row++)
                    {
                        worksheet.Cells[row + 1, dataGridView.Columns.Count + 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[row + 1, dataGridView.Columns.Count + 2].Style.Fill.BackgroundColor.SetColor(Border);
                    }

                    // Color top border
                    for (int col = 0; col < dataGridView.Columns.Count + 2; col++)
                    {
                        worksheet.Cells[1, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[1, col + 1].Style.Fill.BackgroundColor.SetColor(Border);
                    }

                    // Color bottom border
                    for (int col = 0; col < dataGridView.Columns.Count + 2; col++)
                    {
                        worksheet.Cells[dataGridView.Rows.Count + 2, col + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        worksheet.Cells[dataGridView.Rows.Count + 2, col + 1].Style.Fill.BackgroundColor.SetColor(Border);
                    }


                    //Set first column header as Ranking Column//
                    worksheet.Cells[2, 2].Value = dataGridView.Columns[dataGridView.Columns.Count - 1].HeaderText;
                    worksheet.Cells[2, 2].Style.Font.Bold = true;
                    worksheet.Cells[2, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    worksheet.Cells[2, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[2, 2].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                    worksheet.Cells[2, 2].Style.Font.Color.SetColor(Color.Black);

                    // Set rest of the columns headers
                    for (int col = 0; col < dataGridView.Columns.Count - 1; col++)
                    {
                        if (col < 4)
                        {
                            worksheet.Cells[2, col + 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[2, col + 3].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                            worksheet.Cells[2, col + 3].Style.Font.Color.SetColor(Color.Black);
                        }
                        else
                        {
                            worksheet.Cells[2, col + 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[2, col + 3].Style.Fill.BackgroundColor.SetColor(Color.DarkSalmon);
                            worksheet.Cells[2, col + 3].Style.Font.Color.SetColor(Color.Black);
                        }
                        worksheet.Cells[2, col + 3].Value = dataGridView.Columns[col].HeaderText;
                        worksheet.Cells[2, col + 3].Style.Font.Bold = true;
                        worksheet.Cells[2, col + 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        
                    }



                    // Copy DataGridView data and styles
                    //Make ranking column as first column in excel sheet.
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        var cellValue = dataGridView.Rows[row].Cells[dataGridView.Columns.Count - 1].Value;
                        worksheet.Cells[row + 3, 2].Value = cellValue;
                        worksheet.Cells[row + 3, 2].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                        // Copy background color
                        Color backColor = dataGridView.Rows[row].Cells[dataGridView.Columns.Count - 1].Style.BackColor;
                        if (backColor != Color.Empty)
                        {
                            worksheet.Cells[row + 3, 2].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[row + 3, 2].Style.Fill.BackgroundColor.SetColor(backColor);
                        }

                        // Copy font color
                        Color foreColor = dataGridView.Rows[row].Cells[dataGridView.Columns.Count - 1].Style.ForeColor;
                        if (foreColor != Color.Empty)
                        {
                            worksheet.Cells[row + 3, 2].Style.Font.Color.SetColor(foreColor);
                        }
                    }

                    //copy the rest of the data into excel sheet
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView.Columns.Count - 1; col++)
                        {
                            var cellValue = dataGridView.Rows[row].Cells[col].Value;
                            worksheet.Cells[row + 3, col + 3].Value = cellValue;
                            worksheet.Cells[row + 3, col + 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                            // Copy background color
                            Color backColor = dataGridView.Rows[row].Cells[col].Style.BackColor;
                            if (backColor != Color.Empty)
                            {
                                worksheet.Cells[row + 3, col + 3].Style.Fill.PatternType = ExcelFillStyle.Solid;
                                worksheet.Cells[row + 3, col + 3].Style.Fill.BackgroundColor.SetColor(backColor);
                            }

                            // Copy font color
                            Color foreColor = dataGridView.Rows[row].Cells[col].Style.ForeColor;
                            if (foreColor != Color.Empty)
                            {
                                worksheet.Cells[row + 3, col + 3].Style.Font.Color.SetColor(foreColor);
                            }

                            // Copy alignment
                            worksheet.Cells[row + 3, col + 3].Style.HorizontalAlignment =
                                dataGridView.Rows[row].Cells[col].Style.Alignment == DataGridViewContentAlignment.MiddleRight
                                    ? ExcelHorizontalAlignment.Right
                                    : ExcelHorizontalAlignment.Left;
                        }
                    }

                    // Auto-fit columns
                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    worksheet.Column(1).Width = 3.2;
                    worksheet.Column(dataGridView.Columns.Count + 2).Width = 3.2;

                    // Save the Excel file to the specified path
                    FileInfo file = new FileInfo(filePath);
                    package.SaveAs(file);

                    MessageBox.Show("Data exported successfully to: " + filePath, "Export Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public New_Report()
        {
            InitializeComponent();
        }

        private void New_Report_Load(object sender, EventArgs e)
        {
            generateReport.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            generateReport.BackColor = Color.FromArgb(138, 43, 226);

            LoadExcelData(filePath);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Color the first column
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //row.Cells[0].Style.BackColor = Color.MediumPurple;
                row.Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.Cells[0].Style.Font = new System.Drawing.Font("IBM Plex Mono", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }

            // Set the default font for the DataGridView
            dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("IBM Plex Mono", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Center-align the text in the cells
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.EnableHeadersVisualStyles = false; // Allows custom styles to take effect
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSalmon;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("IBM Plex Mono", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            int maxCru = 0, maxOnsite = 0, maxOSATNo = 0;
            float min7DRRR = 9999999, min30DRRR = 9999999, minPPSNR = 9999999, maxOSATScore = 0, maxProd = 0;
            float tempavg, totalCru = 0, totalOnsite = 0, tot30DRRR = 0, tot7DRRR = 0, totProd = 0, totPPSNR = 0, totOSATScore = 0, totOSATNo = 0;
            
            try
            {
                maxCru = CalculateMaxCRU(maxCru);
                maxOnsite = CalculateMaxOnsite(maxOnsite);
                min7DRRR = CalculateMin7DRRR(min7DRRR);
                min30DRRR = CalculateMin30DRRR(min30DRRR);
                minPPSNR = CalculateMinPPSNR(minPPSNR);
                maxOSATNo = CalculateMaxOSATNO(maxOSATNo);
                maxOSATScore = CalculateMaxOSATScore(maxOSATScore);
                maxProd = CalculateProductivity(maxProd);

                int numberOfAgents = dataGridView1.Rows.Count;

                float Temp;
                float Temp_Results, temp_float;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Agents_Results agents = new Agents_Results();

                    //Set Agent Name in Object//
                    agents.set_Agent_Name(Convert.ToString(row.Cells[0].Value));

                    //Calculate results of CRU WO//
                    Temp = Convert.ToInt32(row.Cells[1].Value);
                    Temp_Results = (float)((Temp / maxCru) * 0.05);
                    agents.set_Agent_CRU_Results(Temp_Results);

                    totalCru += Temp;


                    //Calculate results of On-Site WO//
                    Temp = Convert.ToInt32(row.Cells[2].Value);
                    Temp_Results = (float)((Temp / maxOnsite) * 0.05);
                    agents.set_Agent_OnSite_Results(Temp_Results);

                    totalOnsite += Temp;

                    //Calculate results of 7Days RRR//
                    temp_float = (float)Convert.ToDouble(row.Cells[4].Value);
                    Temp_Results = (float)((min7DRRR / temp_float) * 0.2);
                    agents.set_Agent_7DRRR_Results(Temp_Results);

                    tot7DRRR += temp_float;

                    //Calculate results of 30Days RRR//
                    temp_float = (float)Convert.ToDouble(row.Cells[3].Value);
                    Temp_Results = (float)((min30DRRR / temp_float) * 0.2);
                    agents.set_Agent_30DRRR_Results(Temp_Results);

                    tot30DRRR += temp_float;

                    //Calculate results of PPNSR//
                    temp_float = (float)Convert.ToDouble(row.Cells[5].Value);
                    Temp_Results = (float)((minPPSNR / temp_float) * 0.2);
                    agents.set_Agent_PPSNR(Temp_Results);

                    totPPSNR += temp_float;

                    //Calculate results of OSAT no.//
                    Temp = Convert.ToInt32(row.Cells[6].Value);
                    Temp_Results = (float)(Temp / maxOSATNo);
                    agents.set_Agent_OSAT_No_Results(Temp_Results);

                    totOSATNo += Temp;

                    //Calculate results fo OSAT Score//
                    temp_float = (float)Convert.ToDouble(row.Cells[7].Value);
                    Temp_Results = (float)(((temp_float / maxOSATScore) * Temp_Results) * 0.2);
                    agents.set_Agent_OSAT_Score(Temp_Results);

                    totOSATScore += temp_float;

                    //Calculate results for Productivity//
                    temp_float = (float)Convert.ToDouble(row.Cells[8].Value);
                    Temp_Results = (float)((temp_float / maxProd) * 0.1);
                    agents.set_Agent_Productivity(Temp_Results);

                    totProd += temp_float;

                    Agents_Summary.Add(agents);
                }

                Team_Stats team_Stats = new Team_Stats();

                tempavg = calculateAvgerage(totalCru, Agents_Summary.Count - 1);
                team_Stats.avgCru = tempavg;

                tempavg = calculateAvgerage(totalOnsite, Agents_Summary.Count - 1);
                team_Stats.avgOnsite = tempavg;

                tempavg = calculateAvgerage(tot7DRRR, Agents_Summary.Count - 1);
                team_Stats.avg7DRRR = tempavg;

                tempavg = calculateAvgerage(tot30DRRR, Agents_Summary.Count - 1);
                team_Stats.avg30DRRR = tempavg;

                tempavg = calculateAvgerage(totPPSNR, Agents_Summary.Count - 1);
                team_Stats.avgPPSNR = tempavg;

                tempavg = calculateAvgerage(totOSATNo, Agents_Summary.Count - 1);
                team_Stats.avgOSATNo = tempavg;

                tempavg = calculateAvgerage(totOSATScore, Agents_Summary.Count - 1);
                team_Stats.avgOSATScore = tempavg;

                tempavg = calculateAvgerage(totProd, Agents_Summary.Count - 1);
                team_Stats.avgProd = tempavg;


                string Temp_Name;
                float temp_res_CRU, temp_res_Onsite, temp_res_7DRRR, temp_res_30DRRR, temp_res_PPSNR, temp_res_OSATNo, temp_res_OSATScore, temp_res_prod, temp_total;

                for (int i = 0; i < Agents_Summary.Count - 1; i++)
                {
                    Temp_Name = Agents_Summary[i].get_Agent_Name();
                    temp_res_CRU = Agents_Summary[i].get_Agent_CRU_Results();
                    temp_res_Onsite = Agents_Summary[i].get_Agent_OnSite_Results();
                    temp_res_7DRRR = Agents_Summary[i].get_Agent_7DRRR_Results();
                    temp_res_30DRRR = Agents_Summary[i].get_Agent_30DRRR_Results();
                    temp_res_PPSNR = Agents_Summary[i].get_Agent_PPSNR();
                    temp_res_OSATNo = Agents_Summary[i].get_Agent_OSAT_No_Results();
                    temp_res_OSATScore = Agents_Summary[i].get_Agent_OSAT_Score();
                    temp_res_prod = Agents_Summary[i].get_Agent_Productivity();

                    //Calculate Total Results to build ranking//
                    temp_total = temp_res_CRU + temp_res_Onsite + temp_res_7DRRR + temp_res_30DRRR + temp_res_PPSNR + temp_res_OSATScore + temp_res_prod;

                    Agents_Summary[i].set_Agent_Total_Performance(temp_total * 100);
                
                }

                // Assign ranks based on performance
                var rankedAgents = Agents_Summary
                    .OrderByDescending(agent => agent.get_Agent_Total_Performance())
                    .Select((agent, index) => new { agent, Rank = index + 1 })
                    .ToList();

                // Handle ties in rank
                for (int i = 0; i < rankedAgents.Count; i++)
                {
                    if (i > 0 && rankedAgents[i].agent.get_Agent_Total_Performance() == rankedAgents[i - 1].agent.get_Agent_Total_Performance())
                    {
                        rankedAgents[i] = new { rankedAgents[i].agent, Rank = rankedAgents[i - 1].Rank };
                    }
                }

                // Assign the computed ranks back to the agents
                foreach (var item in rankedAgents)
                {
                    item.agent.set_Agent_Rank(item.Rank);
                }

                colorCells(team_Stats.avgCru, "WO Created (CRU)", maxCru, 1);
                colorCells(team_Stats.avgOnsite, "WO Created (Onsite)", maxOnsite, 1);
                colorCells(team_Stats.avg30DRRR, "30 Day RRR", min30DRRR, 2);
                colorCells(team_Stats.avg7DRRR, "7 Day IAP & AFI RRR Flag", min7DRRR, 2);
                colorCells(team_Stats.avgPPSNR, "PPSNR", minPPSNR, 2);
                colorCells(team_Stats.avgOSATNo, "OSAT (No.)", maxOSATNo, 1);
                //colorCells(team_Stats.totalOSATNo, "OSAT (No.)", maxOSATNo, 1);
                colorCells(team_Stats.avgOSATScore, "OSAT (Score)", maxOSATScore, 1);
                colorCells(team_Stats.avgProd, "Productivity", maxProd, 1);


                ColorCellsBasedOnWeight(20, "30 Day RRR",2, team_Stats.avg30DRRR);
                ColorCellsBasedOnWeight(5, "7 Day IAP & AFI RRR Flag",2, team_Stats.avg7DRRR);
                ColorCellsBasedOnWeight(1.5f, "PPSNR",2, team_Stats.avgPPSNR);
                ColorCellsBasedOnWeight(90, "OSAT (Score)",1, team_Stats.avgOSATScore);
                ColorCellsBasedOnWeight(70, "Productivity",1, team_Stats.avgProd);


                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                // Create a new row
                DataRow newRow = dataTable.NewRow();
                newRow["Agents"] = "";
                dataTable.Rows.Add(newRow);

                // Create a new row
                DataRow TeamAvg = dataTable.NewRow();
                TeamAvg["Agents"] = "Team Average";
                dataTable.Rows.Add(TeamAvg);

                // Create a new row
                DataRow TeamTot = dataTable.NewRow();
                TeamTot["Agents"] = "Team Total";
                dataTable.Rows.Add(TeamTot);

                int rowIndex = Agents_Summary.Count; // Example: First row

                DataGridViewRow LastRow = dataGridView1.Rows[rowIndex];
                DataGridViewRow LastRow1 = dataGridView1.Rows[rowIndex + 1];

                LastRow.Cells[1].Value = team_Stats.avgCru;
                LastRow.Cells[2].Value = team_Stats.avgOnsite;
                LastRow.Cells[3].Value = team_Stats.avg30DRRR;
                LastRow.Cells[4].Value = team_Stats.avg7DRRR;
                LastRow.Cells[5].Value = team_Stats.avgPPSNR;
                LastRow.Cells[6].Value = team_Stats.avgOSATNo;
                LastRow.Cells[7].Value = team_Stats.avgOSATScore;
                LastRow.Cells[8].Value = team_Stats.avgProd;

                LastRow1.Cells[1].Value = totalCru;
                LastRow1.Cells[2].Value = totalOnsite;
                LastRow1.Cells[6].Value = totOSATNo;


                //////////////////////////////////////////////////////////

                // Create a new column
                DataGridViewColumn rankings = new DataGridViewColumn
                {
                    HeaderText = "Rankings",
                    Name = "Agents_Ranking",
                    CellTemplate = new DataGridViewTextBoxCell()
                };

                // Add the column to the DataGridView
                dataGridView1.Columns.Add(rankings);

                Set_Results_Score_in_DataGridView(Agents_Summary);

                // Open a SaveFileDialog to select the save location
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Excel File",
                    FileName = "DataGridViewExport.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    ExportDataGridViewToExcel(dataGridView1, filePath);
                }

                Agents_Summary.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please make sure that all cells are filled with correct data", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
