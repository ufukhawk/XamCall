using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamCallApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected void CallPage(object s, EventArgs e)
        {
            Navigation.PushAsync(new CallPage());
        }
    }
}
