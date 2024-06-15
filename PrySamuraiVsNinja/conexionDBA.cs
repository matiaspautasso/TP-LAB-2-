using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace PrySamuraiVsNinja
{
    internal class conexionDBA
    {

        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;
        public conexionDBA()
        {
            cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NinjaVsSamuraiDBA.accdb";
        }

        public bool UsuarioExiste(string nombre)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT COUNT(*) FROM Personajes WHERE NOMBRE = '{nombre}'";
                conexion.Open();
                int count = (int)comando.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }







        public void insertarUsuario(clsPersonaje usuario)
        {

            if (UsuarioExiste(usuario.NOMBRE))
            {
                MessageBox.Show("El usuario ingresado ya existe.");
                return;

            }

            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Personajes(NOMBRE, TIPO) VALUES ('{usuario.NOMBRE}','{usuario.TIPO}')";

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void ActualizarVictorias(int personajeId)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"UPDATE Personajes SET VICTORIAS = VICTORIAS + 1 WHERE ID = {personajeId}"; //corregir

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void ActualizarDerrotas(int personajeId)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"UPDATE Personajes SET DERROTA = DERROTA + 1 WHERE ID = {personajeId}"; //corregir

                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

