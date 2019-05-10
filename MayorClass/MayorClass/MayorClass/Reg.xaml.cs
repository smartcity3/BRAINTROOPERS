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

        }

        private async void Register_OnClicked(object sender, EventArgs e)
        {
            try
            {

                if (name.Text.Equals(null))
                {
                    error.Text = "Somethink is empty! Please fill it up and try again!";
                }
                else
                {
                    if (password.Text.Equals(password2.Text))
                    {
                        error.Text = "";
                        ok.Text = "Everything is set!";
                        await Navigation.PushAsync(new MainPage(), true);
                    }
                    else
                    {
                        error.Text = "Password mismatch";
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                error.Text = "Somethink is empty! Please fill it up and try again!";

            }


        }
    }
}

