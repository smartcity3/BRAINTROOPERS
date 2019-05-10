using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace MayorClass
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogIn_OnClicked(object sender, EventArgs e)
        {


            if (username.Text.Equals("Nikos") && password.Text.Equals("123"))
            {
               
                await Navigation.PushAsync(new Page(), true);
            }

            else
            {
                error.Text = "Wrong password or username!";
            }
        }

        private void Regtister_OnClicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Reg(), true);

        }

    }
}
