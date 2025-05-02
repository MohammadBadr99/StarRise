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
    public partial class AddAgent : Form
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        private void AddAgent_Load(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            agentName.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newAgent.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newAgent.BackColor = Color.FromArgb(138, 43, 226);
        }

        private void newAgent_Click(object sender, EventArgs e)
        {
            if(agentName.Text != "")
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
                    int lastRow = worksheet.Dimension?.Rows ?? 0;

                    // Add a new name and ID after the last row
                    string newName = agentName.Text;
                    int newID = lastRow; // Assign a unique ID based on the row number
                    worksheet.Cells[lastRow + 1, 2].Value = newName; // Add name in Column A
                    worksheet.Cells[lastRow + 1, 1].Value = newID;   // Add ID in Column B

                    // Save the changes
                    package.Save();

                    MessageBox.Show("Agent is added successfully!");
                }
            }
            else
            {
                MessageBox.Show("Agent Name can not be empty!");
            }
        }
    }
}
