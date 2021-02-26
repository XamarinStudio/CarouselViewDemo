using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using CarouselViewDemo.Droid;
using Xamarin.Forms;
using Application = Android.App.Application;
using View = Android.Views.View;

[assembly: Xamarin.Forms.Dependency(typeof(DarkService))]
namespace CarouselViewDemo.Droid
{
    public class DarkService : IDarkService
    {
        public void Reset()
        {
            Android.Views.View view = MainActivity.DecorView;
            view.SetLayerType(LayerType.Hardware, null);
        }

        public void SetWindowGray()
        {
            Android.Views.View view = MainActivity.DecorView;
            Paint paint = new Paint();
            ColorMatrix cm = new ColorMatrix();
            cm.SetSaturation(0);
            paint.SetColorFilter(new ColorMatrixColorFilter(cm));
            view.SetLayerType(LayerType.Hardware, paint);
        }
    }
}