namespace MauiApp3;

public partial class INotifyChanged : ContentPage
{
	Models.Employee emp = new Models.Employee();
	public INotifyChanged()
	{
		InitializeComponent();

		emp = new Models.Employee()
		{
			Id = 1,
			Name = "Milind",
			Age = 22,
		};

		BindingContext = emp;
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		emp.Id= 2;
		emp.Name = "Anurag";
		emp.Age= 21;
    }
}