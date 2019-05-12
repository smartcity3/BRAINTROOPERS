using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BeeOpen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardTabbed : TabbedPage
    {
        public DashboardTabbed()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            this.Children.Add(new Feed());
            this.Children.Add(new Suggestions ());
            this.Children.Add(new Profile ());
        }
    }
}