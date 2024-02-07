namespace TiyatroOtomasyonu
{
    partial class SatisListe
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.full_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gosteri_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chair_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.full_name,
            this.gosteri_name,
            this.room_name,
            this.ticket_date,
            this.time,
            this.chair_no,
            this.cash});
            this.dataGridView1.Location = new System.Drawing.Point(12, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(997, 459);
            this.dataGridView1.TabIndex = 13;
            // 
            // full_name
            // 
            this.full_name.HeaderText = "Müşteri Tam Ad";
            this.full_name.MinimumWidth = 6;
            this.full_name.Name = "full_name";
            this.full_name.ReadOnly = true;
            // 
            // gosteri_name
            // 
            this.gosteri_name.HeaderText = "Gösteri Adı";
            this.gosteri_name.MinimumWidth = 6;
            this.gosteri_name.Name = "gosteri_name";
            this.gosteri_name.ReadOnly = true;
            // 
            // room_name
            // 
            this.room_name.HeaderText = "Salon Adı";
            this.room_name.MinimumWidth = 6;
            this.room_name.Name = "room_name";
            this.room_name.ReadOnly = true;
            // 
            // ticket_date
            // 
            this.ticket_date.HeaderText = "Bilet Tarihi";
            this.ticket_date.MinimumWidth = 6;
            this.ticket_date.Name = "ticket_date";
            this.ticket_date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Seans Saati";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // chair_no
            // 
            this.chair_no.HeaderText = "Koltuk No";
            this.chair_no.MinimumWidth = 6;
            this.chair_no.Name = "chair_no";
            this.chair_no.ReadOnly = true;
            // 
            // cash
            // 
            this.cash.HeaderText = "Ödenen Ücret";
            this.cash.MinimumWidth = 6;
            this.cash.Name = "cash";
            this.cash.ReadOnly = true;
            // 
            // SatisListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 483);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatisListe";
            this.Text = "Satış Geçmişi";
            this.Load += new System.EventHandler(this.SatisListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn full_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gosteri_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn chair_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cash;
    }
}