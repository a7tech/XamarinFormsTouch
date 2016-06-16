using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTouch
{
    public class NotAvailable : ContentPage
    {
        public NotAvailable()
        {
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

                Children = {
					new Label { Text = "Either your device is not supported or Touch Id is not present in your device" }
				}
            };
        }
    }
}
