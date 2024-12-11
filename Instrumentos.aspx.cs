using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace MelodyHub.instrumentos
{
    public partial class Instrumentos : System.Web.UI.Page
    {
        String cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInstrumentos();
            }
        }

        private void LoadInstrumentos()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM instrumento", conexion);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GvInstrumentos.DataSource = dt;
                GvInstrumentos.DataBind();
            }
        }

        protected void GvInstrumentos_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            GvInstrumentos.EditIndex = e.NewEditIndex;
            LoadInstrumentos();
        }

        protected void GvInstrumentos_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            GvInstrumentos.EditIndex = -1;
            LoadInstrumentos();
        }

        protected void GvInstrumentos_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GvInstrumentos.DataKeys[e.RowIndex].Value);
            string tipo = ((TextBox)GvInstrumentos.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string marca = ((TextBox)GvInstrumentos.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string modelo = ((TextBox)GvInstrumentos.Rows[e.RowIndex].Cells[3].Controls[0]).Text;

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                MySqlCommand comando = new MySqlCommand("UPDATE instrumento SET tipo_instrumento=@Tipo, marca=@Marca, modelo=@Modelo WHERE id_instrumento=@Id", conexion);
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Tipo", tipo);
                comando.Parameters.AddWithValue("@Marca", marca);
                comando.Parameters.AddWithValue("@Modelo", modelo);

                conexion.Open();
                comando.ExecuteNonQuery();
            }

            GvInstrumentos.EditIndex = -1;
            LoadInstrumentos();
        }

        protected void GvInstrumentos_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GvInstrumentos.DataKeys[e.RowIndex].Value);

            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                MySqlCommand comando = new MySqlCommand("DELETE FROM instrumento WHERE id_instrumento=@Id", conexion);
                comando.Parameters.AddWithValue("@Id", id);

                conexion.Open();
                comando.ExecuteNonQuery();
            }

            LoadInstrumentos();
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/instrumentos/Crear.aspx");
        }
    }
}