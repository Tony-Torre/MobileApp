namespace MobileApp;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
		
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		if(!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text))
		{
			if(username.Text == "tony" && password.Text == "ciao" ) 
			{
				App.Current.MainPage = new NavigationPage(new DatiEmployee());
			}
			else
			{
				error.Text = "I dati inseriti sono errati";
			}
		}
		else if(string.IsNullOrEmpty(username.Text))
		{
			error.Text = "Inserisce un username";
		}
		else
		{
			error.Text = "Inserisce una password";

        }
    }
}