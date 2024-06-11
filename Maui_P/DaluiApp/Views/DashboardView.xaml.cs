
using DaluiApp.Models;
using System.Collections.ObjectModel;

namespace DaluiApp.Views;

public partial class DashboardView : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }

	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }
	public DashboardView()
	{
		InitializeComponent();
		LoadData();
		BindingContext=this;
	}

    private void LoadData()
    {
        Profiles=new ObservableCollection<Profile>
		{
			new Profile
			{
				Name="Alex",
				ProfileImage="profile1.png",
				NoPhotos=12
				
			},
            new Profile
            {
                Name="Victor",
                ProfileImage="profile2.png",
                NoPhotos=5

            },
            new Profile
            {
                Name="Henry",
                ProfileImage="profile3.png",
                NoPhotos=25

            },
            

        };

        GeneratedImages=new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage
            {
                ImagePath="dashboard3.png",
                MainKeyword="castle",
                Keywords=new List<string>
                {
                    "Epic","hill","mountain","trees","blue sky"
                }

            },
            new GeneratedImage
            {
                ImagePath="dashboard1.png",
                MainKeyword="Mountains",
                Keywords=new List<string>
                {
                    "Landscape","photorealistic","mountain","sky"
                }

            },
            new GeneratedImage
            {
                ImagePath="dashboard2.png",
                MainKeyword="Robot",
                Keywords=new List<string>
                {
                    "AI","robotic","human","light","metal"
                }

            },
        };
    }
}