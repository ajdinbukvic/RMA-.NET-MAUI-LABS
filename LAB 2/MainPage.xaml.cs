namespace AjdinBukvic_RMA_LAB2;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void StudentPageLight(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new StudentPageLight());
	}

    private void StudentPageDark(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new StudentPageDark());
    }

    private void ProfesorPageLight(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ProfesorPageLight());
    }

    private void ProfesorPageDark(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new ProfesorPageDark());
    }
}

