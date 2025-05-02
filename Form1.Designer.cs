namespace Ranking_Reporter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.NewReport = new System.Windows.Forms.Button();
            this.ReportsHistory = new System.Windows.Forms.Button();
            this.Criteria = new System.Windows.Forms.Button();
            this.Agents = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Indigo;
            this.panelMenu.Controls.Add(this.NewReport);
            this.panelMenu.Controls.Add(this.ReportsHistory);
            this.panelMenu.Controls.Add(this.Criteria);
            this.panelMenu.Controls.Add(this.Agents);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(383, 1272);
            this.panelMenu.TabIndex = 0;
            // 
            // NewReport
            // 
            this.NewReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewReport.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NewReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewReport.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewReport.ForeColor = System.Drawing.SystemColors.Control;
            this.NewReport.Location = new System.Drawing.Point(0, 455);
            this.NewReport.Name = "NewReport";
            this.NewReport.Size = new System.Drawing.Size(383, 106);
            this.NewReport.TabIndex = 4;
            this.NewReport.Text = "New Report";
            this.NewReport.UseVisualStyleBackColor = true;
            this.NewReport.Click += new System.EventHandler(this.NewReport_Click);
            // 
            // ReportsHistory
            // 
            this.ReportsHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportsHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReportsHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReportsHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ReportsHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportsHistory.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportsHistory.ForeColor = System.Drawing.SystemColors.Control;
            this.ReportsHistory.Location = new System.Drawing.Point(0, 349);
            this.ReportsHistory.Name = "ReportsHistory";
            this.ReportsHistory.Size = new System.Drawing.Size(383, 106);
            this.ReportsHistory.TabIndex = 3;
            this.ReportsHistory.Text = "Reports History";
            this.ReportsHistory.UseVisualStyleBackColor = true;
            this.ReportsHistory.Click += new System.EventHandler(this.ReportsHistory_Click);
            // 
            // Criteria
            // 
            this.Criteria.Dock = System.Windows.Forms.DockStyle.Top;
            this.Criteria.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Criteria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Criteria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Criteria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Criteria.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Criteria.ForeColor = System.Drawing.SystemColors.Control;
            this.Criteria.Location = new System.Drawing.Point(0, 243);
            this.Criteria.Name = "Criteria";
            this.Criteria.Size = new System.Drawing.Size(383, 106);
            this.Criteria.TabIndex = 2;
            this.Criteria.Text = "Criteria";
            this.Criteria.UseVisualStyleBackColor = true;
            this.Criteria.Click += new System.EventHandler(this.Criteria_Click);
            // 
            // Agents
            // 
            this.Agents.Dock = System.Windows.Forms.DockStyle.Top;
            this.Agents.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Agents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Agents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Agents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agents.Font = new System.Drawing.Font("IBM Plex Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agents.ForeColor = System.Drawing.SystemColors.Control;
            this.Agents.Location = new System.Drawing.Point(0, 137);
            this.Agents.Name = "Agents";
            this.Agents.Size = new System.Drawing.Size(383, 106);
            this.Agents.TabIndex = 1;
            this.Agents.Text = "Agents";
            this.Agents.UseVisualStyleBackColor = true;
            this.Agents.Click += new System.EventHandler(this.Agents_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 137);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.BlueViolet;
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(383, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1647, 137);
            this.panel3.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("IBM Plex Mono", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(724, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(128, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.MediumPurple;
            this.panelDesktopPane.BackgroundImage = global::Ranking_Reporter.Properties.Resources.computer_12788555;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(383, 137);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1647, 1135);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("IBM Plex Mono", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Ranking_Reporter.Properties.Resources.C3;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(383, 137);
            this.button1.TabIndex = 0;
            this.button1.Text = "E-ticketing";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2030, 1272);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "StarRise";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Agents;
        private System.Windows.Forms.Button NewReport;
        private System.Windows.Forms.Button ReportsHistory;
        private System.Windows.Forms.Button Criteria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button button1;
    }
}

