using System.Diagnostics;

namespace Arquitectura;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        var button = new Button();
        button.Text = "Create a Window";
        button.FontSize = 20;
        button.FontFamily = "Comic Sans MS";
        button.Clicked += (s, a) =>
        {
            var w2 = new Window(new ContentPage());
            OpenWindow(w2);
        };

        MainPage = new MainPage();
	}

    protected override void OnResume()
    {
        base.OnResume();
    }

    protected override void OnStart()
    {
        base.OnStart();
    }

    protected override void OnSleep()
    {
        base.OnSleep();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var w = base.CreateWindow(activationState);
        w.Created += W_Created;
        w.Deactivated += W_Deactivated;
        w.Activated += W_Activated;

        return w;
    }

    private void W_Activated(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(W_Activated));
    }

    private void W_Deactivated(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(W_Deactivated));
    }

    private void W_Created(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(W_Created));
    }
}
