using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Cappas
using BLL;
using DAL;

namespace CrudUbicaciones_LGLA
{
    public partial class frmUbicaciones : System.Web.UI.Page
    {
        ubicaciones_BLL oUbicacionesBLL;
        ubicacionesDAL oUbicacionesDAL;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarUbicaciones();
            }
        }
        
        //Metodo encargado de listar los datos de la BD en un GRIDView
        public void ListarUbicaciones ()
        {
            oUbicacionesDAL = new ubicacionesDAL();
            gvUbicaciones.DataSource = oUbicacionesDAL.Listar();
            gvUbicaciones.DataBind();
        }

        protected void gvUbicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}