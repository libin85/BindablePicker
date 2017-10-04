using System;
using System.ComponentModel;
using PickerSample.Controls;
using PickerSample.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CustomFrame), typeof(CustomFrameRenderer))]
namespace PickerSample.iOS.Renderers
{
	public class CustomFrameRenderer : VisualElementRenderer<Frame>
	{
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (this != null)
			{
				Layer.BorderColor = new UIColor(red: 0.92f, green: 0.42f, blue: 0.36f, alpha: 1.0f).CGColor;
				Layer.BorderWidth = 1;
				Layer.CornerRadius = 20f;
			}
		}
	}
}
