using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PickerSample.Controls
{
    public partial class LabelWithPickerControl : ContentView
    {
		public string LabelText { get; set; }

		public LabelWithPickerControl()
		{
			InitializeComponent();
		}
		public static readonly BindableProperty ItemSourceProperty =
		BindableProperty.Create(nameof(ItemSource), typeof(List<string>), typeof(LabelWithPickerControl), null);

		public List<string> ItemSource
		{
			get
			{
				return (List<string>)GetValue(ItemSourceProperty);
			}
			set
			{
				SetValue(ItemSourceProperty, value);
			}
		}

		private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var picker = (CustomPicker)bindable;
			picker.ItemsSource = (List<string>)newValue;
		}
		public static readonly BindableProperty LabelTextProperty = BindableProperty.Create(
														 propertyName: "LabelText",
														 returnType: typeof(string),
														 declaringType: typeof(LabelWithPickerControl),
														 defaultValue: "",
														 defaultBindingMode: BindingMode.TwoWay,
														 propertyChanged: LabelTextPropertyChanged);

		private static void LabelTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var control = (LabelWithPickerControl)bindable;
			control.lblTitle.Text = newValue.ToString();
		}
		
    }
}
