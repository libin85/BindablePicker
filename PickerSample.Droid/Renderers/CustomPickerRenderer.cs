using System;
using Android.Views;
using PickerSample.Controls;
using PickerSample.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace PickerSample.Droid.Renderers
{
    public class CustomPickerRenderer : PickerRenderer
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackground(Resources.GetDrawable(Resource.Drawable.selectbox));
                Control.TextSize = 16f;
                Control.Gravity = GravityFlags.CenterHorizontal;
                Control.SetTextColor(Color.FromHex("EA6C5B").ToAndroid());
                Control.SetHintTextColor(Color.FromHex("EA6C5B").ToAndroid());

            }
        }
    }
}
