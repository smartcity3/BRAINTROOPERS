using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acr.UserDialogs;
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

        private  void Login_Clicked(object sender, EventArgs e)
        {
            UserDialogs.Instance.ShowLoading();
            if (username.Text.Equals("user") && password.Text.Equals("pass"))
            {
                UserDialogs.Instance.HideLoading ();
                Navigation.PushAsync(new DashboardTabbed(), true);
               
            }
                



        }

        private void Register_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Register (), true);
        }
    }
}
