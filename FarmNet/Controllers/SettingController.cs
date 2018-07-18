using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FarmNet.Respositories;
using FarmNet.Models;
using FarmNet.Authen;

namespace FarmNet.Controllers
{
    public class SettingController : ApiController
    {
        private R_Setting _Setting = new R_Setting();

        [HttpGet]
        [Route("api/get/setting")]
        public IHttpActionResult GetSetting(string serial_number)
        {
            try
            {
                var res = _Setting.GetSetting(serial_number);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("Update image failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [JWTAuthorize]
        [HttpPut]
        [Route("api/update/setting")]
        public IHttpActionResult UpdateSetting([FromBody] m_Setting request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = Authentication.User;
                    var res = _Setting.SettingEdit(request,user.user_id);
                    if (res != null)
                    {
                        return Json(res);
                    }
                    return BadRequest("Update image failed.");
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
