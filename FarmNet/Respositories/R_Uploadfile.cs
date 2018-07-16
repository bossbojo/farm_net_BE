using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace FarmNet.Respositories
{
    public class R_Uploadfile
    {
        public string uploadImage(string img) {

            var imgsplit = img.Split(',');
            img = imgsplit.Length > 1 ? imgsplit[1] : img;
            var myfilename = string.Format(@"{0}", Guid.NewGuid());
            myfilename = myfilename + ".jpeg";
            string filepath = HttpContext.Current.Server.MapPath("~/Images/" + myfilename);
            var bytess = Convert.FromBase64String(img);
            File.WriteAllBytes(filepath, bytess);
            return myfilename;
        }
    }
}