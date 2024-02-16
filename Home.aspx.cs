using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecommerce
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                DBConn.conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Products", DBConn.conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                string content = "";

                if(dataReader.HasRows)
                {
                    while(dataReader.Read())
                    {
                        content += $@"<div class=""card col-6 col-sm-4 col-md-3"">
                                         <img src=""{dataReader["Image"]}"" class=""card-img-top"" alt=""{dataReader["Nome"]}"">
                                            <div class=""card-body"">
                                            <h5 class=""card-title"">{dataReader["Nome"]}</h5>
                                            <p class=""card-text"">{dataReader["Descrizione"]}</p>
                                            <p class=""card-text"">{dataReader["Prezzo"]}</p>
                                            <a href=""Dettaglio.aspx?product={dataReader["ID"]}"" class=""btn btn-primary"">Dettagli</a>
                                            </div>
                                            </div>";


                    }
                }

                dataReader.Close();
                contentHtml.InnerHtml = content;


            }
            catch(Exception ex) 
            {
                Response.Write(ex.ToString());
            }
            finally
            {
                if(DBConn.conn.State == ConnectionState.Open)
                {
                    DBConn.conn.Close();
                }
                
            }
        }
    }
}