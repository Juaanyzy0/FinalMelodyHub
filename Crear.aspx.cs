using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace MelodyHub.instrumentos
{
    public partial class Crear : System.Web.UI.Page
    {
    private String cadenaConexion = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Load_Instrumentos();
            }
        }

        // Método para cargar los instrumentos en el GridView
        private void Load_Instrumentos()
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                string query = "SELECT id_instrumento, tipo_instrumento, marca, modelo FROM instrumento";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexion);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GvInstrumentos.DataSource = dt;
                GvInstrumentos.DataBind();
            }
        }

        // Evento OnClick del botón "Agregar"
        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = txtTipoInstrumento.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;

            if (!string.IsNullOrEmpty(tipo) && !string.IsNullOrEmpty(marca) && !string.IsNullOrEmpty(modelo))
            {
                try
                {
                    using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                    {
                        conexion.Open();
                        string query = "INSERT INTO instrumento (tipo_instrumento, marca, modelo) VALUES (@Tipo, @Marca, @Modelo)";
                        using (MySqlCommand comando = new MySqlCommand(query, conexion))
                        {
                            comando.Parameters.AddWithValue("@Tipo", tipo);
                            comando.Parameters.AddWithValue("@Marca", marca);
                            comando.Parameters.AddWithValue("@Modelo", modelo);
                            comando.ExecuteNonQuery();
                        }
                    }

                    // Recargar los instrumentos y limpiar los campos
                    CargarInstrumentos();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error al agregar el instrumento: {ex.Message}');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor, complete todos los campos.');</script>");
            }
        }

        private void LimpiarCampos()
        {
            txtTipoInstrumento.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtModelo.Text = string.Empty;
        }
    }
}