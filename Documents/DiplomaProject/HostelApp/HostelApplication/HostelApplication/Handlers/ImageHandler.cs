using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace HostelApplication
{
    public class ImageHandler
    {        
        public byte[] CreateArrayOfBytesFromFilePath(string path)
        {
            byte[] imageBytes;
            using (Image image = Image.FromFile(path))
            {
                MemoryStream m;
                using (m = new MemoryStream())
                {

                    image.Save(m, image.RawFormat);
                    imageBytes = new byte[m.Length];
                    //Very Important    
                    imageBytes = m.ToArray();

                }//end using
            }//end using
            return imageBytes;
        }

        public Image ResizeOriginalImage(Image image, int nWidth, int nHeight)
        {
            int newWidth, newHeight;
            var coefH = (double)nHeight / (double)image.Height;
            var coefW = (double)nWidth / (double)image.Width;
            if (coefW >= coefH)
            {
                newHeight = (int)(image.Height * coefH);
                newWidth = (int)(image.Width * coefH);
            }
            else
            {
                newHeight = (int)(image.Height * coefW);
                newWidth = (int)(image.Width * coefW);
            }

            Image result = new Bitmap(newWidth, newHeight);
            using (var g = Graphics.FromImage(result))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(image, 0, 0, newWidth, newHeight);
                g.Dispose();
            }
            return result;
        }

        public Image ConvertByteArrayToImage(byte[] bytesArr)
        {
            Image newImage = null;
            try
            {
                //Read image data into a memory stream
                newImage = Image.FromStream(new MemoryStream(bytesArr));
            }
            catch
            {
                // ignore and return null
            }

            //set picture
            return newImage;
        }
    }    
}
