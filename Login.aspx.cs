using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeBcalculadora
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            string emailUsuarioIngresado = txtUsuario.Text.Trim();
            string claveUsuarioIngresada = txtContrasena.Text;

            string emailDB = string.Empty;
            string clave = string.Empty;

            string connectionString = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            
            string query = "SELECT email, clave FROM usuario WHERE email = @Email and Clave = @Clave";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", emailUsuarioIngresado);
                    command.Parameters.AddWithValue("@Clave", claveUsuarioIngresada);

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                emailDB = reader["email"].ToString();
                                clave = reader["clave"].ToString();
                                if (claveUsuarioIngresada == clave)
                                {
                                    Session["UsuarioLogueado"] = emailDB;
                                    Response.Redirect("Calculadora.aspx");
                                }
                                else
                                {
                                    // mensaje de error de contraseña incorrecta
                                }
                            }
                            else
                            {
                               
                            }
                        } 
                    }
                    catch (Exception ex)
                    {
                        // Manejo de errores
                    }
                }
            }
        }
    }
}
