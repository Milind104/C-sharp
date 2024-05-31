namespace MauiApp1;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		MauiApp1.Models.Employee emp = new MauiApp1.Models.Employee()
		{
			Id = 1,
			Name = "Tarun",
			Age = 35

		};
		//Binding empBinding = new Binding();
		//empBinding.Source = emp;
		//empBinding.Path = "Name";
		//EmployeeLbl.SetBinding(Label.TextProperty, empBinding);
		BindingContext = emp;
		EmployeeLbl.SetBinding(Label.TextProperty, "Name");




    }
}