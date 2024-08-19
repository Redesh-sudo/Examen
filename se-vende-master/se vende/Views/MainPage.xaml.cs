using Xamarin.Forms;
using se_vende.Models;
using se_vende.Views;
using se_vende;
using System;


namespace se_vende.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            contactsListView.ItemsSource = await App.Database.GetContactsAsync();
        }

        async void OnAddContactClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactPage
            {
                BindingContext = new Contact()
            });
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ContactPage
                {
                    BindingContext = e.SelectedItem as Contact
                });
            }
        }
    }
}