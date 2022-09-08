using MAUICalculater.MVVM.Views;

namespace MAUICalculater;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalcView();
	}
}
