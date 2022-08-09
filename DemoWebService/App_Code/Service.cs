using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que este servicio Web se llame desde un script, mediante ASP.NET AJAX, quite el comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    public Service () {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    private string cnnString = ConfigurationManager.ConnectionStrings["PubsConnectionString"].ToString();


    [WebMethod]
    public DataTable ObtenerAutor()
    {
        string sql = "SELECT * from Pubs.Tables";
        
        SqlConnection cnn = new SqlConnection(cnnString);
        SqlCommand cmd = new SqlCommand(sql, cnn);
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();

        return ds.Tables["Autor"];
    }
    //public DataTable ObtenerAutor(string autor)
    //{
    //    string sql = "SELECT titles.title, titles.type, titles.price " + 
    //        "FROM titleauthor INNER JOIN titles ON " + 
    //        "titleauthor.title_id = titles.title_id";
    //    if (autor != "0")
    //        sql = sql + " WHERE (titleauthor.au_id = @Autor)";
    //    SqlConnection cnn = new SqlConnection(cnnString);
    //    SqlCommand cmd = new SqlCommand(sql, cnn);
    //    cmd.Parameters.Add("Autor", SqlDbType.VarChar, 11).Value = autor;
    //    SqlDataAdapter adp = new SqlDataAdapter(cmd);
    //    DataSet ds = new DataSet();
    //    adp.Fill(ds, "Autor");
    //    return ds.Tables["Autor"];
    //}
    //Busqueda: 274-80-9391
    //IP Conection: 148.228.23.42
    
}
