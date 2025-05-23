namespace LayoutCSolorzano.Views;

public partial class StackLayoutPage : ContentPage
{
	public StackLayoutPage()
	{
		InitializeComponent();
	}

    public void ButtonNextPage(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexLayoutPage());
    }
}