using MAUICalculater.MVVM.ViewModels;

namespace MAUICalculater.MVVM.Views;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}