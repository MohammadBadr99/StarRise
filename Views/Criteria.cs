using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Ranking_Reporter.Views
{
    public partial class Criteria : Form
    {
        string filepath = @"Temporary.xlsx";
        private void removeAndRearrange(string pathOfFile, string name, int index)
        {
            FileInfo fileInfo = new FileInfo(pathOfFile);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; // First worksheet

                int ColumnToDelete = index;

                //int CriteriasColumn = 2;

                int totalColumns = worksheet.Dimension.End.Column;

                // Shift cells Left after deleting
                for (int column = ColumnToDelete; column < totalColumns; column++)
                {
                    worksheet.Cells[1, column].Value = worksheet.Cells[1, column + 1].Value;
                }

                // Clear the last cell
                worksheet.DeleteColumn(totalColumns);

                // Save changes
                package.Save();
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;
            DialogResult result = MessageBox.Show(
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
                removeAndRearrange(filepath, clickedButton.Name, index);
                criteriaFlowPanel.Controls.Clear();
                LoadButtonsFromExcel(filepath);
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
                int columnCount = worksheet.Dimension.Columns;

                for (int column = 3; column <= columnCount; column++)
                {
                    string buttonName = worksheet.Cells[1, column].Text;


                    System.Windows.Forms.Button newButton = new System.Windows.Forms.Button
                    {
                        Text = buttonName,
                        Name = $"btn_{1}",
                        Width = 100,
                        Height = 40,
                        Tag = column,
                        Top = (column - 1) * 50,
                        Left = 10,
                        BackColor = Color.BlueViolet,
                        ForeColor = Color.White,
                    };


                    newButton.Click += Button_Click;

                    criteriaFlowPanel.Controls.Add(newButton);
                    criteriaFlowPanel.AutoScroll = true;
                }
            }
        }
        public Criteria()
        {
            InitializeComponent();
        }

        private void Criteria_Load(object sender, EventArgs e)
        {
            addCriterea.BackColor = Color.FromArgb(138, 43, 226);
            addCriterea.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoadButtonsFromExcel(filepath);
        }

        private void addCriterea_Click(object sender, EventArgs e)
        {
            Add_Criteria add_Criteria = new Add_Criteria();
            add_Criteria.Show();
        }
    }
}
