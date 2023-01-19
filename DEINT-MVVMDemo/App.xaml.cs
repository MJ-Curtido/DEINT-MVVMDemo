using DEINT_MVVMDemo.MVVM.Views;

namespace DEINT_MVVMDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PersonaView();
	}
}
