namespace Ranking_Reporter.Views
{
    partial class AddAgent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.agentName = new System.Windows.Forms.TextBox();
            this.newAgent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter an agent name";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newAgent);
            this.panel2.Controls.Add(this.agentName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // agentName
            // 
            this.agentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.agentName.Location = new System.Drawing.Point(105, 83);
            this.agentName.MinimumSize = new System.Drawing.Size(574, 50);
            this.agentName.Name = "agentName";
            this.agentName.Size = new System.Drawing.Size(574, 50);
            this.agentName.TabIndex = 0;
            // 
            // newAgent
            // 
            this.newAgent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newAgent.Location = new System.Drawing.Point(0, 249);
            this.newAgent.Name = "newAgent";
            this.newAgent.Size = new System.Drawing.Size(800, 101);
            this.newAgent.TabIndex = 1;
            this.newAgent.Text = "Add Agent";
            this.newAgent.UseVisualStyleBackColor = true;
            this.newAgent.Click += new System.EventHandler(this.newAgent_Click);
            // 
            // AddAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddAgent";
            this.Text = "AddAgent";
            this.Load += new System.EventHandler(this.AddAgent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox agentName;
        private System.Windows.Forms.Button newAgent;
    }
}