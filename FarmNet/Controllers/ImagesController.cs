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
    public class ImagesController : ApiController
    {
        private R_Image _Image = new R_Image();
        [HttpPost]
        [Route("api/create/image")]
        public IHttpActionResult CreateSensorSoil([FromBody] m_Images request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = _Image.ImagesCreate(request);
                    if (res != null)
                    {
                        return Json(res);
                    }
                    return BadRequest("Create image failed.");
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
