using Syncfusion.Maui.ImageEditor;

namespace SaveEdits_BackButton;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		this.imageEditor.ToolbarItemSelected += OnToolbarItemSelected;

    }

    private void OnToolbarItemSelected(object sender, ToolbarItemSelectedEventArgs e)
    {
        if (e.ToolbarItem != null && e.ToolbarItem.Name == "Back")
        {
            imageEditor.SaveEdits();
        }
    }
}