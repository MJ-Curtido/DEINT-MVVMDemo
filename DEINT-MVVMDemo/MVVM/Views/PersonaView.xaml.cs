using DEINT_MVVMDemo.MVVM.Models;
using DEINT_MVVMDemo.MVVM.ViewModels;

namespace DEINT_MVVMDemo.MVVM.Views;

public partial class PersonaView : ContentPage
{
	public PersonaView()
	{
		InitializeComponent();

		BindingContext = new PersonaViewModel();
	}
}