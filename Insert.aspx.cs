using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCrea_Click(object sender, EventArgs e)
        {
            try
            {
                DBConn.conn.Open();
                SqlCommand saveProduct = new SqlCommand(@"INSERT INTO Products (Nome, Descrizione, Image, Prezzo)
                                                             VALUES 
                                                            (@Name, @Description, @Image, @Prezzo)", DBConn.conn);
                                                            saveProduct.Parameters.AddWithValue("@Name", TxtName.Text);
                                                            saveProduct.Parameters.AddWithValue("@Description", TxtDescription.Text);
                                                            saveProduct.Parameters.AddWithValue("@Image", TxtImage.Text);
                if (decimal.TryParse(TxtPrezzo.Text, out decimal prezzo))
                {
                    saveProduct.Parameters.AddWithValue("@Prezzo", prezzo);
                }
                else
                {
                    
                    Response.Write("Prezzo non è un numero valido.");
                    return;
                }

                int affectedRows = saveProduct.ExecuteNonQuery();

                if (affectedRows != 0)
                {
                    Response.Write("Dati inseriti con successo");
                }
            }
            catch ( Exception ex)
            {
                Response.Write("Qualcosa non va: " + ex.Message);
            }
            finally
            {
                DBConn.conn.Close();
            }
        }
    }
}