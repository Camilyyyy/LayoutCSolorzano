namespace LayoutCSolorzano.Views;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}
    public void ButtonNextPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutPage());
    }
}