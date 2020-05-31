using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorInventario
    {
        // Eliminar variable exe declarada pero jamas usada 
        // Metodo encargado de devolver un DataTable con todos los elementos del inventario
        public static DataTable GetProductosTable()
        {
            DataTable productos = null;

            // Solamente la consulta y conexion a la BD van en el try, ya que lo demas no puede ocasionar excepcion
            try
            {
                productos = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Eliminar variable exe declarada pero jamas usada 
        // Metodo que devuelve los productos en formato de List
        public static List<Inventario> GetProductos()
        {
            // Declaracion de lista y DataTable
            var productos = new List<Inventario>();
            DataTable dt = null;

            try
            {
                // Consulta para llenar el DataTable
                dt = ConexionBD.EjecutarConsulta("SELECT * FROM INVENTARIO");

                // Por cada fila del DataTable, crear un nuevo usuario anadiendolo a la lista
                foreach(DataRow dr in dt.Rows)
                {
                    productos.Add(new Inventario
                        (
                            dr[0].ToString(),
                            dr[1].ToString(),
                            dr[2].ToString(),
                            dr[3].ToString(),
                            dr[4].ToString()
                        )
                    );
                }
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo para anadir productos
        public static void AnadirProducto(string nombre, string descripcion, string precio, string stock)
        {
            try
            {
                ConexionBD.EjecutarComando(string.Format("INSERT INTO INVENTARIO(nombreArticulo, descripcion, precio, stock){0}",
                    string.Format(" VALUES('{0}', '{1}', {2}, {3})", nombre, descripcion, precio, stock)));

                MessageBox.Show("Se ha agregado el producto");
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
// Eliminar variable exe declarada pero jamas usada 
        // Metodo para eliminar productos
        public static void EliminarProducto(string id)
        {
            try
            {
                ConexionBD.EjecutarComando(string.Format("DELETE FROM INVENTARIO WHERE idArticulo = {0}", id));

                MessageBox.Show("Se ha eliminado el producto");
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
// Eliminar variable exe declarada pero jamas usada 
        // Metodo para actualizar stock de un producto
        public static void ActualizarProducto(string id, string stock)
        {
            try
            {
                ConexionBD.EjecutarComando(string.Format("UPDATE INVENTARIO SET stock = {0} WHERE idArticulo = {1}",
                    stock, id));

                MessageBox.Show("Se ha actualizado el producto");
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
