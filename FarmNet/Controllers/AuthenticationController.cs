using FarmNet.Authen;
using FarmNet.Models;
using FarmNet.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FarmNet.Controllers
{
    public class AuthenticationController : ApiController
    {
        private R_Authentication Auth = new R_Authentication();
        private R_Users _Users = new R_Users();
        [JWTAuthorize]
        [Route("api/Authentication")]
        public IHttpActionResult GetAuthen()
        {
            var user = Authentication.User;
            return Json(new
            {
                Token = Authentication.Token,
                Detail = _Users.GetUsers(user.user_id)
            });
        }
        [JWTAuthorize]
        [Route("api/get/users")]
        public IHttpActionResult GetUser(int Id)
        {
            try
            {
                var res = _Users.GetUsers(Id);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get user.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/signin")]
        public IHttpActionResult SignIn([FromBody] m_SignIn request)
        {
            if (ModelState.IsValid)
            {
                if (Auth.checkHaveUser(request.username))
                {
                    if (Auth.checkActive(request.username))
                    {
                        var user = Auth.Auth(request.username, request.password);
                        if (user != null)
                        {
                            var authen = Authentication.SetAuthenticated(user);
                            var res = Json(new
                            {
                                Token = authen,
                                Detail = user
                            });
                            return res;
                        }
                        return BadRequest("Password incorrect.");
                    }
                    return BadRequest("this username not active.");
                }
                return BadRequest("Not found this username.");
            }
            return BadRequest("Model is incorrect.");
        }
        [HttpPost]
        [Route("api/signup")]
        public IHttpActionResult SignUp([FromBody]m_Users request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (!Auth.checkHaveSerialNumber(request.serial_number))
                    {
                        if (!Auth.checkHaveUser(request.username))
                        {
                            var qry = _Users.UserCreate(request);
                            if (qry != null)
                            {
                                return Json(qry);
                            }
                            return BadRequest("Create user failed.");
                        }
                        return BadRequest("have username in system.");
                    }
                    return BadRequest("have serial number in system.");

                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Model is incorrect.");
        }
        [HttpPut]
        [Route("api/edit/profile")]
        public IHttpActionResult EditPrifile([FromBody]m_Users_Profile request, int Id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var qry = _Users.UserEditProfile(request, Id);
                    if (qry != null)
                    {
                        return Json(qry);
                    }
                    return BadRequest("Create user failed.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Model is incorrect.");
        }
        [HttpPut]
        [Route("api/edit/password")]
        public IHttpActionResult EditPassword([FromBody]m_Users_Password request, int Id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_Users.Checkpassword(request.old_password))
                    {
                        var qry = _Users.UserEditPassword(request, Id);
                        if (qry != null)
                        {
                            return Json(qry);
                        }
                        return BadRequest("Create user failed.");
                    }
                    else
                    {
                        return BadRequest("Old password incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Model is incorrect.");
        }
    }

}
