namespace Mini_project_Note_App_np;

public partial class NodePage : ContentPage
{
    public NodePage(string pageName, string nodeName)
    {
        InitializeComponent();
        NodeName.Text = nodeName;
        NodeText.Text = Database.Instance.Categories[pageName].Nodes[nodeName].Text;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void SaveNode(object sender, EventArgs e)
    {
        
    }

    private async void DeleteNode(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}

