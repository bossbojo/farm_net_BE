using FarmNet.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FarmNet.Authen;

namespace FarmNet.Controllers
{
    [JWTAuthorize]
    public class GetDataSensorController : ApiController
    {
        private R_GetData _GetData = new R_GetData();
        [HttpGet]
        [Route("api/get/moisture")]
        public IHttpActionResult GetMoisture(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetMoisture(sensor_id);
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
        [HttpGet]
        [Route("api/get/moisture_level")]
        public IHttpActionResult GetMoisture_level(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetMoisture_level(sensor_id);
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
        [HttpGet]
        [Route("api/get/raining")]
        public IHttpActionResult GetRaining(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetRaining(sensor_id);
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
        [HttpGet]
        [Route("api/get/temp")]
        public IHttpActionResult GetTemp(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetTemp(sensor_id);
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
        [HttpGet]
        [Route("api/get/uv")]
        public IHttpActionResult GetUv(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetUv(sensor_id);
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
        [HttpGet]
        [Route("api/get/wind")]
        public IHttpActionResult GetWind(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetWind(sensor_id);
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
        [HttpGet]
        [Route("api/get/soil")]
        public IHttpActionResult GetSoil(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetSoil(sensor_id);
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
        //------------------------
        [HttpGet]
        [Route("api/get/moisture/all")]
        public IHttpActionResult GetMoistureAll()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetManyMoisture(user.serial_number);
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
        [HttpGet]
        [Route("api/get/moisture_level/all")]
        public IHttpActionResult GetMoisture_levelAll()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetManyMoistureLevel(user.serial_number);
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
        [HttpGet]
        [Route("api/get/raining/all")]
        public IHttpActionResult GetRainingAll(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetManyRaining(user.serial_number);
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
        [HttpGet]
        [Route("api/get/temp/all")]
        public IHttpActionResult GetTempAll()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetManyTemp(user.serial_number);
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
        [HttpGet]
        [Route("api/get/uv/all")]
        public IHttpActionResult GetUvAll()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetManyUv(user.serial_number);
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
        [HttpGet]
        [Route("api/get/wind/all")]
        public IHttpActionResult GetWindAll()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetManyWind(user.serial_number);
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
        [HttpGet]
        [Route("api/get/soil/all")]
        public IHttpActionResult GetSoilAll()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetManySensorSoil(user.serial_number);
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
        //------------------------

        [HttpGet]
        [Route("api/get/moisture-last")]
        public IHttpActionResult GetMoisture_last()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetMoistureSum(user.serial_number);
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
        [HttpGet]
        [Route("api/get/moisture_level-last")]
        public IHttpActionResult GetMoisture_level_last()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetMoisture_levelSum(user.serial_number);
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
        [HttpGet]
        [Route("api/get/raining-last")]
        public IHttpActionResult GetRaining_last()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetRainingSum(user.serial_number);
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
        [HttpGet]
        [Route("api/get/temp-last")]
        public IHttpActionResult GetTemp_last()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetTempSum(user.serial_number);
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
        [HttpGet]
        [Route("api/get/uv-last")]
        public IHttpActionResult GetUv_last()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetUvSum(user.serial_number);
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
        [HttpGet]
        [Route("api/get/wind-last")]
        public IHttpActionResult GetWind_last()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetWindSum(user.serial_number);
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
        [HttpGet]
        [Route("api/get/soil-last")]
        public IHttpActionResult GetSensorSoil_last()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetSoilSum(user.serial_number);
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
