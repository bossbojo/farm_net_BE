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
    public class NewApiController : ApiController
    {
        private R_NewRep _Rep = new R_NewRep();
        private R_Create_sensor _Create_Sensor = new R_Create_sensor();
        [JWTAuthorize]
        [HttpPost]
        [Route("api/create/mysensor")]
        public IHttpActionResult Create_MySensor([FromBody] m_CreateSensor request)
        {
            try
            {
                var user = Authentication.User;
                var res = _Create_Sensor.CreateSensor(user.serial_number, request.sensor_name, request.sensor_type_id);
                return Json(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [JWTAuthorize]
        [HttpPost]
        [Route("api/edit/mysensor")]
        public IHttpActionResult Edit_MySensor([FromBody] m_UpdateSensor request, int Id)
        {
            try
            {
                var res = _Create_Sensor.UpdateSensor(Id, request.sensor_name);
                return Json(res);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [JWTAuthorize]
        [HttpPost]
        [Route("api/delete/mysensor")]
        public IHttpActionResult Delete_MySensor(int Id)
        {
            try
            {
                var res = _Create_Sensor.DeleteSensor(Id);
                return Json(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/save/moisture")]
        public IHttpActionResult Create_moisture([FromBody] m_moisture request)
        {
            try
            {
                var res = _Rep.Create_Moisture(request.sensor_id, request.moisture);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get data.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/save/moisture_level")]
        public IHttpActionResult Create_moisture_level([FromBody] m_moisture_level request)
        {
            try
            {
                var res = _Rep.Create_MoistureLevel(request.sensor_id, request.moisture_level);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get data.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/save/raining")]
        public IHttpActionResult Create_raining([FromBody] m_raining request)
        {
            try
            {
                var res = _Rep.Create_Raining(request.sensor_id, request.raining);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get data.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/save/temp")]
        public IHttpActionResult Create_temp([FromBody] m_temp request)
        {
            try
            {
                var res = _Rep.Create_Temp(request.sensor_id, request.temp);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get data.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/save/uv")]
        public IHttpActionResult Create_uv([FromBody] m_uv request)
        {
            try
            {
                var res = _Rep.Create_Uv(request.sensor_id, request.uv);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get data.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/save/wind")]
        public IHttpActionResult Create_wind([FromBody] m_wind request)
        {
            try
            {
                var res = _Rep.Create_Wind(request.sensor_id, request.wind);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get data.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/save/UpdateLatlng")]
        public IHttpActionResult Create_UpdateLatlng([FromBody] m_UpdateLatlng request)
        {
            try
            {
                var res = _Rep.Update_latlng(request.serial_number, request.lat, request.lng);
                if (res != null)
                {
                    return Json(res);
                }
                return BadRequest("fail get data.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
