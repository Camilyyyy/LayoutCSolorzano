namespace LayoutCSolorzano.Views;

public partial class ColorGrid : ContentPage
{
	public ColorGrid()
	{
		InitializeComponent();
	}
	public void ButtonNextPage(object sender, EventArgs e)
	{
		Navigation.PushAsync(new StackLayoutPage());
	}
}