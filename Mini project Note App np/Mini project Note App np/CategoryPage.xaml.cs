namespace Mini_project_Note_App_np;

public partial class CategoryPage : ContentPage
{
    private string page;

    public CategoryPage(string pageName)
    {
        InitializeComponent();
        this.page = pageName;
        CategoryName.Text = pageName;

        foreach (var n in Database.Instance.Categories[pageName].Nodes.Keys)
        {
            var btn = new Button()
            {
                Text = n
            };
            btn.Clicked += OpenNode;
            NodeList.Add(btn);

        }
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void NewNode(object sender, EventArgs e)
    {
        var button = sender as Button;
        var node = button.Text;

        await Navigation.PushAsync(new NodePage(page, node));
    }

    private async void OpenNode(object sender, EventArgs e)
    {
        var button = sender as Button;
        var node = button.Text;

        await Navigation.PushAsync(new NodePage(page, node));
    }
}

