using System;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_clicked(object sender, EventArgs e) 
        {
            Label1.Text = Entry1.Text;

        }
        private async void Button2_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Level1Page());
        }
        private void Button1_clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
