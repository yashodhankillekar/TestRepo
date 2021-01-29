using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestXamApp.Models;
using TestXamApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXamApp.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}