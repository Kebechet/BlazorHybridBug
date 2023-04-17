namespace BlazorHybridApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

    protected override Window CreateWindow(IActivationState? activationState)
    {
        MainPage ??= new MainPage();

        return base.CreateWindow(activationState);
    }
}
