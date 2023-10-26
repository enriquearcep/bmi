using BMI.ViewModel;

namespace BMI.Views;

public partial class DashboardView : ContentPage
{
	public DashboardView()
	{
		InitializeComponent();

		BindingContext = new DashboardViewModel();
	}
}