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
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string relativePath = "NinjaVsSamuraiDBA.accdb";
            string fullPath = System.IO.Path.Combine(basePath, relativePath);
            cadena = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={fullPath};";

        }
        public void insertarUsuario(clsPersonaje usuario)    /// me quede aca no puedo conectar la base de datos, para crear personajes
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText =
                    $"INSERT INTO Personajes(NOMBRE, TIPO) VALUES('{usuario.NOMBRE}', '{usuario.TIPO}')";

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

