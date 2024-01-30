namespace TabbedPageTestApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnOpenTabbedPageClicked(object sender, EventArgs e)
    {
        var page = Activator.CreateInstance(typeof(MyTabbedPage)) as Page;
        await Navigation.PushAsync(page);
    }
}
