namespace Blood_Bank.UI
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
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewBloodBags = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodBags)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label10.Location = new System.Drawing.Point(265, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(258, 67);
            this.label10.TabIndex = 6;
            this.label10.Text = "BloodBag";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridViewBloodBags
            // 
            this.dataGridViewBloodBags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloodBags.Location = new System.Drawing.Point(0, 114);
            this.dataGridViewBloodBags.Name = "dataGridViewBloodBags";
            this.dataGridViewBloodBags.RowHeadersWidth = 51;
            this.dataGridViewBloodBags.RowTemplate.Height = 24;
            this.dataGridViewBloodBags.Size = new System.Drawing.Size(805, 337);
            this.dataGridViewBloodBags.TabIndex = 7;
            this.dataGridViewBloodBags.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBloodBags_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 109);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewBloodBags);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodBags)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewBloodBags;
        private System.Windows.Forms.Panel panel1;
    }
}