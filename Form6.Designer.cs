namespace Final_Project_for_Studio_2
{
    partial class Form6
    {
        private System.Windows.Forms.DataGridView dgvPastOrders;
        private System.Windows.Forms.Button btnBack;

        private void InitializeComponent()
        {
            this.dgvPastOrders = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastOrders)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvPastOrders
            // 
            this.dgvPastOrders.Location = new System.Drawing.Point(12, 12);
            this.dgvPastOrders.Name = "dgvPastOrders";
            this.dgvPastOrders.Size = new System.Drawing.Size(760, 400);
            this.dgvPastOrders.TabIndex = 0;

            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 420);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvPastOrders);
            this.Controls.Add(this.btnBack);
            this.Name = "Form6";
            this.Text = "Past Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastOrders)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
