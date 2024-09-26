namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBtnClicked(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Test");
            await Shell.Current.GoToAsync("WebViewPage");
        }
    }

}
