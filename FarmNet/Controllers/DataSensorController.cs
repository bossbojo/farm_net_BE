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
    public class DataSensorController : ApiController
    {
        private R_Data_sensor _Data_Sensor = new R_Data_sensor();

        [HttpPost]
        [Route("api/create/data_sensor")]
        public IHttpActionResult CreateDataSensor([FromBody] m_DataSensor request)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = _Data_Sensor.DataSensorCreate(request);
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
        [Route("api/update/data_sensor")]
        public IHttpActionResult UpdateDataSensor([FromBody] m_DataSensor request, int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var res = _Data_Sensor.DataSensorEdit(request, id);
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
        [Route("api/delete/data_sensor")]
        public IHttpActionResult DeleteDataSensor(int id)
        {
            try
            {
                var res = _Data_Sensor.DataSensorRemove(id);
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
