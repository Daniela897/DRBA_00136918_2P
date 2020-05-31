using System;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorPedido
    {
        // Eliminar variable exe declarada pero jamas usada 
        public static DataTable GetPedidosUsuarioTable(string id)
        {
            DataTable pedidos = null;

            try
            {
                pedidos = ConexionBD.EjecutarConsulta(string.Format("SELECT p.idPedido, i.nombreArticulo, p.cantidad, i.precio, (i.precio * p.cantidad) AS total" +
                                                                    " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                                                    " WHERE p.idArticulo = i.idArticulo" + " AND p.idUsuario = u.idUsuario{0}",
                    string.Format(" AND u.idUsuario = {0}", id)));
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }
        // Eliminar variable exe declarada pero jamas usada 

        public static DataTable GetPedidosTable()
        {
            DataTable pedidos = null;

            try
            {
                pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArticulo, p.cantidad, i.precio, (i.precio * p.cantidad) AS total" +
                                            " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                            " WHERE p.idArticulo = i.idArticulo" +
                                            " AND p.idUsuario = u.idUsuario");
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }
// Eliminar variable exe declarada pero jamas usada 
        public static void HacerPedido(string idUsuario, string idArticulo, string cantidad)
        {
            try
            {
                ConexionBD.EjecutarComando(string.Format("INSERT INTO PEDIDO(idUsuario, idArticulo, cantidad) {0}",
                    string.Format("VALUES({0}, {1}, {2})", idUsuario, idArticulo, cantidad)));
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
