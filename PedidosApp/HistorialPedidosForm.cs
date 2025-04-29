using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class HistorialPedidosForm : Form
    {
        private List<Pedido> pedidos;

        public HistorialPedidosForm()
        {
            InitializeComponent();
            pedidos = RegistroPedido.ObtenerPedidos();
            comboBoxFiltro.Items.Add("Todos");
            comboBoxFiltro.Items.AddRange(pedidos.Select(p => p.MetodoEntrega).Distinct().ToArray());
            comboBoxFiltro.SelectedIndex = 0;
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            string filtro = comboBoxFiltro.SelectedItem.ToString();
            var filtrados = filtro == "Todos" ? pedidos : pedidos.Where(p => p.MetodoEntrega == filtro).ToList();
            dataGridViewPedidos.DataSource = null;
            dataGridViewPedidos.DataSource = filtrados;
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
