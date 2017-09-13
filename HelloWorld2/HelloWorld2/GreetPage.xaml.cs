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
            
		}

    }
}