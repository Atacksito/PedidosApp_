namespace PedidosApp
{
    partial class HistorialPedidosForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewPedidos;
        private System.Windows.Forms.ComboBox comboBoxFiltro;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewPedidos = new System.Windows.Forms.DataGridView();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).BeginInit();
            this.SuspendLayout();

            // comboBoxFiltro
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(12, 12);
            this.comboBoxFiltro.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);

            // dataGridViewPedidos
            this.dataGridViewPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPedidos.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewPedidos.Size = new System.Drawing.Size(560, 300);
            this.dataGridViewPedidos.Name = "dataGridViewPedidos";

            // HistorialPedidosForm
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.dataGridViewPedidos);
            this.Name = "HistorialPedidosForm";
            this.Text = "Historial de Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPedidos)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
