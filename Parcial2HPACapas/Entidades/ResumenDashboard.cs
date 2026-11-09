namespace Parcial2HPACapas.Entidades
{
    /// <summary>
    /// Totales que se muestran en las tarjetas del tablero (dashboard).
    /// La capa de Datos los llena con un unico procedimiento almacenado.
    /// </summary>
    public class ResumenDashboard
    {
        /// <summary>Cantidad de usuarios registrados.</summary>
        public int TotalUsuarios { get; set; }

        /// <summary>Cantidad de clientes.</summary>
        public int TotalClientes { get; set; }

        /// <summary>Cantidad de empleados.</summary>
        public int TotalEmpleados { get; set; }

        /// <summary>Cantidad de proveedores.</summary>
        public int TotalProveedores { get; set; }

        /// <summary>Cantidad de productos.</summary>
        public int TotalProductos { get; set; }

        /// <summary>Cantidad de pedidos.</summary>
        public int TotalPedidos { get; set; }

        /// <summary>Monto total acumulado de todos los pedidos.</summary>
        public decimal MontoTotalPedidos { get; set; }
    }
}
