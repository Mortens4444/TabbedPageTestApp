namespace TabbedPageTestApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnOpenTabbedPageClicked(object sender, EventArgs e)
    {
        var page = new MyTabbedPage();
        await Navigation.PushAsync(page);
    }
}
