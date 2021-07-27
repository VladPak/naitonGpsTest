using Foundation;
using NaitonGps.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(NaitonGps.iOS.Renderers.TintedImageImplementIOS), nameof(TintedImage))]
namespace NaitonGps.iOS.Renderers
{
    public class TintedImageImplementIOS : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effect = (NaitonGps.Controls.TintedImage)Element.Effects.FirstOrDefault(e => e is NaitonGps.Controls.TintedImage);

                if (effect == null || !(Control is UIImageView image))
                    return;

                image.Image = image.Image.ImageWithRenderingMode(UIImageRenderingMode.AlwaysTemplate);
                image.TintColor = effect.TintColor.ToUIColor();
            }
            catch (Exception ex)
            {
            }
        }

        protected override void OnDetached() { }
    }
}