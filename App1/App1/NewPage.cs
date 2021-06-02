using Xamarin.Forms;

namespace App1
{
    class NewPage : ContentPage
    {
        public NewPage()
        {

            Label label1 = new Label()
            {
                Text = "Введите текст",
                FontSize = 14
            };
            Entry entry = new Entry() {
                Placeholder = "Текст"
            };
            Button button = new Button() {
                Text = "Применить",
                FontSize = 14,
            };
            Label label2 = new Label()
            {
                Text = "Текст",
                FontSize = 14
            };

            button.Clicked += (sender, args) => label2.Text = entry.Text;

            Content = new StackLayout
            {
                BackgroundColor = Color.Aquamarine,
                Children = { label1, entry, button , label2 }
            };
        }
    }
}
