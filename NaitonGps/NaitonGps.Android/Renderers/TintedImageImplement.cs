using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NaitonGps.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(TintedImageImplement), nameof(NaitonGps.Controls.TintedImage))]
namespace NaitonGps.Droid.Renderers
{
    public class TintedImageImplement : PlatformEffect
    {
        protected override void OnAttached()
        {
            try
            {
                var effect = (NaitonGps.Controls.TintedImage)Element.Effects.FirstOrDefault(e => e is NaitonGps.Controls.TintedImage);

                if (effect == null || !(Control is ImageView image))
                    return;

                var filter = new PorterDuffColorFilter(effect.TintColor.ToAndroid(), PorterDuff.Mode.SrcIn);
                image.SetColorFilter(filter);
            }
            catch (Exception ex)
            {

            }
        }

        protected override void OnDetached() { }
    }
}