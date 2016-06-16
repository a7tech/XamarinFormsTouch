using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTouch
{
    public class Hello : ContentPage
    {
        public Hello()
        {
            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,

                Children = {
					new Label { Text = "Hello , This is your First Page." }
				}
            };
        }
    }
}
