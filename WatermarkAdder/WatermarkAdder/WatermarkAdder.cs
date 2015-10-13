using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace WatermarkAdder
{
    public class WatermarkAdder
    {
        private Bitmap _mask;

        public WatermarkAdder(String maskPath) : this((Bitmap)Image.FromFile(maskPath))
        {
        }

        public WatermarkAdder(Bitmap mask)
        {
            _mask = mask;
        }



        public Bitmap AddWatermark(String imagePath, int x, int y)
        {
            return AddWatermark((Bitmap)Image.FromFile(imagePath), x, y);
        }


        public Bitmap AddWatermark(Bitmap image, int x, int y)
        {
            return AddImages(image, _mask, 0, 0);
        }


        private Bitmap AddImages(Bitmap bmp1, Bitmap bmp2, int x, int y)
        {
            var bmp1Bytes = ImageToByte(bmp1);
            var bmp2Bytes = ImageToByte(bmp2);

            return null;
        }


        private byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

    }
}
