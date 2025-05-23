namespace LayoutCSolorzano.Views;

public partial class AbsoluteLayoutPage : ContentPage
{
	public AbsoluteLayoutPage()
	{
		InitializeComponent();
	}

    public void ButtonNextPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ColorGrid());
    }
}