using Acr.Biometrics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Xamarin.Forms;

namespace XamarinTouch
{
    public class TouchView : ContentPage
    {
        public TouchView()
        {


            var btn = new Button { Text = "Click me " };

            btn.Clicked += btn_Clicked;

            Content = new StackLayout
            {
                Children = {
					btn
				}
            };
        }

        async void btn_Clicked(object sender, EventArgs e)
        {
            var result = await Biometrics.Instance.Evaluate("XamarinTouch");
            if (result)
            {
                this.Navigation.PushAsync(new Hello());
            }
            else
            {
                this.Navigation.PushAsync(new NotAvailable());
            }
        }
    }
}
