using System.Drawing;

namespace ImageFilter
{
    interface IFilter
    {
        Bitmap Apply(Bitmap image);
        string GetName();
    }
}
