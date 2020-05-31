using System.Data;
using System.Collections.Generic;
using Preparcial.Modelo;
using System;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorUsuario
    {
        public static List<Usuario> GetUsuarios()
        {
            var usuarios = new List<Usuario>();
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            foreach(DataRow dr in tableUsuarios.Rows)
            {
                usuarios.Add(new Usuario
                    (
                        dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        Convert.ToBoolean(dr[3].ToString())
                    )
                );
            }

            return usuarios;
        }
// Eliminar variable exe declarada pero jamas usada 
        public static DataTable GetUsuariosTable()
        {
            DataTable tableUsuarios = null;

            try
            {
                tableUsuarios = ConexionBD.EjecutarConsulta("SELECT * FROM USUARIO");
            }
            catch 
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }
// Eliminar variable exe declarada pero jamas usada 
        public static void ActualizarContrasena(string idUsuario, string nueva)
        {
            try
            {
                ConexionBD.EjecutarComando(string.Format("UPDATE USUARIO SET contrasenia = '{0}' ", nueva) +
                                           string.Format("WHERE idUsuario = {0}", idUsuario));

                MessageBox.Show("Se ha actualizado la contrasena");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
// Eliminar variable exe declarada pero jamas usada 
        public static void CrearUsuario(string usuario)
        {
            try
            {
                ConexionBD.EjecutarComando("INSERT INTO USUARIO(nombreUsuario, contrasenia, tipo)" +
                                           string.Format(" VALUES('{0}', '{1}', false)", usuario, usuario));

                MessageBox.Show("Se ha agregado el nuevo usuario, contrasenia igual al nombre");
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
