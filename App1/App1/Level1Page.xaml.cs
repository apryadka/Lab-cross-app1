using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
  
    public partial class Level1Page : ContentPage
    {
        public Level1Page()
        {
            InitializeComponent();
        }

        private void Button1_clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}