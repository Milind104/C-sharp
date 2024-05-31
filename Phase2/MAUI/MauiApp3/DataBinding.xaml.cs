using MauiApp3.Models;

namespace MauiApp3;

public partial class DataBinding : ContentPage
{
	public DataBinding()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Employee emp = new Employee()
		{
			Id = 1,
			Name = "Milind",
			Age = 35
		};

        // single prop binding 
        /*Binding empBinding = new Binding();
		empBinding.Source = emp;
		empBinding.Path = "Name";

		EmployeeLbl.SetBinding(Label.TextProperty, empBinding);*/

        //multiple prop binding using Binding Context
        //BindingContext=emp;

        //single prop binding using Binding Context
        EmployeeLbl.BindingContext = emp;
		EmployeeLbl.SetBinding(Label.TextProperty, "Name");

		
    }
}