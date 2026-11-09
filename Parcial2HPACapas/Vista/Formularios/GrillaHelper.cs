using System.Globalization;
using System.Windows.Forms;

namespace Parcial2HPACapas.Vista.Formularios
{
    /// <summary>
    /// Metodos de apoyo para dar formato uniforme a las grillas de pedidos.
    /// </summary>
    internal static class GrillaHelper
    {
        /// <summary>Aplica encabezados y formato a una grilla enlazada a Pedido.</summary>
        public static void FormatearPedidos(DataGridView dgv)
        {
            if (dgv.Columns.Count == 0)
                return;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.Columns["Id"].HeaderText = "N.";
            dgv.Columns["Id"].FillWeight = 20;
            dgv.Columns["Cliente"].HeaderText = "Cliente";
            dgv.Columns["Cliente"].FillWeight = 55;
            dgv.Columns["Fecha"].HeaderText = "Fecha";
            dgv.Columns["Fecha"].FillWeight = 35;
            dgv.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns["Total"].HeaderText = "Total";
            dgv.Columns["Total"].FillWeight = 35;
            dgv.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgv.Columns["Total"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("en-US");
            dgv.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Estado"].HeaderText = "Estado";
            dgv.Columns["Estado"].FillWeight = 35;
        }
    }
}
