using se_vende.Services;
using se_vende.Models;
using se_vende.Views;

using System;
using System.IO;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace se_vende
{
    public partial class App : Application
    {
        static DatabaseService database;

        public static DatabaseService Database
        {
            get
            {
                if (database == null)
                {
                    database = new DatabaseService(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Contacts.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
    }
}