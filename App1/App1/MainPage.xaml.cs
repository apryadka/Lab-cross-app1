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
    }
}
