using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsExample
{
    public partial class HelloPage : ContentPage
    {
        public HelloPage()
        {
            InitializeComponent();

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var response = await DisplayAlert("Print Hello", "Are you sure?", "Print", "Cancel");

            if (response)
            {
                this.HelloLabel.Text = "Hello, " + this.NameEntry.Text;
            }
            else
            {
                this.HelloLabel.Text = String.Empty;
            }
        }
    }
}
