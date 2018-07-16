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

        //------------------------

        [HttpGet]
        [Route("api/get/moisture-last")]
        public IHttpActionResult GetMoisture_last(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetMoistureSum(sensor_id);
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
        public IHttpActionResult GetMoisture_level_last(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetMoisture_levelSum(sensor_id);
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
        public IHttpActionResult GetRaining_last(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetRainingSum(sensor_id);
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
        public IHttpActionResult GetTemp_last(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetTempSum(sensor_id);
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
        public IHttpActionResult GetUv_last(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetUvSum(sensor_id);
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
        public IHttpActionResult GetWind_last(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetWindSum(sensor_id);
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
