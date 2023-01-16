namespace AjdinBukvic_RMA_LAB2;

public partial class StudentPageLight : ContentPage
{
	public StudentPageLight()
	{
		InitializeComponent();
		ImePrezime.Text = "Ajdin Bukviæ";
		Lokacija.Text = "72000 Zenica";
		Godine.Text = "30.10.2001.";
		Friends.Text = "Friends: 123";
		Followers.Text = "Followers: 987";
	}
}