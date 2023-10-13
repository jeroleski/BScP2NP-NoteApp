namespace Mini_project_Note_App_np;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
        InitializeComponent();

		//foreach (var c in Database.Instance.Categories.Keys)
		//{
		//	CategoryGrid.Add(new Button()
		//	{
		//		Text = c
		//	});
		//}
	}

	private async void OnCategoryClicked(object sender, EventArgs e)
	{
        var button = sender as Button;
		var page = button.Text;

		await Navigation.PushAsync(new CategoryPage(page));

    }
}

