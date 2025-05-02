namespace Ranking_Reporter.Views
{
    partial class Criteria
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
            this.addCriterea = new System.Windows.Forms.Button();
            this.criteriaFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addCriterea
            // 
            this.addCriterea.Dock = System.Windows.Forms.DockStyle.Right;
            this.addCriterea.Location = new System.Drawing.Point(1094, 0);
            this.addCriterea.Name = "addCriterea";
            this.addCriterea.Size = new System.Drawing.Size(397, 166);
            this.addCriterea.TabIndex = 0;
            this.addCriterea.Text = "Add Criteria";
            this.addCriterea.UseVisualStyleBackColor = true;
            this.addCriterea.Click += new System.EventHandler(this.addCriterea_Click);
            // 
            // criteriaFlowPanel
            // 
            this.criteriaFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criteriaFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.criteriaFlowPanel.Name = "criteriaFlowPanel";
            this.criteriaFlowPanel.Size = new System.Drawing.Size(1491, 905);
            this.criteriaFlowPanel.TabIndex = 4;
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.addCriterea);
            this.updatePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatePanel.Location = new System.Drawing.Point(0, 905);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(1491, 166);
            this.updatePanel.TabIndex = 3;
            // 
            // Criteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 1071);
            this.Controls.Add(this.criteriaFlowPanel);
            this.Controls.Add(this.updatePanel);
            this.Name = "Criteria";
            this.Text = "Criteria";
            this.Load += new System.EventHandler(this.Criteria_Load);
            this.updatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCriterea;
        private System.Windows.Forms.FlowLayoutPanel criteriaFlowPanel;
        private System.Windows.Forms.Panel updatePanel;
    }
}