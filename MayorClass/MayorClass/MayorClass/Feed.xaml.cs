using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MayorClass
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Feed : ContentPage
    {
        public Feed()
        {
            InitializeComponent();
        }

        private void Open_OnClicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Detail(), true);
        }

    }
}
