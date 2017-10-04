using System;
using System.ComponentModel;
using CoreGraphics;
using PickerSample.Controls;
using PickerSample.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace PickerSample.iOS.Renderers
{
	public class CustomPickerRenderer : PickerRenderer
	{
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);


			if (Control != null)
			{
				Control.Layer.BorderWidth = 1;
				Control.Layer.BorderColor = Color.FromHex("FFFFFF").ToCGColor();

				var selectControl = this.Control;
				selectControl.RightViewMode = UITextFieldViewMode.Always;

				//Control.BorderStyle = UIKit.UITextBorderStyle.RoundedRect;
				Control.Layer.CornerRadius = 18.0f;
				Control.AttributedPlaceholder = new Foundation.NSAttributedString(Control.AttributedPlaceholder.Value, foregroundColor: Color.FromHex("FFFFFF").ToUIColor());
				Control.LeftView = new UIView(new CGRect(0, 0, 15, 0));
				Control.LeftViewMode = UITextFieldViewMode.Always;
				Control.TextAlignment = UITextAlignment.Center;
				Control.Font = UIFont.FromName("Fonts/SourceSansPro-Regular", 16f);

			}


		}
	}
}
