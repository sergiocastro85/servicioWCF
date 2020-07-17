using Cliente.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Cliente
{
    public partial class Pagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Consultar()
        {
            using ( PersonaClient cliente =new PersonaClient())
            {
                GridView1.DataSource = cliente.Consultar();
                GridView1.DataBind();
                
                //dataGridViewStudents.DataSource = schoolContext.Students.ToList<Student>();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

    }
}