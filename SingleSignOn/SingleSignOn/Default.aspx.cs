using ComponentSpace.SAML2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SingleSignOn
{
    public static class AppSettings
    {
        public const string Attribute = "Attribute";
        public const string PartnerSP = "PartnerSP";
        public const string SubjectName = "SubjectName";
        public const string TargetUrl = "TargetUrl";
    }
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ssoLinkButton_Click(object sender, EventArgs e)
        {
            string partnerSP = WebConfigurationManager.AppSettings[AppSettings.PartnerSP];
            string targetUrl = WebConfigurationManager.AppSettings[AppSettings.TargetUrl];

            string userName = WebConfigurationManager.AppSettings[AppSettings.SubjectName];

            if (string.IsNullOrEmpty(userName))
            {
                userName = User.Identity.Name;
            }

            IDictionary<string, string> attributes = new Dictionary<string, string>();

            foreach (string key in WebConfigurationManager.AppSettings.Keys)
            {
                if (key.StartsWith(AppSettings.Attribute))
                {
                    attributes[key.Substring(AppSettings.Attribute.Length + 1)] = WebConfigurationManager.AppSettings[key];
                }
            }

            SAMLIdentityProvider.InitiateSSO(
                Response,
                userName,
                attributes,
                targetUrl,
                partnerSP);
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            // Logout locally.
            FormsAuthentication.SignOut();

            if (SAMLIdentityProvider.CanSLO())
            {
                // Request logout at the service providers.
                SAMLIdentityProvider.InitiateSLO(Response, null, null);
            }
            else
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }
    }
}