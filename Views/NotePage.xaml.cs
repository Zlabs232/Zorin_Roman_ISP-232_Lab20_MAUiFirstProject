namespace Zorin_Roman_ISP_232_Lab20_MAUiFirstProject.Views;

public partial class NotePage : ContentPage
{
	string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");

	public void LoadNote(string fileName)
	{
		Models.Note noteModel = new Models.Note();
		noteModel.Filename = fileName;

		if(File.Exists(fileName))
		{
			noteModel.Date = File.GetCreationTime(fileName);
			noteModel.Text = File.ReadAllText(fileName);
		}

		BindingContext = noteModel;
	}

	public NotePage()
	{
		InitializeComponent();

		string appDataPath = FileSystem.AppDataDirectory;
		string randomFileName = $"{Path.GetRandomFileName()}.notes.txt";

		LoadNote(Path.Combine(appDataPath, randomFileName));
	}

	public void SaveButton_Clicked(object sender, EventArgs e)
	{
		File.WriteAllText(_fileName, TextEditor.Text);
	}

	public void DeleteButton_Clicked(object sender, EventArgs e)
	{
		if(File.Exists(_fileName))
			File.Delete(_fileName);

		TextEditor.Text = string.Empty;
	}
}