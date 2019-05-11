using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MayorClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Suggestions : ContentPage
    {
        public Suggestions()
        {
            InitializeComponent();
        }

        private async void Submit_OnClicked(object sender, EventArgs e)
        {
            try
            {
                if(Title.Text.Equals(null) && ToPublish.Text.Equals(null))
                {

                }
                else
                {
                    Title.Text = null;
                    ToPublish.Text = null;
                    DisplayAlert("", "Η δημοσιευση σαςκαταχωριθηκε με επιτυχια!", "OK");
                }

            }
            catch(Exception exeption)
            {
                DisplayAlert("", "Για την επιτυχει καταχωριση της δημοσιευσης σας παρακαλιστε να εχετε σημπλιρομενα και ολα τα πεδια! Συμπλιρωστε τα και επαναλαβεται την καταχωριση!", "OK");
            }
        }
    }
}

