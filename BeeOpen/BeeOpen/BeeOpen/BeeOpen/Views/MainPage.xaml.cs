using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeOpen.Views;
using Xamarin.Forms;

namespace BeeOpen
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

        private void Login_Clicked(object sender, EventArgs e)
        {
            if (username.Text.Equals("user") || password.Text.Equals("pass"))
            {
                Navigation.PushAsync(new DashboardTabbed(), true);
                Console.WriteLine("got in");
            }
                



        }

        private void Register_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register (), true);
        }
    }
}
