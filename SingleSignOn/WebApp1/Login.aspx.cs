using ComponentSpace.SAML2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ssoLinkButton_Click(object sender, EventArgs e)
        {
            // Remember the return URL.
            string returnUrl = Request.QueryString["ReturnUrl"];

            // To login at the service provider, initiate single sign-on to the identity provider (SP-initiated SSO).
            string partnerIdP = WebConfigurationManager.AppSettings[AppSettings.PartnerIdP];

            SAMLServiceProvider.InitiateSSO(Response, returnUrl, partnerIdP);
        }
    }
}