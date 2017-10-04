using System;
using Android.Graphics.Drawables;
using PickerSample.Controls;
using PickerSample.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace PickerSample.Droid.Renderers
{
	public class CustomFrameRenderer : VisualElementRenderer<Frame>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
		{
			base.OnElementChanged(e);
			GradientDrawable gradientDrawable = new GradientDrawable();
			gradientDrawable.SetShape(ShapeType.Rectangle);
			gradientDrawable.SetColor(Element.BackgroundColor.ToAndroid());
			gradientDrawable.SetStroke(4, Color.FromHex("EA6C5B").ToAndroid());
			gradientDrawable.SetCornerRadius(30.0f);
			this.SetBackground(gradientDrawable);

		}

	}
}
