namespace Blood_Bank.UI
{
    partial class BloodBag
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
            this.dataGridViewBloodBags = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodBags)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 118);
            this.panel1.TabIndex = 8;
            // 
            // BloodBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewBloodBags);
            this.Name = "BloodBag";
            this.Text = "BloodBag";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodBags)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewBloodBags;
        private System.Windows.Forms.Panel panel1;
    }
}