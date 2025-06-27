using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.SchoolRegistrationApp.UI.Helpers
{
    public static class ImageHelper
    {
        public static string ToBase64(Image photograph)
        {
            string base64Photo = "";
            if (photograph != null)
            {
                using (MemoryStream memory = new MemoryStream())
                {
                    photograph.Save(memory, System.Drawing.Imaging.ImageFormat.Jpeg);
                    base64Photo = Convert.ToBase64String(memory.ToArray());
                }
            }
            return base64Photo;
        }
        public static Image FromBase64(string base64String)
        {
            if (string.IsNullOrWhiteSpace(base64String))
                return null;
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                return Image.FromStream(memoryStream);
        }
    }
}
