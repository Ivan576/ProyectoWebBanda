using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SpotifyAPI.Web;

namespace ProyectoWebBanda.CapaUsuarios
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var loginRequest = new LoginRequest(
              new Uri("https://localhost:44351/CapaUsuarios/MainMenu.aspx"),
              "95ba2f43865246a4a089a362087242c9",
              LoginRequest.ResponseType.Token
            )
            {
                Scope = new[] { Scopes.PlaylistReadPrivate, Scopes.PlaylistReadCollaborative }
            };
            var uri = loginRequest.ToUri();
            Response.Redirect(uri.ToString(), false);
        }
    }
}