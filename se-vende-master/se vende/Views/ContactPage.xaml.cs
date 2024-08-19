using Xamarin.Forms;
using se_vende.Models;
using se_vende.Views;
using se_vende;
using System;
using Xamarin.Forms.Xaml;

namespace se_vende.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            await App.Database.SaveContactAsync(contact);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var contact = (Contact)BindingContext;
            await App.Database.DeleteContactAsync(contact);
            await Navigation.PopAsync();
        }
    }
}
