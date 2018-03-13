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
    public class SensorSoilController : ApiController
    {
        private R_Sensor_soil _SensorSoil = new R_Sensor_soil();
        [HttpPost]
        [Route("api/create/sensor_soil")]
        public IHttpActionResult CreateSensorSoil([FromBody] m_SensorSoil request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = _SensorSoil.SensorSoilCreate(request);
                    if (res != null)
                    {
                        return Json(res);
                    }
                    return BadRequest("Create data sensor failed.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Model is incorrect.");
        }
        [HttpPut]
        [Route("api/update/sensor_soil")]
        public IHttpActionResult UpdateSensorSoil([FromBody] m_SensorSoil request, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = _SensorSoil.SensorSoilEdit(request, id);
                    if (res != null)
                    {
                        return Json(res);
                    }
                    return BadRequest("Update data sensor failed.");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Model is incorrect.");
        }
        [HttpDelete]
        [Route("api/delete/sensor_soil")]
        public IHttpActionResult DeleteSensorSoil(int id)
        {
            try
            {
                var res = _SensorSoil.SensorSoilRemove(id);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("Delete data sensor failed.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
