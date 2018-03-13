using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using FarmNet.Entity;

namespace FarmNet.Authen
{
    public class JWTAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {

            string token = HttpContext.Current.Request.Headers["Authorization"];
            if (token != null)
            {
                try
                {
                    Authentication decodeToken = Securities.JWTDecode<Authentication>(token);
                    if (Authentication.HasToken(decodeToken))
                    {
                        var users = new FarmDB().v_User.Where(c => c.username.Equals(decodeToken.username)).FirstOrDefault();
                        if (users != null)
                        {
                            Authentication.SetAuthenticated(users);
                            return;
                        }
                    }
                    else
                    {
                        Authentication.SetAuthenticated(username: null, firstname: null, lastname: null, status:null,serial_number:null);
                    }
                }
                catch
                { }
            }
            base.OnAuthorization(actionContext);
        }
    }
}