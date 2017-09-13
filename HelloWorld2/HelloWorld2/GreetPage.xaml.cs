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

            if(Device.OS == TargetPlatform.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0); // always add 20px to top of page 
            }
            else if (Device.OS == TargetPlatform.Android)
            {
                Padding = new Thickness(5, 20, 5, 5);
            }

            //Padding = Device.OnPlatform(    //depricated :(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(10, 20, 0, 0)
            //    );

            Device.OnPlatform(
                iOS: () =>
                {
                    Padding = new Thickness(0, 20, 0, 0);
                },
                Android: () =>
                {
                    Padding = new Thickness(10, 10, 10, 10);
                }) 

        }

    }
}



//var x = new OnPlatform<Thickness>
//{
//    Android = new Thickness(0),
//    iOS = new Thickness(0, 20, 0, 0)
//};

//Padding = x;