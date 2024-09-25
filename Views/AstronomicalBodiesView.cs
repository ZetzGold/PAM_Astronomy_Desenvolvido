namespace PAM_Astronomy.Views;

public class AstronomicalBodiesView : ContentPage
{
	public AstronomicalBodiesView()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}