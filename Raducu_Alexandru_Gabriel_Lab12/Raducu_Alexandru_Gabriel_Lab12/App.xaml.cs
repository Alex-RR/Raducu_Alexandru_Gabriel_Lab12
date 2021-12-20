using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Raducu_Alexandru_Gabriel_Lab12.Data;

namespace Raducu_Alexandru_Gabriel_Lab12
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
