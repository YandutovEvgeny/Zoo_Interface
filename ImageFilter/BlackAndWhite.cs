using System.Drawing;

namespace ImageFilter
{
    class BlackAndWhite : IFilter
    {
        public string GetName()
        {
            return "Чёрно-белый";
        }

        public Bitmap Apply(Bitmap image)
        {
            int h = image.Height;
            int w = image.Width;
            Bitmap buffer = new Bitmap(w, h);
            for (int i = 0; i < h; i++) //По высоте(Y)
            {
                for (int j = 0; j < w; j++) //По ширине(X)
                {
                    Color pixel = image.GetPixel(j, i);
                    if ((pixel.R + pixel.B + pixel.G) / 3 > 100)
                        buffer.SetPixel(j, i, Color.Black);
                    else 
                        buffer.SetPixel(j, i, Color.White);
                }
            }  
            return buffer;
        }
    }
}
