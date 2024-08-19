using se_vende.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace se_vende.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}