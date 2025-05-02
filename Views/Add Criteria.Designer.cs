namespace Ranking_Reporter.Views
{
    partial class Add_Criteria
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criteriaWeight = new System.Windows.Forms.TextBox();
            this.newCriteria = new System.Windows.Forms.Button();
            this.criteriaName = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a criteria name and weight";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.criteriaWeight);
            this.panel2.Controls.Add(this.newCriteria);
            this.panel2.Controls.Add(this.criteriaName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 484);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Weight";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // criteriaWeight
            // 
            this.criteriaWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criteriaWeight.Location = new System.Drawing.Point(174, 224);
            this.criteriaWeight.MinimumSize = new System.Drawing.Size(574, 50);
            this.criteriaWeight.Name = "criteriaWeight";
            this.criteriaWeight.Size = new System.Drawing.Size(574, 31);
            this.criteriaWeight.TabIndex = 2;
            // 
            // newCriteria
            // 
            this.newCriteria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newCriteria.Location = new System.Drawing.Point(0, 383);
            this.newCriteria.Name = "newCriteria";
            this.newCriteria.Size = new System.Drawing.Size(890, 101);
            this.newCriteria.TabIndex = 1;
            this.newCriteria.Text = "Add Criteria";
            this.newCriteria.UseVisualStyleBackColor = true;
            this.newCriteria.Click += new System.EventHandler(this.newCriteria_Click_1);
            // 
            // criteriaName
            // 
            this.criteriaName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.criteriaName.Location = new System.Drawing.Point(174, 83);
            this.criteriaName.MinimumSize = new System.Drawing.Size(574, 50);
            this.criteriaName.Name = "criteriaName";
            this.criteriaName.Size = new System.Drawing.Size(574, 31);
            this.criteriaName.TabIndex = 0;
            // 
            // Add_Criteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Criteria";
            this.Text = "Add_Criteria";
            this.Load += new System.EventHandler(this.Add_Criteria_Load);
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
        private System.Windows.Forms.TextBox criteriaWeight;
        private System.Windows.Forms.Button newCriteria;
        private System.Windows.Forms.TextBox criteriaName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}