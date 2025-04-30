using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PedidosApp;     

namespace PedidosApp
{
    public partial class HistorialPedidosForm : Form
    {
        private List<Pedido> pedidos;
        private BindingSource bindingSource;

        public HistorialPedidosForm()
        {
            InitializeComponent();
            pedidos = RegistroPedidos.Instancia.Pedidos ?? new List<Pedido>();
            bindingSource = new BindingSource();

            comboBoxFiltro.Items.Add("Todos");
            comboBoxFiltro.Items.AddRange(pedidos.Select(p => p.MetodoEntrega.TipoEntrega()).Distinct().ToArray());
            comboBoxFiltro.SelectedIndex = 0;

            bindingSource.DataSource = pedidos;
            dataGridViewPedidos.DataSource = bindingSource;

            ActualizarGrid();
        }


        public static class PedidoService
        {
            public static List<Pedido> FiltrarPedidos(List<Pedido> pedidos, string filtro)
            {
                return filtro == "Todos"
                    ? pedidos
                    : pedidos.Where(p => p.MetodoEntrega.TipoEntrega() == filtro).ToList();
            }
        }

        private void ActualizarGrid()
        {
            try
            {
                string filtro = comboBoxFiltro.SelectedItem?.ToString() ?? "Todos";
                bindingSource.DataSource = PedidoService.FiltrarPedidos(pedidos, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al actualizar la tabla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarGrid();
        }
    }
}
