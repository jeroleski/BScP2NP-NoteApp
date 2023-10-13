namespace Mini_project_Note_App_np;

public partial class CategoryPage : ContentPage
{
    public CategoryPage(string pageName)
    {
        InitializeComponent();
        CategoryName.Text = pageName;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void NewNode(object sender, EventArgs e)
    {
        var button = sender as Button;
        var page = button.Text;

        await Navigation.PushAsync(new CategoryPage(page));
    }

    private async void OpenNode(object sender, EventArgs e)
    {
        var button = sender as Button;
        var page = button.Text;

        await Navigation.PushAsync(new CategoryPage(page));
    }
}

