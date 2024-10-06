using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    public class ubicacionesDAL
    {
        SQLDBHelper oConexion;
        //Inicializar la conexion con la BD (Constructor)
        public ubicacionesDAL() 
        {
            oConexion = new SQLDBHelper();
        }
        public void Agregar () { }
        public void Eliminar () { }
        public void Modificar () { }
        //Seleccionar los registros de la tabla mediante un SELECT
        public DataTable Listar () 
        {
            SqlCommand cmdComando = new SqlCommand();
            //Sentencia SQL para traer todos los registros de la tabla "Direcciones"
            cmdComando.CommandText = "SELECT * FROM Direcciones";
            //Tipo de comando, ya sea: texto, SP, etc.
            cmdComando.CommandType = CommandType.Text;

            DataTable TablaResultante = oConexion.EjecutarSentenciaSQL(cmdComando);

            return TablaResultante;
        }
    }
}
