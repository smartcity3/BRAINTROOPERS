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
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void LogIn_OnClicked(object sender, EventArgs e)
        {


            if (username.Text.Equals("BrainTrooper") && password.Text.Equals("123"))
            {
               
                await Navigation.PushAsync(new DashboardTabbed(), true);
            }

            else
            {
                DisplayAlert("","Λάθος κωδικός ή όνομα!!", "OK");
            }
        }

        private void Regtister_OnClicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Reg(), true);

        }

    }
}
