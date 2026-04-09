namespace MauiApp;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        count++;
        label.Text = $"ボタンを {count} 回押したよ";
    }
}
