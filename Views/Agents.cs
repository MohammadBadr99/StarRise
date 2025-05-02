using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

namespace Ranking_Reporter.Views
{
    public partial class Agents : Form
    {
        string filePath = @"Temporary.xlsx";

        private void removeAndRearrange(string pathOfFile, string name,int index)
        {
            FileInfo fileInfo = new FileInfo(pathOfFile);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // First worksheet

                int columnID = 1;
                int columnName = 2;

                int rowToDelete = index;

                int totalRows = worksheet.Dimension.End.Row;

                // Shift cells up after deleting
                for (int row = rowToDelete; row < totalRows; row++)
                {
                    worksheet.Cells[row, columnID].Value = worksheet.Cells[row + 1, columnID].Value;
                    worksheet.Cells[row, columnName].Value = worksheet.Cells[row + 1, columnName].Value;
                }

                // Clear the last cell
                worksheet.DeleteRow(totalRows);

                // Save changes
                package.Save();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            DialogResult result = System.Windows.Forms.MessageBox.Show(
                        "are you sure you want to delete " + clickedButton.Text + "?", // Message
                        "Confirmation",            // Title
                        MessageBoxButtons.YesNo,   // Buttons
                        MessageBoxIcon.Question    // Icon
                        );
            if (result == DialogResult.Yes)
            {
                int index;
                index = (int)clickedButton.Tag;
                //MessageBox.Show("Index is: " + index);
                //agentFlowPanel.Controls.RemoveAt(index);
                removeAndRearrange(filePath, clickedButton.Name,index);
                agentFlowPanel.Controls.Clear();
                LoadButtonsFromExcel(filePath);
                //agentFlowPanel.Refresh();
            }

        }

        private void LoadButtonsFromExcel(string filePath)
        {
            // Enable EPPlus license (required for .NET Core)
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            // Open the Excel file
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // First sheet
                int rowCount = worksheet.Dimension.Rows;

                for (int row = 2; row <= rowCount; row++)
                {
                    string buttonName = worksheet.Cells[row, 2].Text;


                    System.Windows.Forms.Button newButton = new System.Windows.Forms.Button
                    {
                        Text = buttonName,
                        Name = $"btn_{row}",
                        Width = 100,
                        Height = 40,
                        Tag = row,
                        Top = (row - 1) * 50,
                        Left = 10,
                        BackColor = Color.BlueViolet,
                        ForeColor = Color.White,
                    };


                    newButton.Click += Button_Click;

                    agentFlowPanel.Controls.Add(newButton);
                    agentFlowPanel.AutoScroll = true;
                }
            }
        }
        public Agents()
        {
            InitializeComponent();
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            addAgent.BackColor = Color.FromArgb(138, 43, 226);
            addAgent.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoadButtonsFromExcel(filePath);
        }

        private void addAgent_Click(object sender, EventArgs e)
        {
            AddAgent addAgent = new AddAgent();
            addAgent.Show();
        }
    }
}
