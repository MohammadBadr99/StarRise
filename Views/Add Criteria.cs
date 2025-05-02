using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace Ranking_Reporter.Views
{
    public partial class Add_Criteria : Form
    {
        public Add_Criteria()
        {
            InitializeComponent();
        }

        private void Add_Criteria_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            criteriaName.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            criteriaWeight.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newCriteria.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newCriteria.BackColor = Color.FromArgb(138, 43, 226);
        }

        private void newCriteria_Click_1(object sender, EventArgs e)
        {
            if (criteriaName.Text != "" && criteriaWeight.Text != "")
            {
                // Path to save the Excel file
                string filePath = @"Temporary.xlsx";

                // Enable EPPlus license (required for .NET Core)
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                // Open the Excel file
                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    // Get the first worksheet
                    var worksheet = package.Workbook.Worksheets[0];

                    // Find the last used row in the first column
                    int lastColumn = worksheet.Dimension?.Columns ?? 0;

                    // Add a new name and ID after the last row
                    string newCriteria = criteriaName.Text;
                    string newWeight = criteriaWeight.Text; // Assign a unique ID based on the row number
                    worksheet.Cells[1, lastColumn + 1].Value = newCriteria + " - " + newWeight;

                    // Save the changes
                    package.Save();

                    MessageBox.Show("Criteria is added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Criteria Name or Weight can not be empty!");
            }
        }
    }
}
