namespace Ranking_Reporter.Views
{
    partial class Agents
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
            this.updatePanel = new System.Windows.Forms.Panel();
            this.addAgent = new System.Windows.Forms.Button();
            this.agentFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // updatePanel
            // 
            this.updatePanel.Controls.Add(this.addAgent);
            this.updatePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatePanel.Location = new System.Drawing.Point(0, 920);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(1478, 166);
            this.updatePanel.TabIndex = 1;
            // 
            // addAgent
            // 
            this.addAgent.Dock = System.Windows.Forms.DockStyle.Right;
            this.addAgent.Location = new System.Drawing.Point(1081, 0);
            this.addAgent.Name = "addAgent";
            this.addAgent.Size = new System.Drawing.Size(397, 166);
            this.addAgent.TabIndex = 0;
            this.addAgent.Text = "Add Agent";
            this.addAgent.UseVisualStyleBackColor = true;
            this.addAgent.Click += new System.EventHandler(this.addAgent_Click);
            // 
            // agentFlowPanel
            // 
            this.agentFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.agentFlowPanel.Name = "agentFlowPanel";
            this.agentFlowPanel.Size = new System.Drawing.Size(1478, 920);
            this.agentFlowPanel.TabIndex = 2;
            // 
            // Agents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1086);
            this.Controls.Add(this.agentFlowPanel);
            this.Controls.Add(this.updatePanel);
            this.Name = "Agents";
            this.Text = "Agents";
            this.Load += new System.EventHandler(this.Agents_Load);
            this.updatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Button addAgent;
        private System.Windows.Forms.FlowLayoutPanel agentFlowPanel;
    }
}