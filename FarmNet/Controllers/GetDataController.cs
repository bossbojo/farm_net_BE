using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FarmNet.Respositories;
using FarmNet.Authen;
using FarmNet.Entity;

namespace FarmNet.Controllers
{
    [JWTAuthorize]
    public class GetDataController : ApiController
    {
        private R_GetData _GetData = new R_GetData();
        [HttpGet]
        [Route("api/get/image")]
        public IHttpActionResult GetIamge(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.getImage(sensor_id);
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
        [Route("api/get/all/images")]
        public IHttpActionResult GetIamges(int sensor_id)
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetImages(sensor_id);
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
        [Route("api/get/all/sensor_type")]
        public IHttpActionResult GetSensorType()
        {
            try
            {
                var res = _GetData.GetAllTypeSensor();
                return Json(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("api/get/my/sensor")]
        public IHttpActionResult GetMySensor()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetSensorByName(user.serial_number);
                return Json(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpGet]
        //[Route("api/get/data_sensor")]
        //public IHttpActionResult GetDataSensor(int start,int max) {
        //    try {
        //        var user = Authentication.User;
        //        var res = _GetData.getDataSensor(user.serial_number,start,max);
        //        if (res != null) {
        //            return Json(res);
        //        }
        //        return BadRequest("fail get data.");
        //    }
        //    catch (Exception ex) {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [HttpGet]
        [Route("api/get/data/sensor/main")]
        public IHttpActionResult GetChartBySerial()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetChartBySerial(user.serial_number);
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
        [Route("api/get/data/sensor/soil")]
        public IHttpActionResult GetChartBySerialSoil()
        {
            try
            {
                var user = Authentication.User;
                var res = _GetData.GetChartBySerialSoil(user.serial_number);
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
