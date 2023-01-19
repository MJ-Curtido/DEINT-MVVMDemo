namespace DEINT_MVVMDemo.MVVM.Views;

public partial class PersonasView : ContentPage
{
	public PersonasView()
	{
		InitializeComponent();

		BindingContext = new PersonasView();
	}
}