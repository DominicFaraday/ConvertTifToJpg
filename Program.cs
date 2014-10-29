using BitMiracle.LibTiff.Classic;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using ImageResizer;

namespace ConvertTifToJpg
{
    class Program
    {
        static void Main(string[] args)
        {
            //http://imageresizing.net/docs/managed

            //ImageBuilder.Current.Build(@"D:\To be backed up\bad.tif", @"D:\To be backed up\bad.jpg",
            //               new ResizeSettings("format=jpg"));

            ImageBuilder.Current.Build(@"f:\order.JPG", @"f:\order1.JPG", new ResizeSettings(300, 250, FitMode.Pad, "jpg"));

            //using (Tiff tif = Tiff.Open(@"D:\To be backed up\bad.tif", "r"))
            //{
            //    int imageWidth = GetWidth(tif);
            //    int imageHeight = GetHeight(tif);

            //    // Read the image into the memory buffer
            //    int[] raster = new int[imageHeight * imageWidth];

                

            //    if (!tif.ReadRGBAImage(imageWidth, imageHeight, raster))
            //    {
            //        throw new Exception("Could not read tif");
            //    }

            //    using (Bitmap bmp = new Bitmap(imageWidth, imageHeight, PixelFormat.Format32bppRgb))
            //    {
            //        Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);

            //        BitmapData bmpdata = bmp.LockBits(rect, ImageLockMode.ReadWrite, PixelFormat.Format32bppRgb);
            //        byte[] bits = new byte[bmpdata.Stride * bmpdata.Height];

            //        for (int y = 0; y < bmp.Height; y++)
            //        {
            //            int rasterOffset = y * bmp.Width;
            //            int bitsOffset = (bmp.Height - y - 1) * bmpdata.Stride;

            //            for (int x = 0; x < bmp.Width; x++)
            //            {
            //                int rgba = raster[rasterOffset++];
            //                bits[bitsOffset++] = (byte)((rgba >> 16) & 0xff);
            //                bits[bitsOffset++] = (byte)((rgba >> 8) & 0xff);
            //                bits[bitsOffset++] = (byte)(rgba & 0xff);
            //                bits[bitsOffset++] = (byte)((rgba >> 24) & 0xff);
            //            }
            //        }

            //        System.Runtime.InteropServices.Marshal.Copy(bits, 0, bmpdata.Scan0, bits.Length);
            //        bmp.UnlockBits(bmpdata);

            //        //bmp.Save("c:\\TiffTo32BitBitmap.jpg", ImageFormat.Jpeg);
            //        bmp.Save("c:\\TiffTo32BitBitmap.bmp");
            //    }
            //}
        }

        private static int GetHeight(Tiff tif)
        {
            FieldValue[] value;
            value = tif.GetField(TiffTag.IMAGELENGTH);
            int height = value[0].ToInt();
            return height;
        }

        private static int GetWidth(Tiff tif)
        {
            FieldValue[] value = tif.GetField(TiffTag.IMAGEWIDTH);
            int width = value[0].ToInt();
            return width;
        }
        
    }
}
