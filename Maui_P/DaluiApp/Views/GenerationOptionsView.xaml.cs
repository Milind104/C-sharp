using DaluiApp.Models;

namespace DaluiApp.Views;

public partial class GenerationOptionsView : ContentPage
{
	public List<String> Options { get; set; }

	public List<ArtStyle> Styles { get; set; }
	public GenerationOptionsView()
	{
		InitializeComponent();
		FillOptions();
		BindingContext=this;	
	}

	private void FillOptions()
	{
		Options = new List<String>
		{
			"World",
			"Winter",
			"Treees"

		};
		Styles = new List<ArtStyle>()
		{

			new ArtStyle() {Name="Cartoon",ImageUrl="cartoon.png"},
            new ArtStyle() {Name="Realistic",ImageUrl="realistic.jpg"},
            new ArtStyle() {Name="Watercolor Art",ImageUrl="watercolor.jpg"},
            new ArtStyle() {Name="Isometric",ImageUrl="isometric.jpg"},
            new ArtStyle() {Name="Pop Art",ImageUrl="popart.jpg"},
            new ArtStyle() {Name="Surrealism",ImageUrl="surrealism.png"},
            new ArtStyle() {Name="Minimalism",ImageUrl="minimalism.jpg"},
            new ArtStyle() {Name="Funko",ImageUrl="funko.jpg"},
            new ArtStyle() {Name="Anime",ImageUrl="anime.jpg"},
            new ArtStyle() {Name="Storybook",ImageUrl="storybook.jpg"},

        };
	}
}