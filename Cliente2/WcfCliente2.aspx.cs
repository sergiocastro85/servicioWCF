using Cliente2.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cliente2
{
    public partial class WcfCliente2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Consulta()
        {
            using (PersonaClient cliente = new PersonaClient())
            {
                GridView1.DataSource = cliente.Consultar();
                GridView1.DataBind();
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Consulta();
        }
    }
}