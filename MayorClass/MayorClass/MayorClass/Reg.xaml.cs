using System;
using System.Collections.Generic;
using System.ComponentModel;
using Acr.UserDialogs;
using Xamarin.Forms;

namespace MayorClass
{
    [DesignTimeVisible(true)]
    public partial class Reg : ContentPage
    {
        public Reg()
        {

            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Register_OnClicked(object sender, EventArgs e)
        {
            try
            {

                if (name.Text.Equals(null))
                {
                    DisplayAlert("", "Κάποιο πεδίο ειναι κενό. Συμπληρώστε όλα τα πεδία!", "OK");
                }
                else
                {
                    if (password.Text.Equals(password2.Text))
                    {
                        DisplayAlert("", "Η εγγραφή σας πραγματοποιήθηκε με επιτυχία!!", "OK");
                        await Navigation.PushAsync(new MainPage(), true);
                    }
                    else
                    {
                        DisplayAlert("", "Ο κωδικός δεν τεριάζει!", "OK");
                    }

                }
            }
            catch (Exception exception)
            {
                DisplayAlert("", "Κάποιο πεδίο ειναι κενό. Συμπληρώστε όλα τα πεδία!", "OK");

            }


        }
    }
}

