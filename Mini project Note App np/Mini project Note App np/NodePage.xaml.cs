namespace Mini_project_Note_App_np;

public partial class NodePage : ContentPage
{
    public NodePage(string pageName)
    {
        InitializeComponent();
        NodeName.Text = pageName;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void SaveNode(object sender, EventArgs e)
    {
        
    }

    private async void DeleteNode(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}

