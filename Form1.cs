using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ranking_Reporter
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private Button currentButton;
        public Form1()
        {
            InitializeComponent();
        }

        private void activateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color col = Color.FromArgb(128, 128, 255);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = col;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control prevButton in panelMenu.Controls)
            {
                if(prevButton.GetType() == typeof(Button))
                {
                    prevButton.BackColor = Color.FromArgb(75, 0, 130);
                    prevButton.ForeColor = Color.White;
                    prevButton.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void openChildForm(Form childForm, Object sender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Name;
        }

        private void Agents_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.Agents(), sender);
        }

        private void Criteria_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.Criteria(), sender);
        }

        private void ReportsHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.Reports_History(), sender);
        }

        private void NewReport_Click(object sender, EventArgs e)
        {
            openChildForm(new Views.New_Report(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form1(), sender);
        }
    }
}
