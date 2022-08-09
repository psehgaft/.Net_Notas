using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    System.Collections.Generic.List<Empleado> Datos = new System.Collections.Generic.List<Empleado>();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox1.Text = "Text 1";
            TextBox1.BackColor = System.Drawing.Color.Red;
            TextBox2.Text = "Text 2";
            TextBox2.BackColor = System.Drawing.Color.Green;

            Datos.Add(new Empleado("Edgar"));
            Datos.Add(new Empleado("Juan"));
            Datos.Add(new Empleado("Jose"));
            Datos.Add(new Empleado("Manuel"));
            Datos.Add(new Empleado("Victor"));

            GridView1.DataSource = Datos;
            GridView2.DataSource = Datos;
            DataBind();
        }
        else
        {
            Datos.Add(new Empleado("Enrique"));
            Datos.Add(new Empleado("Daniel"));
            GridView1.DataSource = Datos;
            GridView2.DataSource = Datos;
            DataBind();
            TextBox1.Text = Datos.Count.ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    }
}

class Empleado
{
    public string nombre { get; set; }

    public Empleado(string nombre)
    {
        this.nombre = nombre;
    }
}