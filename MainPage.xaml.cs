namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButton1Clicked(object sender, EventArgs e)
        {
            BorderTop.Stroke = Colors.Green;
            BorderBottom.Stroke = Colors.Red;
            EntryTop.Focus();
        }

        private void OnButton2Clicked(object sender, EventArgs e)
        {
            BorderTop.Stroke = Colors.Red;
            BorderBottom.Stroke = Colors.Green;
            EntryBottom.Focus();
        }
    }

}
