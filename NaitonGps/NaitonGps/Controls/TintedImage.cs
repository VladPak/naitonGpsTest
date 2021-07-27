using Xamarin.Forms;

namespace NaitonGps.Controls
{
    public class TintedImage : RoutingEffect
    {
        public Color TintColor { get; set; }
        public TintedImage(Color color) : base($"MyElement.{nameof(TintedImage)}")
        {
            TintColor = color;
        }
    }
}
