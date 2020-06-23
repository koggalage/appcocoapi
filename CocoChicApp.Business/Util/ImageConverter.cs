using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CocoChicApp.Business.Util
{
    public static class ImageConverter
    {
        public static void SaveImage(string strm, string filename)
        {
            try
            {
                //data: image / jpeg; base64
                string filepath = "UserImages/Signatures/" + filename + ".jpg";
                strm = strm.Replace("data:image/png;base64,", "");
                strm = strm.Replace("data:image/jpeg;base64,", "");
                var bytess = Convert.FromBase64String(strm);
                using (var imageFile = new FileStream(filepath, FileMode.Create))
                {
                    imageFile.Write(bytess, 0, bytess.Length);
                    imageFile.Flush();
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
