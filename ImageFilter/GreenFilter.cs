using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageFilter
{
    class GreenFilter : IFilter
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
                    //Красный отстутвует, зелёного столько, сколько на картинке, синий отсутствует
                    buffer.SetPixel(j, i, Color.FromArgb(0,pixel.G,0));
                }
            }
            return buffer; ;
        }

        public string GetName()
        {
            return "Оттенки зелёного";
        }
    }
}
