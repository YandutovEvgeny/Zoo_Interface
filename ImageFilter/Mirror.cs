using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilter
{
    class Mirror : IFilter
    {
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
                    buffer.SetPixel(w-j-1, i, pixel);
                }
            }
            return buffer;
        }

        public string GetName()
        {
            return "Отзеркалить";
        }
    }
}
