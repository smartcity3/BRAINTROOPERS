using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeeOpen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            AddMuniciplaity ();
        }

        private void AddMuniciplaity ()
        {
           ArrayList list = new ArrayList();
           list.Add("Τρικκαίων");
           list.Add("Αθηνών");
           list.Add("Πειραιώς");
           list.Add("Θεσσαλονίκης");
           list.Add("Φλώρινάς");
           list.Add("Πειραιώς");
           foreach (string item in list)
           {
               mun.Items.Add(item);
           }

           
           
        }

        private void Register_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException ();
        }
    }
}