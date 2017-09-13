using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
        public GreetPage ()
		{
			InitializeComponent ();

            slider.Value = 0.5;

            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World!"
            //}; code behind option 
		}
        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            texty.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}