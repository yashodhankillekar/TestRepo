using System.ComponentModel;
using TestXamApp.ViewModels;
using Xamarin.Forms;

namespace TestXamApp.Views
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