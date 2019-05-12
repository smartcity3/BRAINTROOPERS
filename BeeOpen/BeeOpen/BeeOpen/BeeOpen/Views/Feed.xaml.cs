using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeeOpen.DataStorage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeeOpen.Views
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
            this.Navigation.PushAsync(new Detail (), true);
        }
    }
}