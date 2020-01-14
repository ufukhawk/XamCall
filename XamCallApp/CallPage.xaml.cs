using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamCallApp
{
    public partial class CallPage : ContentPage
    {
        public CallPage()
        {
            InitializeComponent();
        }
        protected void EndCall(object s, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
