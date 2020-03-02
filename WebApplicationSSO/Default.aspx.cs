using System;
using Microsoft.IdentityModel.Claims;
using System.Threading;
using System.Web;
using System.Linq;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Web.Security;

namespace WebApplicationSSO
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                    var identity = User.Identity as ClaimsIdentity;
                    ClaimsPrincipal claimsPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
            if (claimsPrincipal.Identity.IsAuthenticated)
            {
                //Created a instance of contextDB.  
                using (axiatademodbEntities1 context = new axiatademodbEntities1())
                {
                    var userDetails = context.users.Where(x => x.email == User.Identity.Name).Select(x => new { x.email, x.role, x.username }).ToList();
                    if (userDetails != null)
                    {
                        IList listSource = userDetails;

                        GridView1.DataSource = listSource;
                        GridView1.DataBind();
                    }

                }

                HttpContext.Current.User = claimsPrincipal;
                System.Threading.Thread.CurrentPrincipal = System.Web.HttpContext.Current.User;

                
                    foreach (Claim claim in identity.Claims)
                    {
                        claimType.Text = claim.ClaimType;
                        claimValue.Text = claim.Value;
                        claimValueType.Text = claim.ValueType;
                        claimSubjectName.Text = claim.Subject.Name;
                        claimIssuer.Text = claim.Issuer;
                        //originalIssuer.Text = claim.OriginalIssuer;
                        //properties.Text = claim.Properties.ToString();
                    }

            }
            else
            {
                Microsoft.IdentityModel.Web.FederatedAuthentication.SessionAuthenticationModule.SignOut();
                Microsoft.IdentityModel.Web.FederatedAuthentication.SessionAuthenticationModule.DeleteSessionTokenCookie();
                Microsoft.IdentityModel.Web.FederatedAuthentication.SessionAuthenticationModule.SignOut();
                Response.Redirect("~/AccessDenied.aspx");
            }
          
        }
        protected void lnkbtnlogout_Click(object sender, EventArgs e)
        {
            Microsoft.IdentityModel.Web.FederatedAuthentication.SessionAuthenticationModule.SignOut();
            Microsoft.IdentityModel.Web.FederatedAuthentication.SessionAuthenticationModule.DeleteSessionTokenCookie();
            Microsoft.IdentityModel.Web.FederatedAuthentication.SessionAuthenticationModule.SignOut();

            Response.Redirect("~/Logout.aspx");
        }
    }
}